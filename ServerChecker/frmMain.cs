using System;
using System.IO;
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
    }
}
