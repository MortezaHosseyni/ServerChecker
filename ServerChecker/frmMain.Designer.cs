namespace ServerChecker
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Author = new System.Windows.Forms.Label();
            this.txt_File = new System.Windows.Forms.TextBox();
            this.lbl_File = new System.Windows.Forms.Label();
            this.btn_File = new System.Windows.Forms.Button();
            this.lsb_GoodList = new System.Windows.Forms.ListBox();
            this.lbl_GoodList = new System.Windows.Forms.Label();
            this.btn_SaveGoodList = new System.Windows.Forms.Button();
            this.rtb_Log = new System.Windows.Forms.RichTextBox();
            this.lbl_Log = new System.Windows.Forms.Label();
            this.btn_SaveLog = new System.Windows.Forms.Button();
            this.btn_ClearLog = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btn_Start = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.pgb_Status = new System.Windows.Forms.ToolStripProgressBar();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbl_Title.Location = new System.Drawing.Point(322, 31);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(203, 31);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Server Checker";
            // 
            // lbl_Author
            // 
            this.lbl_Author.AutoSize = true;
            this.lbl_Author.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lbl_Author.Location = new System.Drawing.Point(441, 62);
            this.lbl_Author.Name = "lbl_Author";
            this.lbl_Author.Size = new System.Drawing.Size(79, 17);
            this.lbl_Author.TabIndex = 1;
            this.lbl_Author.Text = "By MrMean";
            // 
            // txt_File
            // 
            this.txt_File.Location = new System.Drawing.Point(151, 127);
            this.txt_File.Name = "txt_File";
            this.txt_File.Size = new System.Drawing.Size(567, 24);
            this.txt_File.TabIndex = 2;
            this.txt_File.TextChanged += new System.EventHandler(this.txt_File_TextChanged);
            // 
            // lbl_File
            // 
            this.lbl_File.AutoSize = true;
            this.lbl_File.Location = new System.Drawing.Point(114, 130);
            this.lbl_File.Name = "lbl_File";
            this.lbl_File.Size = new System.Drawing.Size(31, 18);
            this.lbl_File.TabIndex = 3;
            this.lbl_File.Text = "File";
            // 
            // btn_File
            // 
            this.btn_File.Location = new System.Drawing.Point(724, 127);
            this.btn_File.Name = "btn_File";
            this.btn_File.Size = new System.Drawing.Size(35, 24);
            this.btn_File.TabIndex = 4;
            this.btn_File.Text = "...";
            this.toolTip.SetToolTip(this.btn_File, "Select Server List...");
            this.btn_File.UseVisualStyleBackColor = true;
            this.btn_File.Click += new System.EventHandler(this.btn_File_Click);
            // 
            // lsb_GoodList
            // 
            this.lsb_GoodList.FormattingEnabled = true;
            this.lsb_GoodList.ItemHeight = 18;
            this.lsb_GoodList.Location = new System.Drawing.Point(12, 256);
            this.lsb_GoodList.Name = "lsb_GoodList";
            this.lsb_GoodList.Size = new System.Drawing.Size(346, 238);
            this.lsb_GoodList.TabIndex = 5;
            // 
            // lbl_GoodList
            // 
            this.lbl_GoodList.AutoSize = true;
            this.lbl_GoodList.Location = new System.Drawing.Point(12, 235);
            this.lbl_GoodList.Name = "lbl_GoodList";
            this.lbl_GoodList.Size = new System.Drawing.Size(73, 18);
            this.lbl_GoodList.TabIndex = 6;
            this.lbl_GoodList.Text = "Good List";
            // 
            // btn_SaveGoodList
            // 
            this.btn_SaveGoodList.Location = new System.Drawing.Point(91, 232);
            this.btn_SaveGoodList.Name = "btn_SaveGoodList";
            this.btn_SaveGoodList.Size = new System.Drawing.Size(35, 24);
            this.btn_SaveGoodList.TabIndex = 7;
            this.btn_SaveGoodList.Text = "💾";
            this.toolTip.SetToolTip(this.btn_SaveGoodList, "Save Good List");
            this.btn_SaveGoodList.UseVisualStyleBackColor = true;
            // 
            // rtb_Log
            // 
            this.rtb_Log.Location = new System.Drawing.Point(384, 256);
            this.rtb_Log.Name = "rtb_Log";
            this.rtb_Log.Size = new System.Drawing.Size(504, 238);
            this.rtb_Log.TabIndex = 8;
            this.rtb_Log.Text = "";
            // 
            // lbl_Log
            // 
            this.lbl_Log.AutoSize = true;
            this.lbl_Log.Location = new System.Drawing.Point(381, 232);
            this.lbl_Log.Name = "lbl_Log";
            this.lbl_Log.Size = new System.Drawing.Size(33, 18);
            this.lbl_Log.TabIndex = 9;
            this.lbl_Log.Text = "Log";
            // 
            // btn_SaveLog
            // 
            this.btn_SaveLog.Location = new System.Drawing.Point(420, 229);
            this.btn_SaveLog.Name = "btn_SaveLog";
            this.btn_SaveLog.Size = new System.Drawing.Size(35, 24);
            this.btn_SaveLog.TabIndex = 10;
            this.btn_SaveLog.Text = "💾";
            this.toolTip.SetToolTip(this.btn_SaveLog, "Save Log\'s");
            this.btn_SaveLog.UseVisualStyleBackColor = true;
            // 
            // btn_ClearLog
            // 
            this.btn_ClearLog.Location = new System.Drawing.Point(461, 229);
            this.btn_ClearLog.Name = "btn_ClearLog";
            this.btn_ClearLog.Size = new System.Drawing.Size(35, 24);
            this.btn_ClearLog.TabIndex = 11;
            this.btn_ClearLog.Text = "🧹";
            this.toolTip.SetToolTip(this.btn_ClearLog, "Clear Log\'s");
            this.btn_ClearLog.UseVisualStyleBackColor = true;
            // 
            // btn_Start
            // 
            this.btn_Start.Enabled = false;
            this.btn_Start.Location = new System.Drawing.Point(117, 171);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(642, 27);
            this.btn_Start.TabIndex = 12;
            this.btn_Start.Text = "Start";
            this.toolTip.SetToolTip(this.btn_Start, "Please select server list");
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pgb_Status});
            this.statusStrip.Location = new System.Drawing.Point(0, 510);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(900, 26);
            this.statusStrip.TabIndex = 13;
            this.statusStrip.Text = "statusStrip1";
            // 
            // pgb_Status
            // 
            this.pgb_Status.Name = "pgb_Status";
            this.pgb_Status.Size = new System.Drawing.Size(100, 18);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 536);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.btn_ClearLog);
            this.Controls.Add(this.btn_SaveLog);
            this.Controls.Add(this.lbl_Log);
            this.Controls.Add(this.rtb_Log);
            this.Controls.Add(this.btn_SaveGoodList);
            this.Controls.Add(this.lbl_GoodList);
            this.Controls.Add(this.lsb_GoodList);
            this.Controls.Add(this.btn_File);
            this.Controls.Add(this.lbl_File);
            this.Controls.Add(this.txt_File);
            this.Controls.Add(this.lbl_Author);
            this.Controls.Add(this.lbl_Title);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(918, 583);
            this.MinimumSize = new System.Drawing.Size(918, 583);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server Checker";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Author;
        private System.Windows.Forms.TextBox txt_File;
        private System.Windows.Forms.Label lbl_File;
        private System.Windows.Forms.Button btn_File;
        private System.Windows.Forms.ListBox lsb_GoodList;
        private System.Windows.Forms.Label lbl_GoodList;
        private System.Windows.Forms.Button btn_SaveGoodList;
        private System.Windows.Forms.RichTextBox rtb_Log;
        private System.Windows.Forms.Label lbl_Log;
        private System.Windows.Forms.Button btn_SaveLog;
        private System.Windows.Forms.Button btn_ClearLog;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripProgressBar pgb_Status;
    }
}

