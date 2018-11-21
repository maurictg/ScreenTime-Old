namespace ScreenTime
{
    partial class frmAdmin
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
            MaterialSkin.Controls.MaterialRaisedButton btnSaveTime;
            MaterialSkin.Controls.MaterialRaisedButton btnCancelTime;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabs = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.pbDelUser = new System.Windows.Forms.PictureBox();
            this.pnlUInfo = new System.Windows.Forms.Panel();
            this.btnSaveInfo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCancelInfo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label16 = new System.Windows.Forms.Label();
            this.tbInfoPass = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbUsernameInfo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ddUsers2 = new Bunifu.Framework.UI.BunifuDropdown();
            this.label12 = new System.Windows.Forms.Label();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.btnAddCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbPass2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbPass1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbUsername = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.btnAScheme = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbDay = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dpTo = new System.Windows.Forms.DateTimePicker();
            this.dpFrom = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDag = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.tbBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.ddUsername = new Bunifu.Framework.UI.BunifuDropdown();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnUserSettings = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnExit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnRestart = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pnlStartup = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.btnInteg = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbAnpw = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnSaveAPW = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label18 = new System.Windows.Forms.Label();
            this.tbApass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label17 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            btnSaveTime = new MaterialSkin.Controls.MaterialRaisedButton();
            btnCancelTime = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tabs.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelUser)).BeginInit();
            this.pnlUInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            this.pnlAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbBar)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.pnlStartup.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSaveTime
            // 
            btnSaveTime.Depth = 0;
            btnSaveTime.Location = new System.Drawing.Point(174, 289);
            btnSaveTime.MouseState = MaterialSkin.MouseState.HOVER;
            btnSaveTime.Name = "btnSaveTime";
            btnSaveTime.Primary = true;
            btnSaveTime.Size = new System.Drawing.Size(133, 44);
            btnSaveTime.TabIndex = 17;
            btnSaveTime.Text = "Opslaan";
            btnSaveTime.UseVisualStyleBackColor = true;
            btnSaveTime.Click += new System.EventHandler(this.btnSaveTime_Click);
            // 
            // btnCancelTime
            // 
            btnCancelTime.Depth = 0;
            btnCancelTime.Location = new System.Drawing.Point(313, 289);
            btnCancelTime.MouseState = MaterialSkin.MouseState.HOVER;
            btnCancelTime.Name = "btnCancelTime";
            btnCancelTime.Primary = true;
            btnCancelTime.Size = new System.Drawing.Size(133, 44);
            btnCancelTime.TabIndex = 18;
            btnCancelTime.Text = "Annuleren";
            btnCancelTime.UseVisualStyleBackColor = true;
            btnCancelTime.Click += new System.EventHandler(this.btnCancelTime_Click);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialTabSelector1.BaseTabControl = this.tabs;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(-1, 64);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(847, 23);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "tabs";
            // 
            // tabs
            // 
            this.tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabs.Controls.Add(this.tabPage2);
            this.tabs.Controls.Add(this.tabPage1);
            this.tabs.Controls.Add(this.tabPage3);
            this.tabs.Depth = 0;
            this.tabs.Location = new System.Drawing.Point(-1, 93);
            this.tabs.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(847, 444);
            this.tabs.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.pbDelUser);
            this.tabPage2.Controls.Add(this.pnlUInfo);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.ddUsers2);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.pbAdd);
            this.tabPage2.Controls.Add(this.pnlAdd);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(839, 418);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Schermtijd";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(707, 204);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(121, 30);
            this.label19.TabIndex = 10;
            this.label19.Text = "Verwijderen";
            // 
            // pbDelUser
            // 
            this.pbDelUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbDelUser.BackgroundImage")));
            this.pbDelUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbDelUser.Location = new System.Drawing.Point(725, 126);
            this.pbDelUser.Name = "pbDelUser";
            this.pbDelUser.Size = new System.Drawing.Size(75, 75);
            this.pbDelUser.TabIndex = 9;
            this.pbDelUser.TabStop = false;
            this.pbDelUser.Click += new System.EventHandler(this.pbDelUser_Click);
            // 
            // pnlUInfo
            // 
            this.pnlUInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUInfo.Controls.Add(this.btnSaveInfo);
            this.pnlUInfo.Controls.Add(this.btnCancelInfo);
            this.pnlUInfo.Controls.Add(this.label16);
            this.pnlUInfo.Controls.Add(this.tbInfoPass);
            this.pnlUInfo.Controls.Add(this.label15);
            this.pnlUInfo.Controls.Add(this.tbUsernameInfo);
            this.pnlUInfo.Controls.Add(this.label14);
            this.pnlUInfo.Location = new System.Drawing.Point(40, 175);
            this.pnlUInfo.Name = "pnlUInfo";
            this.pnlUInfo.Size = new System.Drawing.Size(324, 307);
            this.pnlUInfo.TabIndex = 8;
            this.pnlUInfo.Visible = false;
            // 
            // btnSaveInfo
            // 
            this.btnSaveInfo.Depth = 0;
            this.btnSaveInfo.Location = new System.Drawing.Point(38, 239);
            this.btnSaveInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveInfo.Name = "btnSaveInfo";
            this.btnSaveInfo.Primary = true;
            this.btnSaveInfo.Size = new System.Drawing.Size(122, 44);
            this.btnSaveInfo.TabIndex = 11;
            this.btnSaveInfo.Text = "Opslaan";
            this.btnSaveInfo.UseVisualStyleBackColor = true;
            this.btnSaveInfo.Click += new System.EventHandler(this.btnSaveInfo_Click);
            // 
            // btnCancelInfo
            // 
            this.btnCancelInfo.Depth = 0;
            this.btnCancelInfo.Location = new System.Drawing.Point(166, 239);
            this.btnCancelInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelInfo.Name = "btnCancelInfo";
            this.btnCancelInfo.Primary = true;
            this.btnCancelInfo.Size = new System.Drawing.Size(122, 44);
            this.btnCancelInfo.TabIndex = 10;
            this.btnCancelInfo.Text = "Annuleren";
            this.btnCancelInfo.UseVisualStyleBackColor = true;
            this.btnCancelInfo.Click += new System.EventHandler(this.btnCancelInfo_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(93, 129);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(130, 30);
            this.label16.TabIndex = 9;
            this.label16.Text = "Wachtwoord";
            // 
            // tbInfoPass
            // 
            this.tbInfoPass.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInfoPass.Location = new System.Drawing.Point(39, 162);
            this.tbInfoPass.Name = "tbInfoPass";
            this.tbInfoPass.Size = new System.Drawing.Size(232, 33);
            this.tbInfoPass.TabIndex = 8;
            this.tbInfoPass.UseSystemPasswordChar = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(75, 54);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(163, 30);
            this.label15.TabIndex = 7;
            this.label15.Text = "Gebruikersnaam";
            // 
            // tbUsernameInfo
            // 
            this.tbUsernameInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsernameInfo.Location = new System.Drawing.Point(39, 87);
            this.tbUsernameInfo.Name = "tbUsernameInfo";
            this.tbUsernameInfo.Size = new System.Drawing.Size(232, 33);
            this.tbUsernameInfo.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label14.Location = new System.Drawing.Point(119, 5);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 43);
            this.label14.TabIndex = 5;
            this.label14.Text = "Info";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label13.Location = new System.Drawing.Point(17, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(178, 20);
            this.label13.TabIndex = 7;
            this.label13.Text = "Selecteer een gebruiker";
            // 
            // ddUsers2
            // 
            this.ddUsers2.BackColor = System.Drawing.Color.Transparent;
            this.ddUsers2.BorderRadius = 3;
            this.ddUsers2.DisabledColor = System.Drawing.Color.Gray;
            this.ddUsers2.ForeColor = System.Drawing.Color.White;
            this.ddUsers2.Items = new string[0];
            this.ddUsers2.Location = new System.Drawing.Point(21, 86);
            this.ddUsers2.Name = "ddUsers2";
            this.ddUsers2.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ddUsers2.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ddUsers2.selectedIndex = -1;
            this.ddUsers2.Size = new System.Drawing.Size(195, 37);
            this.ddUsers2.TabIndex = 6;
            this.ddUsers2.onItemSelected += new System.EventHandler(this.ddUsers2_onItemSelected);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(707, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 30);
            this.label12.TabIndex = 5;
            this.label12.Text = "Toevoegen";
            // 
            // pbAdd
            // 
            this.pbAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbAdd.BackgroundImage")));
            this.pbAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAdd.Location = new System.Drawing.Point(725, 15);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(75, 75);
            this.pbAdd.TabIndex = 4;
            this.pbAdd.TabStop = false;
            this.pbAdd.Click += new System.EventHandler(this.pbAdd_Click);
            // 
            // pnlAdd
            // 
            this.pnlAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAdd.Controls.Add(this.btnAddCancel);
            this.pnlAdd.Controls.Add(this.btnAdd);
            this.pnlAdd.Controls.Add(this.label4);
            this.pnlAdd.Controls.Add(this.pictureBox1);
            this.pnlAdd.Controls.Add(this.tbPass2);
            this.pnlAdd.Controls.Add(this.tbPass1);
            this.pnlAdd.Controls.Add(this.tbUsername);
            this.pnlAdd.Location = new System.Drawing.Point(393, 272);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(268, 270);
            this.pnlAdd.TabIndex = 2;
            this.pnlAdd.Visible = false;
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.Depth = 0;
            this.btnAddCancel.Location = new System.Drawing.Point(4, 205);
            this.btnAddCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Primary = true;
            this.btnAddCancel.Size = new System.Drawing.Size(122, 44);
            this.btnAddCancel.TabIndex = 6;
            this.btnAddCancel.Text = "Annuleren";
            this.btnAddCancel.UseVisualStyleBackColor = true;
            this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Depth = 0;
            this.btnAdd.Location = new System.Drawing.Point(132, 205);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Primary = true;
            this.btnAdd.Size = new System.Drawing.Size(122, 44);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Toevoegen";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(73, -1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 43);
            this.label4.TabIndex = 4;
            this.label4.Text = "Toevoegen";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 42);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // tbPass2
            // 
            this.tbPass2.Depth = 0;
            this.tbPass2.Hint = "Wachtwoord bevestigen";
            this.tbPass2.Location = new System.Drawing.Point(19, 133);
            this.tbPass2.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbPass2.Name = "tbPass2";
            this.tbPass2.PasswordChar = '\0';
            this.tbPass2.SelectedText = "";
            this.tbPass2.SelectionLength = 0;
            this.tbPass2.SelectionStart = 0;
            this.tbPass2.Size = new System.Drawing.Size(235, 23);
            this.tbPass2.TabIndex = 2;
            this.tbPass2.UseSystemPasswordChar = true;
            // 
            // tbPass1
            // 
            this.tbPass1.Depth = 0;
            this.tbPass1.Hint = "Wachtwoord";
            this.tbPass1.Location = new System.Drawing.Point(19, 104);
            this.tbPass1.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbPass1.Name = "tbPass1";
            this.tbPass1.PasswordChar = '\0';
            this.tbPass1.SelectedText = "";
            this.tbPass1.SelectionLength = 0;
            this.tbPass1.SelectionStart = 0;
            this.tbPass1.Size = new System.Drawing.Size(235, 23);
            this.tbPass1.TabIndex = 1;
            this.tbPass1.UseSystemPasswordChar = true;
            // 
            // tbUsername
            // 
            this.tbUsername.Depth = 0;
            this.tbUsername.Hint = "Gebruikersnaam";
            this.tbUsername.Location = new System.Drawing.Point(19, 66);
            this.tbUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.PasswordChar = '\0';
            this.tbUsername.SelectedText = "";
            this.tbUsername.SelectionLength = 0;
            this.tbUsername.SelectionStart = 0;
            this.tbUsername.Size = new System.Drawing.Size(235, 23);
            this.tbUsername.TabIndex = 0;
            this.tbUsername.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(198, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(427, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gebruikers toevoegen/verwijderen";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.pnlInfo);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.ddUsername);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(839, 418);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Gebruikers";
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.White;
            this.pnlInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInfo.Controls.Add(this.btnAScheme);
            this.pnlInfo.Controls.Add(btnCancelTime);
            this.pnlInfo.Controls.Add(btnSaveTime);
            this.pnlInfo.Controls.Add(this.label11);
            this.pnlInfo.Controls.Add(this.label10);
            this.pnlInfo.Controls.Add(this.label9);
            this.pnlInfo.Controls.Add(this.lbDay);
            this.pnlInfo.Controls.Add(this.label8);
            this.pnlInfo.Controls.Add(this.dpTo);
            this.pnlInfo.Controls.Add(this.dpFrom);
            this.pnlInfo.Controls.Add(this.label7);
            this.pnlInfo.Controls.Add(this.label6);
            this.pnlInfo.Controls.Add(this.label5);
            this.pnlInfo.Controls.Add(this.lblDag);
            this.pnlInfo.Controls.Add(this.lblTime);
            this.pnlInfo.Controls.Add(this.tbBar);
            this.pnlInfo.Location = new System.Drawing.Point(237, 43);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(522, 344);
            this.pnlInfo.TabIndex = 8;
            this.pnlInfo.Visible = false;
            // 
            // btnAScheme
            // 
            this.btnAScheme.Depth = 0;
            this.btnAScheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAScheme.Location = new System.Drawing.Point(404, 185);
            this.btnAScheme.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAScheme.Name = "btnAScheme";
            this.btnAScheme.Primary = true;
            this.btnAScheme.Size = new System.Drawing.Size(103, 37);
            this.btnAScheme.TabIndex = 19;
            this.btnAScheme.Text = "Overal toepassen";
            this.btnAScheme.UseVisualStyleBackColor = true;
            this.btnAScheme.Click += new System.EventHandler(this.btnAScheme_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(181, 234);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(220, 26);
            this.label11.TabIndex = 16;
            this.label11.Text = "Tip: Geen tijd op een dag? \r\nSelecteer op bijde boxen van 00:00 tot 00:00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(111, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(243, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Tip: selecteer de balk en gebruik de pijltjestoetsen";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label9.Location = new System.Drawing.Point(46, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 18);
            this.label9.TabIndex = 14;
            this.label9.Text = "Dag";
            // 
            // lbDay
            // 
            this.lbDay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDay.FormattingEnabled = true;
            this.lbDay.ItemHeight = 21;
            this.lbDay.Items.AddRange(new object[] {
            "Maandag",
            "Dinsdag",
            "Woensdag",
            "Donderdag",
            "Vrijdag",
            "Zaterdag",
            "Zondag"});
            this.lbDay.Location = new System.Drawing.Point(12, 152);
            this.lbDay.Name = "lbDay";
            this.lbDay.Size = new System.Drawing.Size(109, 151);
            this.lbDay.TabIndex = 13;
            this.lbDay.SelectedIndexChanged += new System.EventHandler(this.lbDay_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label8.Location = new System.Drawing.Point(210, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Ingestelde periode";
            // 
            // dpTo
            // 
            this.dpTo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpTo.Location = new System.Drawing.Point(280, 193);
            this.dpTo.Name = "dpTo";
            this.dpTo.Size = new System.Drawing.Size(102, 29);
            this.dpTo.TabIndex = 11;
            this.dpTo.ValueChanged += new System.EventHandler(this.dpTo_ValueChanged);
            // 
            // dpFrom
            // 
            this.dpFrom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpFrom.Location = new System.Drawing.Point(149, 193);
            this.dpFrom.Name = "dpFrom";
            this.dpFrom.Size = new System.Drawing.Size(99, 29);
            this.dpFrom.TabIndex = 10;
            this.dpFrom.ValueChanged += new System.EventHandler(this.dpFrom_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label7.Location = new System.Drawing.Point(294, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "Tot";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label6.Location = new System.Drawing.Point(162, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Van";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label5.Location = new System.Drawing.Point(164, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ingestelde tijd (per dag)";
            // 
            // lblDag
            // 
            this.lblDag.AutoSize = true;
            this.lblDag.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblDag.Location = new System.Drawing.Point(170, 15);
            this.lblDag.Name = "lblDag";
            this.lblDag.Size = new System.Drawing.Size(182, 24);
            this.lblDag.TabIndex = 6;
            this.lblDag.Text = "Selecteer een dag";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Gray;
            this.lblTime.Location = new System.Drawing.Point(409, 73);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(25, 30);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "0";
            // 
            // tbBar
            // 
            this.tbBar.LargeChange = 10;
            this.tbBar.Location = new System.Drawing.Point(12, 73);
            this.tbBar.Maximum = 300;
            this.tbBar.Name = "tbBar";
            this.tbBar.Size = new System.Drawing.Size(391, 45);
            this.tbBar.SmallChange = 5;
            this.tbBar.TabIndex = 0;
            this.tbBar.Scroll += new System.EventHandler(this.tbBar_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label3.Location = new System.Drawing.Point(18, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Selecteer een gebruiker";
            // 
            // ddUsername
            // 
            this.ddUsername.BackColor = System.Drawing.Color.Transparent;
            this.ddUsername.BorderRadius = 3;
            this.ddUsername.DisabledColor = System.Drawing.Color.Gray;
            this.ddUsername.ForeColor = System.Drawing.Color.White;
            this.ddUsername.Items = new string[0];
            this.ddUsername.Location = new System.Drawing.Point(22, 86);
            this.ddUsername.Name = "ddUsername";
            this.ddUsername.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ddUsername.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ddUsername.selectedIndex = -1;
            this.ddUsername.Size = new System.Drawing.Size(195, 37);
            this.ddUsername.TabIndex = 4;
            this.ddUsername.onItemSelected += new System.EventHandler(this.ddUsername_onItemSelected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(333, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tijd instellen";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Controls.Add(this.btnUserSettings);
            this.tabPage3.Controls.Add(this.btnExit);
            this.tabPage3.Controls.Add(this.btnRestart);
            this.tabPage3.Controls.Add(this.pnlStartup);
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(839, 418);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Instellingen";
            // 
            // btnUserSettings
            // 
            this.btnUserSettings.Depth = 0;
            this.btnUserSettings.Location = new System.Drawing.Point(513, 359);
            this.btnUserSettings.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUserSettings.Name = "btnUserSettings";
            this.btnUserSettings.Primary = true;
            this.btnUserSettings.Size = new System.Drawing.Size(180, 37);
            this.btnUserSettings.TabIndex = 17;
            this.btnUserSettings.Text = "Gebruikersinstellingen";
            this.btnUserSettings.UseVisualStyleBackColor = true;
            this.btnUserSettings.Click += new System.EventHandler(this.btnUserSettings_Click);
            // 
            // btnExit
            // 
            this.btnExit.Depth = 0;
            this.btnExit.Location = new System.Drawing.Point(327, 359);
            this.btnExit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExit.Name = "btnExit";
            this.btnExit.Primary = true;
            this.btnExit.Size = new System.Drawing.Size(180, 37);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "ScreenTime afsluiten";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Depth = 0;
            this.btnRestart.Location = new System.Drawing.Point(141, 359);
            this.btnRestart.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Primary = true;
            this.btnRestart.Size = new System.Drawing.Size(180, 37);
            this.btnRestart.TabIndex = 15;
            this.btnRestart.Text = "Opnieuw starten";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // pnlStartup
            // 
            this.pnlStartup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStartup.Controls.Add(this.label22);
            this.pnlStartup.Controls.Add(this.btnInteg);
            this.pnlStartup.Controls.Add(this.label21);
            this.pnlStartup.Controls.Add(this.label20);
            this.pnlStartup.Location = new System.Drawing.Point(521, 6);
            this.pnlStartup.Name = "pnlStartup";
            this.pnlStartup.Size = new System.Drawing.Size(309, 163);
            this.pnlStartup.TabIndex = 13;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(65, 71);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(181, 26);
            this.label22.TabIndex = 15;
            this.label22.Text = "Klik op de onderstaande knop \r\nom ScreenTime te integreren\r\n";
            // 
            // btnInteg
            // 
            this.btnInteg.Depth = 0;
            this.btnInteg.Location = new System.Drawing.Point(68, 111);
            this.btnInteg.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInteg.Name = "btnInteg";
            this.btnInteg.Primary = true;
            this.btnInteg.Size = new System.Drawing.Size(180, 37);
            this.btnInteg.TabIndex = 14;
            this.btnInteg.Text = "ScreenTime Integreren";
            this.btnInteg.UseVisualStyleBackColor = true;
            this.btnInteg.Click += new System.EventHandler(this.btnInteg_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(17, 32);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(287, 26);
            this.label21.TabIndex = 13;
            this.label21.Text = "Voor een correcte werking van ScreenTime \r\nmoet u instellen dat ScreenTime gelijk" +
    " opstart met Windows";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label20.Location = new System.Drawing.Point(102, 4);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(84, 24);
            this.label20.TabIndex = 12;
            this.label20.Text = "Start-Up";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tbAnpw);
            this.panel2.Controls.Add(this.btnSaveAPW);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.tbApass);
            this.panel2.Location = new System.Drawing.Point(9, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 195);
            this.panel2.TabIndex = 11;
            // 
            // tbAnpw
            // 
            this.tbAnpw.Depth = 0;
            this.tbAnpw.Hint = "Nieuw wachtwoord";
            this.tbAnpw.Location = new System.Drawing.Point(22, 93);
            this.tbAnpw.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbAnpw.Name = "tbAnpw";
            this.tbAnpw.PasswordChar = '\0';
            this.tbAnpw.SelectedText = "";
            this.tbAnpw.SelectionLength = 0;
            this.tbAnpw.SelectionStart = 0;
            this.tbAnpw.Size = new System.Drawing.Size(240, 23);
            this.tbAnpw.TabIndex = 9;
            this.tbAnpw.UseSystemPasswordChar = true;
            // 
            // btnSaveAPW
            // 
            this.btnSaveAPW.Depth = 0;
            this.btnSaveAPW.Location = new System.Drawing.Point(89, 132);
            this.btnSaveAPW.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveAPW.Name = "btnSaveAPW";
            this.btnSaveAPW.Primary = true;
            this.btnSaveAPW.Size = new System.Drawing.Size(110, 37);
            this.btnSaveAPW.TabIndex = 10;
            this.btnSaveAPW.Text = "Opslaan";
            this.btnSaveAPW.UseVisualStyleBackColor = true;
            this.btnSaveAPW.Click += new System.EventHandler(this.btnSaveAPW_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label18.Location = new System.Drawing.Point(18, 20);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(244, 24);
            this.label18.TabIndex = 7;
            this.label18.Text = "Administratorwachtwoord\r\n";
            // 
            // tbApass
            // 
            this.tbApass.Depth = 0;
            this.tbApass.Hint = "Huidig wachtwoord";
            this.tbApass.Location = new System.Drawing.Point(22, 64);
            this.tbApass.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbApass.Name = "tbApass";
            this.tbApass.PasswordChar = '\0';
            this.tbApass.SelectedText = "";
            this.tbApass.SelectionLength = 0;
            this.tbApass.SelectionStart = 0;
            this.tbApass.Size = new System.Drawing.Size(240, 23);
            this.tbApass.TabIndex = 8;
            this.tbApass.UseSystemPasswordChar = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(334, 14);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(154, 37);
            this.label17.TabIndex = 1;
            this.label17.Text = "Instellingen";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(4, 34);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(238, 13);
            this.label23.TabIndex = 18;
            this.label23.Text = "Portforward uw router op de volgende gegevens:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label24.Location = new System.Drawing.Point(3, 10);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(275, 24);
            this.label24.TabIndex = 19;
            this.label24.Text = "Remote toegang met de app";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label29);
            this.panel1.Controls.Add(this.label28);
            this.panel1.Controls.Add(this.lblIP);
            this.panel1.Controls.Add(this.label27);
            this.panel1.Controls.Add(this.label26);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Location = new System.Drawing.Point(9, 215);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 138);
            this.panel1.TabIndex = 20;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(4, 57);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(20, 13);
            this.label25.TabIndex = 20;
            this.label25.Text = "IP:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(4, 81);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(35, 13);
            this.label26.TabIndex = 21;
            this.label26.Text = "Poort:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(5, 107);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(34, 13);
            this.label27.TabIndex = 22;
            this.label27.Text = "Type:";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIP.Location = new System.Drawing.Point(30, 51);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(70, 21);
            this.lblIP.TabIndex = 23;
            this.lblIP.Text = "127.0.0.1";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(45, 75);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(49, 21);
            this.label28.TabIndex = 24;
            this.label28.Text = "10901";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(45, 101);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(58, 21);
            this.label29.TabIndex = 25;
            this.label29.Text = "TCP/IP";
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 535);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.materialTabSelector1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdmin";
            this.Text = "ScreenTime Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAdmin_FormClosed);
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.tabs.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelUser)).EndInit();
            this.pnlUInfo.ResumeLayout(false);
            this.pnlUInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            this.pnlAdd.ResumeLayout(false);
            this.pnlAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbBar)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.pnlStartup.ResumeLayout(false);
            this.pnlStartup.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl tabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuDropdown ddUsername;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.TrackBar tbBar;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.DateTimePicker dpFrom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDag;
        private System.Windows.Forms.DateTimePicker dpTo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lbDay;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pnlAdd;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbPass2;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbPass1;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialRaisedButton btnAddCancel;
        private MaterialSkin.Controls.MaterialRaisedButton btnAdd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pbAdd;
        private System.Windows.Forms.Label label13;
        private Bunifu.Framework.UI.BunifuDropdown ddUsers2;
        private System.Windows.Forms.Panel pnlUInfo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbInfoPass;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbUsernameInfo;
        private System.Windows.Forms.Label label14;
        private MaterialSkin.Controls.MaterialRaisedButton btnSaveInfo;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancelInfo;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbAnpw;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbApass;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialRaisedButton btnSaveAPW;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.PictureBox pbDelUser;
        private System.Windows.Forms.Panel pnlStartup;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private MaterialSkin.Controls.MaterialRaisedButton btnInteg;
        private System.Windows.Forms.Label label22;
        private MaterialSkin.Controls.MaterialRaisedButton btnUserSettings;
        private MaterialSkin.Controls.MaterialRaisedButton btnExit;
        private MaterialSkin.Controls.MaterialRaisedButton btnRestart;
        private MaterialSkin.Controls.MaterialRaisedButton btnAScheme;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
    }
}