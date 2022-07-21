
namespace MailShredder
{
    partial class FormMain
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
            this.groupBox_Onprem = new System.Windows.Forms.GroupBox();
            this.txt_OnpremPwd = new System.Windows.Forms.TextBox();
            this.txt_OnpremUser = new System.Windows.Forms.TextBox();
            this.txt_OnpremDomain = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_OnpremEWSUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_O365ClientCredential = new System.Windows.Forms.TextBox();
            this.txt_O365ApplicationId = new System.Windows.Forms.TextBox();
            this.txt_O365TenantId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rdb_EnvOnprem = new System.Windows.Forms.RadioButton();
            this.rdb_EnvO365 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_AlertEnd = new System.Windows.Forms.Label();
            this.lbl_AlertStart = new System.Windows.Forms.Label();
            this.lbl_AlertSubject = new System.Windows.Forms.Label();
            this.lbl_AlertMessageID = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_KW_Subject = new System.Windows.Forms.TextBox();
            this.txt_KW_End = new System.Windows.Forms.TextBox();
            this.txt_KW_Start = new System.Windows.Forms.TextBox();
            this.txt_KW_MessageID = new System.Windows.Forms.TextBox();
            this.rdb_KW_Subject = new System.Windows.Forms.RadioButton();
            this.rdb_KW_MwssageId = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_BrowseMailboxList = new System.Windows.Forms.Button();
            this.btn_Run = new System.Windows.Forms.Button();
            this.txt_MailboxList = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbx_CalculateOnly = new System.Windows.Forms.CheckBox();
            this.pb_Progress = new System.Windows.Forms.ProgressBar();
            this.lbl_Progress = new System.Windows.Forms.Label();
            this.lbl_AlertMailbox = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDefaultSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCurrentSettingAsDefaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cbx_21V = new System.Windows.Forms.CheckBox();
            this.groupBox_Onprem.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Onprem
            // 
            this.groupBox_Onprem.Controls.Add(this.txt_OnpremPwd);
            this.groupBox_Onprem.Controls.Add(this.txt_OnpremUser);
            this.groupBox_Onprem.Controls.Add(this.txt_OnpremDomain);
            this.groupBox_Onprem.Controls.Add(this.label5);
            this.groupBox_Onprem.Controls.Add(this.label4);
            this.groupBox_Onprem.Controls.Add(this.label3);
            this.groupBox_Onprem.Controls.Add(this.label2);
            this.groupBox_Onprem.Controls.Add(this.txt_OnpremEWSUrl);
            this.groupBox_Onprem.Controls.Add(this.label1);
            this.groupBox_Onprem.Location = new System.Drawing.Point(22, 78);
            this.groupBox_Onprem.Name = "groupBox_Onprem";
            this.groupBox_Onprem.Size = new System.Drawing.Size(543, 198);
            this.groupBox_Onprem.TabIndex = 0;
            this.groupBox_Onprem.TabStop = false;
            // 
            // txt_OnpremPwd
            // 
            this.txt_OnpremPwd.Location = new System.Drawing.Point(132, 95);
            this.txt_OnpremPwd.Name = "txt_OnpremPwd";
            this.txt_OnpremPwd.PasswordChar = '*';
            this.txt_OnpremPwd.Size = new System.Drawing.Size(398, 26);
            this.txt_OnpremPwd.TabIndex = 5;
            // 
            // txt_OnpremUser
            // 
            this.txt_OnpremUser.Location = new System.Drawing.Point(132, 62);
            this.txt_OnpremUser.Name = "txt_OnpremUser";
            this.txt_OnpremUser.Size = new System.Drawing.Size(398, 26);
            this.txt_OnpremUser.TabIndex = 5;
            // 
            // txt_OnpremDomain
            // 
            this.txt_OnpremDomain.Location = new System.Drawing.Point(132, 26);
            this.txt_OnpremDomain.Name = "txt_OnpremDomain";
            this.txt_OnpremDomain.Size = new System.Drawing.Size(398, 26);
            this.txt_OnpremDomain.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Password: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "User or SMTP: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Domain: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(397, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Esp: https://ex1601.contoso.com/EWS/Exchange.asmx";
            // 
            // txt_OnpremEWSUrl
            // 
            this.txt_OnpremEWSUrl.Location = new System.Drawing.Point(94, 131);
            this.txt_OnpremEWSUrl.Name = "txt_OnpremEWSUrl";
            this.txt_OnpremEWSUrl.Size = new System.Drawing.Size(436, 26);
            this.txt_OnpremEWSUrl.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "EWS Url: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_O365ClientCredential);
            this.groupBox1.Controls.Add(this.txt_O365ApplicationId);
            this.groupBox1.Controls.Add(this.txt_O365TenantId);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(608, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 198);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txt_O365ClientCredential
            // 
            this.txt_O365ClientCredential.Location = new System.Drawing.Point(152, 95);
            this.txt_O365ClientCredential.Name = "txt_O365ClientCredential";
            this.txt_O365ClientCredential.Size = new System.Drawing.Size(428, 26);
            this.txt_O365ClientCredential.TabIndex = 1;
            // 
            // txt_O365ApplicationId
            // 
            this.txt_O365ApplicationId.Location = new System.Drawing.Point(152, 62);
            this.txt_O365ApplicationId.Name = "txt_O365ApplicationId";
            this.txt_O365ApplicationId.Size = new System.Drawing.Size(428, 26);
            this.txt_O365ApplicationId.TabIndex = 1;
            // 
            // txt_O365TenantId
            // 
            this.txt_O365TenantId.Location = new System.Drawing.Point(152, 26);
            this.txt_O365TenantId.Name = "txt_O365TenantId";
            this.txt_O365TenantId.Size = new System.Drawing.Size(428, 26);
            this.txt_O365TenantId.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Application Id: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Client Credentail: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tenant Id: ";
            // 
            // rdb_EnvOnprem
            // 
            this.rdb_EnvOnprem.AutoSize = true;
            this.rdb_EnvOnprem.Location = new System.Drawing.Point(22, 48);
            this.rdb_EnvOnprem.Name = "rdb_EnvOnprem";
            this.rdb_EnvOnprem.Size = new System.Drawing.Size(122, 24);
            this.rdb_EnvOnprem.TabIndex = 3;
            this.rdb_EnvOnprem.TabStop = true;
            this.rdb_EnvOnprem.Text = "Onprem Env";
            this.rdb_EnvOnprem.UseVisualStyleBackColor = true;
            this.rdb_EnvOnprem.CheckedChanged += new System.EventHandler(this.rdb_EnvOnprem_CheckedChanged);
            // 
            // rdb_EnvO365
            // 
            this.rdb_EnvO365.AutoSize = true;
            this.rdb_EnvO365.Location = new System.Drawing.Point(608, 49);
            this.rdb_EnvO365.Name = "rdb_EnvO365";
            this.rdb_EnvO365.Size = new System.Drawing.Size(104, 24);
            this.rdb_EnvO365.TabIndex = 3;
            this.rdb_EnvO365.TabStop = true;
            this.rdb_EnvO365.Text = "O365 Env";
            this.rdb_EnvO365.UseVisualStyleBackColor = true;
            this.rdb_EnvO365.CheckedChanged += new System.EventHandler(this.rdb_EnvO365_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_AlertEnd);
            this.groupBox2.Controls.Add(this.lbl_AlertStart);
            this.groupBox2.Controls.Add(this.lbl_AlertSubject);
            this.groupBox2.Controls.Add(this.lbl_AlertMessageID);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txt_KW_Subject);
            this.groupBox2.Controls.Add(this.txt_KW_End);
            this.groupBox2.Controls.Add(this.txt_KW_Start);
            this.groupBox2.Controls.Add(this.txt_KW_MessageID);
            this.groupBox2.Controls.Add(this.rdb_KW_Subject);
            this.groupBox2.Controls.Add(this.rdb_KW_MwssageId);
            this.groupBox2.Location = new System.Drawing.Point(22, 285);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1184, 149);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Key Word:";
            // 
            // lbl_AlertEnd
            // 
            this.lbl_AlertEnd.AutoSize = true;
            this.lbl_AlertEnd.ForeColor = System.Drawing.Color.Red;
            this.lbl_AlertEnd.Location = new System.Drawing.Point(1168, 32);
            this.lbl_AlertEnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_AlertEnd.Name = "lbl_AlertEnd";
            this.lbl_AlertEnd.Size = new System.Drawing.Size(13, 20);
            this.lbl_AlertEnd.TabIndex = 13;
            this.lbl_AlertEnd.Text = "!";
            // 
            // lbl_AlertStart
            // 
            this.lbl_AlertStart.AutoSize = true;
            this.lbl_AlertStart.ForeColor = System.Drawing.Color.Red;
            this.lbl_AlertStart.Location = new System.Drawing.Point(538, 34);
            this.lbl_AlertStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_AlertStart.Name = "lbl_AlertStart";
            this.lbl_AlertStart.Size = new System.Drawing.Size(13, 20);
            this.lbl_AlertStart.TabIndex = 13;
            this.lbl_AlertStart.Text = "!";
            // 
            // lbl_AlertSubject
            // 
            this.lbl_AlertSubject.AutoSize = true;
            this.lbl_AlertSubject.ForeColor = System.Drawing.Color.Red;
            this.lbl_AlertSubject.Location = new System.Drawing.Point(1168, 115);
            this.lbl_AlertSubject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_AlertSubject.Name = "lbl_AlertSubject";
            this.lbl_AlertSubject.Size = new System.Drawing.Size(13, 20);
            this.lbl_AlertSubject.TabIndex = 13;
            this.lbl_AlertSubject.Text = "!";
            // 
            // lbl_AlertMessageID
            // 
            this.lbl_AlertMessageID.AutoSize = true;
            this.lbl_AlertMessageID.ForeColor = System.Drawing.Color.Red;
            this.lbl_AlertMessageID.Location = new System.Drawing.Point(1168, 72);
            this.lbl_AlertMessageID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_AlertMessageID.Name = "lbl_AlertMessageID";
            this.lbl_AlertMessageID.Size = new System.Drawing.Size(13, 20);
            this.lbl_AlertMessageID.TabIndex = 13;
            this.lbl_AlertMessageID.Text = "!";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(640, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "End: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "Start: ";
            // 
            // txt_KW_Subject
            // 
            this.txt_KW_Subject.Location = new System.Drawing.Point(134, 111);
            this.txt_KW_Subject.Name = "txt_KW_Subject";
            this.txt_KW_Subject.Size = new System.Drawing.Size(1032, 26);
            this.txt_KW_Subject.TabIndex = 2;
            // 
            // txt_KW_End
            // 
            this.txt_KW_End.Location = new System.Drawing.Point(698, 28);
            this.txt_KW_End.Name = "txt_KW_End";
            this.txt_KW_End.Size = new System.Drawing.Size(464, 26);
            this.txt_KW_End.TabIndex = 5;
            // 
            // txt_KW_Start
            // 
            this.txt_KW_Start.Location = new System.Drawing.Point(64, 31);
            this.txt_KW_Start.Name = "txt_KW_Start";
            this.txt_KW_Start.Size = new System.Drawing.Size(464, 26);
            this.txt_KW_Start.TabIndex = 5;
            // 
            // txt_KW_MessageID
            // 
            this.txt_KW_MessageID.Location = new System.Drawing.Point(134, 71);
            this.txt_KW_MessageID.Name = "txt_KW_MessageID";
            this.txt_KW_MessageID.Size = new System.Drawing.Size(1032, 26);
            this.txt_KW_MessageID.TabIndex = 2;
            // 
            // rdb_KW_Subject
            // 
            this.rdb_KW_Subject.AutoSize = true;
            this.rdb_KW_Subject.Location = new System.Drawing.Point(10, 112);
            this.rdb_KW_Subject.Name = "rdb_KW_Subject";
            this.rdb_KW_Subject.Size = new System.Drawing.Size(96, 24);
            this.rdb_KW_Subject.TabIndex = 1;
            this.rdb_KW_Subject.TabStop = true;
            this.rdb_KW_Subject.Text = "Subject: ";
            this.rdb_KW_Subject.UseVisualStyleBackColor = true;
            this.rdb_KW_Subject.CheckedChanged += new System.EventHandler(this.rdb_KW_Subject_CheckedChanged);
            // 
            // rdb_KW_MwssageId
            // 
            this.rdb_KW_MwssageId.AutoSize = true;
            this.rdb_KW_MwssageId.Location = new System.Drawing.Point(10, 72);
            this.rdb_KW_MwssageId.Name = "rdb_KW_MwssageId";
            this.rdb_KW_MwssageId.Size = new System.Drawing.Size(125, 24);
            this.rdb_KW_MwssageId.TabIndex = 0;
            this.rdb_KW_MwssageId.TabStop = true;
            this.rdb_KW_MwssageId.Text = "Message Id: ";
            this.rdb_KW_MwssageId.UseVisualStyleBackColor = true;
            this.rdb_KW_MwssageId.CheckedChanged += new System.EventHandler(this.rdb_KW_MwssageId_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_BrowseMailboxList
            // 
            this.btn_BrowseMailboxList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BrowseMailboxList.Location = new System.Drawing.Point(22, 440);
            this.btn_BrowseMailboxList.Name = "btn_BrowseMailboxList";
            this.btn_BrowseMailboxList.Size = new System.Drawing.Size(171, 34);
            this.btn_BrowseMailboxList.TabIndex = 6;
            this.btn_BrowseMailboxList.Text = "Load Mailbox List";
            this.btn_BrowseMailboxList.UseVisualStyleBackColor = true;
            this.btn_BrowseMailboxList.Click += new System.EventHandler(this.btn_BrowseMailboxList_Click);
            // 
            // btn_Run
            // 
            this.btn_Run.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Run.Location = new System.Drawing.Point(472, 894);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(274, 46);
            this.btn_Run.TabIndex = 7;
            this.btn_Run.Text = "Run";
            this.btn_Run.UseVisualStyleBackColor = true;
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // txt_MailboxList
            // 
            this.txt_MailboxList.Location = new System.Drawing.Point(22, 482);
            this.txt_MailboxList.Multiline = true;
            this.txt_MailboxList.Name = "txt_MailboxList";
            this.txt_MailboxList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_MailboxList.Size = new System.Drawing.Size(1184, 364);
            this.txt_MailboxList.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbx_21V);
            this.panel1.Location = new System.Drawing.Point(2, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1228, 243);
            this.panel1.TabIndex = 9;
            // 
            // cbx_CalculateOnly
            // 
            this.cbx_CalculateOnly.AutoSize = true;
            this.cbx_CalculateOnly.Location = new System.Drawing.Point(456, 863);
            this.cbx_CalculateOnly.Name = "cbx_CalculateOnly";
            this.cbx_CalculateOnly.Size = new System.Drawing.Size(305, 24);
            this.cbx_CalculateOnly.TabIndex = 10;
            this.cbx_CalculateOnly.Text = "Do not delete the mails, calculate only.";
            this.cbx_CalculateOnly.UseVisualStyleBackColor = true;
            // 
            // pb_Progress
            // 
            this.pb_Progress.Location = new System.Drawing.Point(22, 851);
            this.pb_Progress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pb_Progress.Name = "pb_Progress";
            this.pb_Progress.Size = new System.Drawing.Size(1162, 8);
            this.pb_Progress.TabIndex = 11;
            // 
            // lbl_Progress
            // 
            this.lbl_Progress.AutoSize = true;
            this.lbl_Progress.Location = new System.Drawing.Point(1185, 851);
            this.lbl_Progress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Progress.Name = "lbl_Progress";
            this.lbl_Progress.Size = new System.Drawing.Size(32, 20);
            this.lbl_Progress.TabIndex = 12;
            this.lbl_Progress.Text = "0%";
            // 
            // lbl_AlertMailbox
            // 
            this.lbl_AlertMailbox.AutoSize = true;
            this.lbl_AlertMailbox.ForeColor = System.Drawing.Color.Red;
            this.lbl_AlertMailbox.Location = new System.Drawing.Point(201, 448);
            this.lbl_AlertMailbox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_AlertMailbox.Name = "lbl_AlertMailbox";
            this.lbl_AlertMailbox.Size = new System.Drawing.Size(13, 20);
            this.lbl_AlertMailbox.TabIndex = 13;
            this.lbl_AlertMailbox.Text = "!";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1230, 35);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadDefaultSettingToolStripMenuItem,
            this.saveCurrentSettingAsDefaultToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(54, 29);
            this.toolStripMenuItem1.Text = "File";
            // 
            // loadDefaultSettingToolStripMenuItem
            // 
            this.loadDefaultSettingToolStripMenuItem.Name = "loadDefaultSettingToolStripMenuItem";
            this.loadDefaultSettingToolStripMenuItem.Size = new System.Drawing.Size(362, 34);
            this.loadDefaultSettingToolStripMenuItem.Text = "Load Default Setting";
            this.loadDefaultSettingToolStripMenuItem.Click += new System.EventHandler(this.loadDefaultSettingToolStripMenuItem_Click);
            // 
            // saveCurrentSettingAsDefaultToolStripMenuItem
            // 
            this.saveCurrentSettingAsDefaultToolStripMenuItem.Name = "saveCurrentSettingAsDefaultToolStripMenuItem";
            this.saveCurrentSettingAsDefaultToolStripMenuItem.Size = new System.Drawing.Size(362, 34);
            this.saveCurrentSettingAsDefaultToolStripMenuItem.Text = "Save Current Setting As Default";
            this.saveCurrentSettingAsDefaultToolStripMenuItem.Click += new System.EventHandler(this.saveCurrentSettingAsDefaultToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactUsToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // contactUsToolStripMenuItem
            // 
            this.contactUsToolStripMenuItem.Name = "contactUsToolStripMenuItem";
            this.contactUsToolStripMenuItem.Size = new System.Drawing.Size(458, 34);
            this.contactUsToolStripMenuItem.Text = "Contact Us";
            this.contactUsToolStripMenuItem.Click += new System.EventHandler(this.contactUsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(458, 34);
            this.helpToolStripMenuItem1.Text = "How to register Application for EWS OAuth";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // cbx_21V
            // 
            this.cbx_21V.AutoSize = true;
            this.cbx_21V.Location = new System.Drawing.Point(758, 14);
            this.cbx_21V.Name = "cbx_21V";
            this.cbx_21V.Size = new System.Drawing.Size(64, 24);
            this.cbx_21V.TabIndex = 0;
            this.cbx_21V.Text = "21V";
            this.cbx_21V.UseVisualStyleBackColor = true;
            this.cbx_21V.CheckedChanged += new System.EventHandler(this.cbx_21V_CheckedChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 945);
            this.Controls.Add(this.lbl_AlertMailbox);
            this.Controls.Add(this.lbl_Progress);
            this.Controls.Add(this.pb_Progress);
            this.Controls.Add(this.cbx_CalculateOnly);
            this.Controls.Add(this.txt_MailboxList);
            this.Controls.Add(this.btn_Run);
            this.Controls.Add(this.btn_BrowseMailboxList);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.rdb_EnvO365);
            this.Controls.Add(this.rdb_EnvOnprem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_Onprem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "MailShredder";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox_Onprem.ResumeLayout(false);
            this.groupBox_Onprem.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Onprem;
        private System.Windows.Forms.TextBox txt_OnpremPwd;
        private System.Windows.Forms.TextBox txt_OnpremUser;
        private System.Windows.Forms.TextBox txt_OnpremDomain;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_OnpremEWSUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_O365ClientCredential;
        private System.Windows.Forms.TextBox txt_O365ApplicationId;
        private System.Windows.Forms.TextBox txt_O365TenantId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdb_EnvOnprem;
        private System.Windows.Forms.RadioButton rdb_EnvO365;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdb_KW_Subject;
        private System.Windows.Forms.RadioButton rdb_KW_MwssageId;
        private System.Windows.Forms.TextBox txt_KW_Subject;
        private System.Windows.Forms.TextBox txt_KW_MessageID;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_BrowseMailboxList;
        private System.Windows.Forms.Button btn_Run;
        private System.Windows.Forms.TextBox txt_MailboxList;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_KW_End;
        private System.Windows.Forms.TextBox txt_KW_Start;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbx_CalculateOnly;
        private System.Windows.Forms.ProgressBar pb_Progress;
        private System.Windows.Forms.Label lbl_Progress;
        private System.Windows.Forms.Label lbl_AlertSubject;
        private System.Windows.Forms.Label lbl_AlertMessageID;
        private System.Windows.Forms.Label lbl_AlertMailbox;
        private System.Windows.Forms.Label lbl_AlertEnd;
        private System.Windows.Forms.Label lbl_AlertStart;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loadDefaultSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveCurrentSettingAsDefaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.CheckBox cbx_21V;
    }
}

