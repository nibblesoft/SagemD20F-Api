namespace SagemRouterClient
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonReboot = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonBackup = new System.Windows.Forms.Button();
            this.buttonUploadConfig = new System.Windows.Forms.Button();
            this.buttonBrowseConfiFile = new System.Windows.Forms.Button();
            this.textBoxConfigs = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxMacFiltering = new System.Windows.Forms.CheckBox();
            this.buttonRemoveMac = new System.Windows.Forms.Button();
            this.buttonAddMac = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMac = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.buttonReAuthenticate = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.buttonIsConnected = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonUpdateMacFiltering = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonDisconnect);
            this.groupBox1.Controls.Add(this.buttonRefresh);
            this.groupBox1.Controls.Add(this.buttonReboot);
            this.groupBox1.Location = new System.Drawing.Point(19, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 78);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General:";
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(22, 29);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(75, 23);
            this.buttonDisconnect.TabIndex = 2;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(119, 29);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 1;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonReboot
            // 
            this.buttonReboot.Location = new System.Drawing.Point(210, 29);
            this.buttonReboot.Name = "buttonReboot";
            this.buttonReboot.Size = new System.Drawing.Size(75, 23);
            this.buttonReboot.TabIndex = 0;
            this.buttonReboot.Text = "Reboot";
            this.buttonReboot.UseVisualStyleBackColor = true;
            this.buttonReboot.Click += new System.EventHandler(this.buttonReboot_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.buttonRemoveMac);
            this.groupBox2.Controls.Add(this.buttonAddMac);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxMac);
            this.groupBox2.Location = new System.Drawing.Point(333, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(379, 199);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mac:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonBackup);
            this.groupBox5.Controls.Add(this.buttonUploadConfig);
            this.groupBox5.Controls.Add(this.buttonBrowseConfiFile);
            this.groupBox5.Controls.Add(this.textBoxConfigs);
            this.groupBox5.Location = new System.Drawing.Point(199, 75);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(174, 118);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Configurations:";
            // 
            // buttonBackup
            // 
            this.buttonBackup.Location = new System.Drawing.Point(99, 89);
            this.buttonBackup.Name = "buttonBackup";
            this.buttonBackup.Size = new System.Drawing.Size(75, 23);
            this.buttonBackup.TabIndex = 3;
            this.buttonBackup.Text = "Backup";
            this.buttonBackup.UseVisualStyleBackColor = true;
            this.buttonBackup.Click += new System.EventHandler(this.buttonBackup_Click);
            // 
            // buttonUploadConfig
            // 
            this.buttonUploadConfig.Location = new System.Drawing.Point(6, 44);
            this.buttonUploadConfig.Name = "buttonUploadConfig";
            this.buttonUploadConfig.Size = new System.Drawing.Size(89, 23);
            this.buttonUploadConfig.TabIndex = 2;
            this.buttonUploadConfig.Text = "Upload configs";
            this.buttonUploadConfig.UseVisualStyleBackColor = true;
            this.buttonUploadConfig.Click += new System.EventHandler(this.ButtonUploadConfigClickAsync);
            // 
            // buttonBrowseConfiFile
            // 
            this.buttonBrowseConfiFile.Location = new System.Drawing.Point(143, 20);
            this.buttonBrowseConfiFile.Name = "buttonBrowseConfiFile";
            this.buttonBrowseConfiFile.Size = new System.Drawing.Size(25, 23);
            this.buttonBrowseConfiFile.TabIndex = 1;
            this.buttonBrowseConfiFile.Text = ",..";
            this.buttonBrowseConfiFile.UseVisualStyleBackColor = true;
            this.buttonBrowseConfiFile.Click += new System.EventHandler(this.buttonBrowseConfiFile_Click);
            // 
            // textBoxConfigs
            // 
            this.textBoxConfigs.Location = new System.Drawing.Point(6, 21);
            this.textBoxConfigs.Name = "textBoxConfigs";
            this.textBoxConfigs.Size = new System.Drawing.Size(131, 20);
            this.textBoxConfigs.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonUpdateMacFiltering);
            this.groupBox3.Controls.Add(this.checkBoxMacFiltering);
            this.groupBox3.Location = new System.Drawing.Point(20, 75);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(173, 73);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mac filtering";
            // 
            // checkBoxMacFiltering
            // 
            this.checkBoxMacFiltering.AutoSize = true;
            this.checkBoxMacFiltering.Location = new System.Drawing.Point(6, 32);
            this.checkBoxMacFiltering.Name = "checkBoxMacFiltering";
            this.checkBoxMacFiltering.Size = new System.Drawing.Size(83, 17);
            this.checkBoxMacFiltering.TabIndex = 6;
            this.checkBoxMacFiltering.Text = "Mac filtering";
            this.checkBoxMacFiltering.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveMac
            // 
            this.buttonRemoveMac.Location = new System.Drawing.Point(229, 23);
            this.buttonRemoveMac.Name = "buttonRemoveMac";
            this.buttonRemoveMac.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveMac.TabIndex = 3;
            this.buttonRemoveMac.Text = "Remove";
            this.buttonRemoveMac.UseVisualStyleBackColor = true;
            this.buttonRemoveMac.Click += new System.EventHandler(this.buttonRemoveMac_Click);
            // 
            // buttonAddMac
            // 
            this.buttonAddMac.Location = new System.Drawing.Point(148, 23);
            this.buttonAddMac.Name = "buttonAddMac";
            this.buttonAddMac.Size = new System.Drawing.Size(75, 23);
            this.buttonAddMac.TabIndex = 2;
            this.buttonAddMac.Text = "Add";
            this.buttonAddMac.UseVisualStyleBackColor = true;
            this.buttonAddMac.Click += new System.EventHandler(this.buttonAddMac_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mac address:";
            // 
            // textBoxMac
            // 
            this.textBoxMac.Location = new System.Drawing.Point(20, 49);
            this.textBoxMac.Name = "textBoxMac";
            this.textBoxMac.Size = new System.Drawing.Size(284, 20);
            this.textBoxMac.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "By: Ivandro Ismael";
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(19, 255);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(693, 170);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Hostname";
            this.columnHeader1.Width = 147;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "MAC Address";
            this.columnHeader2.Width = 168;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "IP Address";
            this.columnHeader3.Width = 178;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Expires In";
            this.columnHeader4.Width = 189;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Connected users:";
            // 
            // buttonReAuthenticate
            // 
            this.buttonReAuthenticate.Location = new System.Drawing.Point(165, 19);
            this.buttonReAuthenticate.Name = "buttonReAuthenticate";
            this.buttonReAuthenticate.Size = new System.Drawing.Size(137, 23);
            this.buttonReAuthenticate.TabIndex = 9;
            this.buttonReAuthenticate.Text = "Re-Authenticate";
            this.buttonReAuthenticate.UseVisualStyleBackColor = true;
            this.buttonReAuthenticate.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonReAuthenticate);
            this.groupBox4.Location = new System.Drawing.Point(19, 106);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(308, 58);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Authentification:";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(652, 428);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(60, 13);
            this.labelStatus.TabIndex = 11;
            this.labelStatus.Text = "Idle: Status";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.buttonIsConnected);
            this.groupBox6.Controls.Add(this.textBox1);
            this.groupBox6.Location = new System.Drawing.Point(19, 170);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(308, 66);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Check for connected user:";
            // 
            // buttonIsConnected
            // 
            this.buttonIsConnected.Location = new System.Drawing.Point(217, 24);
            this.buttonIsConnected.Name = "buttonIsConnected";
            this.buttonIsConnected.Size = new System.Drawing.Size(85, 23);
            this.buttonIsConnected.TabIndex = 1;
            this.buttonIsConnected.Text = "Is Connected?";
            this.buttonIsConnected.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 20);
            this.textBox1.TabIndex = 0;
            // 
            // buttonUpdateMacFiltering
            // 
            this.buttonUpdateMacFiltering.Location = new System.Drawing.Point(92, 32);
            this.buttonUpdateMacFiltering.Name = "buttonUpdateMacFiltering";
            this.buttonUpdateMacFiltering.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateMacFiltering.TabIndex = 7;
            this.buttonUpdateMacFiltering.Text = "Update";
            this.buttonUpdateMacFiltering.UseVisualStyleBackColor = true;
            this.buttonUpdateMacFiltering.Click += new System.EventHandler(this.buttonUpdateMacFiltering_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 450);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Sagem D20F - Client";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonReboot;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMac;
        private System.Windows.Forms.Button buttonRemoveMac;
        private System.Windows.Forms.Button buttonAddMac;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonReAuthenticate;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBoxMacFiltering;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonUploadConfig;
        private System.Windows.Forms.Button buttonBrowseConfiFile;
        private System.Windows.Forms.TextBox textBoxConfigs;
        private System.Windows.Forms.Button buttonBackup;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button buttonIsConnected;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonUpdateMacFiltering;
    }
}

