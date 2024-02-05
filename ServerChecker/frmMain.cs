using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerChecker
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        #region File Selection
        private void btn_File_Click(object sender, EventArgs e)
        {
            OpenFileDialog serverList = new OpenFileDialog();

            serverList.Title = "Server List";
            serverList.Filter = "Text Files (*.txt)|*.txt";

            if (serverList.ShowDialog() == DialogResult.OK && File.Exists(serverList.FileName))
            {
                txt_File.Text = serverList.FileName;

                btn_Start.Enabled = true;
                toolTip.SetToolTip(btn_Start, "Start checking process");
            }
            else
            {
                btn_Start.Enabled = false;
                toolTip.SetToolTip(btn_Start, "Please select server list");
            }
        }

        private void txt_File_TextChanged(object sender, EventArgs e)
        {
            if (!File.Exists(txt_File.Text))
            {
                btn_Start.Enabled = false;
                toolTip.SetToolTip(btn_Start, "Please select server list");
            }
            else
            {
                btn_Start.Enabled = true;
                toolTip.SetToolTip(btn_Start, "Start checking process");
            }
        }
        #endregion

        private async void btn_Start_Click(object sender, EventArgs e)
        {
            try
            {
                string inputFile = txt_File.Text;
                if (!File.Exists(inputFile) || !string.Equals(Path.GetExtension(inputFile), ".txt", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("File not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string[] lines = File.ReadAllLines(inputFile);

                int totalServers = lines.Length;
                int currentServer = 0;

                foreach (string line in lines)
                {
                    string[] parts = line.Split('@');
                    string[] addressParts = parts[0].Split(':');
                    string ip = addressParts[0];
                    int port = int.Parse(addressParts[1]);

                    string[] credentials = parts[1].Split(';');
                    string username = credentials[0];
                    string password = credentials[1];

                    bool isSuccess = await TestRdpConnectionAsync(ip, port, username, password);

                    string logMessage = $"{DateTime.Now}: {ip} - {username} - {(isSuccess ? "OK" : "Failed")}";
                    UpdateRichTextBoxLogs(logMessage);

                    if (isSuccess)
                    {
                        UpdateListBoxGoodServers($"{ip} - {username}");
                    }

                    currentServer++;
                    UpdateProgressBar(currentServer, totalServers);
                }

                Console.WriteLine("Done!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        #region Test Section
        private async Task<bool> TestRdpConnectionAsync(string ip, int port, string username, string password)
        {
            try
            {
                return await Task.Run(() =>
                {
                    AxMSTSCLib.AxMsRdpClient11 rdp = new AxMSTSCLib.AxMsRdpClient11();
                    rdp.Server = ip;
                    rdp.AdvancedSettings2.RDPPort = port;
                    rdp.UserName = username;
                    rdp.AdvancedSettings2.ClearTextPassword = password;
                    rdp.ConnectingText = "Connecting...";
                    rdp.DisconnectedText = "Disconnected";
                    rdp.FullScreen = false;

                    rdp.Connect();
                    rdp.Disconnect();
                    return true;
                });
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void UpdateRichTextBoxLogs(string logMessage)
        {
            rtb_Log.AppendText(logMessage + Environment.NewLine);
            rtb_Log.ScrollToCaret();
        }

        private void UpdateListBoxGoodServers(string serverInfo)
        {
            lsb_GoodList.Items.Add(serverInfo);
        }

        private void UpdateProgressBar(int current, int total)
        {
            double percentage = (double)current / total * 100;
            pgb_Status.Value = (int)percentage;
        }
        #endregion

        #region Save Section
        private void btn_SaveGoodList_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveGoodServers = new SaveFileDialog();
            saveGoodServers.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveGoodServers.Title = "Save Good Servers";

            if (saveGoodServers.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveGoodServers.FileName;

                ListBox.ObjectCollection items = lsb_GoodList.Items;

                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    foreach (var item in items)
                    {
                        sw.WriteLine(item.ToString());
                    }
                }

                MessageBox.Show("Good servers list saved successfully!", "Saved!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_SaveLog_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveLogs = new SaveFileDialog();
            saveLogs.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveLogs.Title = "Save Logs";

            if (saveLogs.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveLogs.FileName;

                string content = rtb_Log.Text;

                File.WriteAllText(filePath, content);

                MessageBox.Show("Logs content saved successfully!", "Saved!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_ClearLog_Click(object sender, EventArgs e)
        {
            rtb_Log.Text = string.Empty;
            pgb_Status.Value = 0;
        }
        #endregion
    }
}
