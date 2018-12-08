namespace ScreenTime
{
    partial class frmTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTime));
            this.pnlMessage = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.pnlTime = new System.Windows.Forms.Panel();
            this.btnShutdown = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnLogout = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnMore = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.Stay = new System.Windows.Forms.Timer(this.components);
            this.Tijd = new System.Windows.Forms.Timer(this.components);
            this.Delay = new System.Windows.Forms.Timer(this.components);
            this.NoTaskmgr = new System.Windows.Forms.Timer(this.components);
            this.AutoSave = new System.Windows.Forms.Timer(this.components);
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogin = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tbPass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbUsername = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlMore = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.tbElse = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.rbelse = new MaterialSkin.Controls.MaterialRadioButton();
            this.rb2 = new MaterialSkin.Controls.MaterialRadioButton();
            this.rb1 = new MaterialSkin.Controls.MaterialRadioButton();
            this.rb45 = new MaterialSkin.Controls.MaterialRadioButton();
            this.rb30 = new MaterialSkin.Controls.MaterialRadioButton();
            this.rb15 = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnMCancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnGive = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblMeerSTNaam = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlShutdown = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnScancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSshutdown = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSlogout = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Period = new System.Windows.Forms.Timer(this.components);
            this.Stopper = new System.Windows.Forms.Timer(this.components);
            this.pnlMessage.SuspendLayout();
            this.pnlTime.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlMore.SuspendLayout();
            this.pnlShutdown.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMessage
            // 
            this.pnlMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pnlMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMessage.Controls.Add(this.label3);
            this.pnlMessage.Controls.Add(this.label2);
            this.pnlMessage.Controls.Add(this.lblMessage);
            this.pnlMessage.Location = new System.Drawing.Point(226, 12);
            this.pnlMessage.Name = "pnlMessage";
            this.pnlMessage.Size = new System.Drawing.Size(502, 124);
            this.pnlMessage.TabIndex = 0;
            this.pnlMessage.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(211, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "ScreenTime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(157, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "-Sluit automatisch-";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblMessage.Location = new System.Drawing.Point(22, 22);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(445, 65);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "Nog 00 minuten over!";
            // 
            // pnlTime
            // 
            this.pnlTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pnlTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTime.Controls.Add(this.btnShutdown);
            this.pnlTime.Controls.Add(this.btnLogout);
            this.pnlTime.Controls.Add(this.btnMore);
            this.pnlTime.Controls.Add(this.label1);
            this.pnlTime.Controls.Add(this.lblTime);
            this.pnlTime.Location = new System.Drawing.Point(47, 142);
            this.pnlTime.Name = "pnlTime";
            this.pnlTime.Size = new System.Drawing.Size(524, 152);
            this.pnlTime.TabIndex = 1;
            this.pnlTime.Visible = false;
            // 
            // btnShutdown
            // 
            this.btnShutdown.ActiveBorderThickness = 1;
            this.btnShutdown.ActiveCornerRadius = 20;
            this.btnShutdown.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnShutdown.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnShutdown.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnShutdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnShutdown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShutdown.BackgroundImage")));
            this.btnShutdown.ButtonText = "Afmelden";
            this.btnShutdown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShutdown.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShutdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnShutdown.IdleBorderThickness = 1;
            this.btnShutdown.IdleCornerRadius = 20;
            this.btnShutdown.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnShutdown.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnShutdown.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnShutdown.Location = new System.Drawing.Point(354, 91);
            this.btnShutdown.Margin = new System.Windows.Forms.Padding(5);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Size = new System.Drawing.Size(140, 52);
            this.btnShutdown.TabIndex = 8;
            this.btnShutdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnShutdown.Click += new System.EventHandler(this.btnShutdown_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.ActiveBorderThickness = 1;
            this.btnLogout.ActiveCornerRadius = 20;
            this.btnLogout.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLogout.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnLogout.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.BackgroundImage")));
            this.btnLogout.ButtonText = "Uitloggen";
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLogout.IdleBorderThickness = 1;
            this.btnLogout.IdleCornerRadius = 20;
            this.btnLogout.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnLogout.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLogout.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLogout.Location = new System.Drawing.Point(204, 91);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(140, 52);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnMore
            // 
            this.btnMore.ActiveBorderThickness = 1;
            this.btnMore.ActiveCornerRadius = 20;
            this.btnMore.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMore.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnMore.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnMore.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMore.BackgroundImage")));
            this.btnMore.ButtonText = "Meer tijd";
            this.btnMore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMore.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMore.IdleBorderThickness = 1;
            this.btnMore.IdleCornerRadius = 20;
            this.btnMore.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnMore.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMore.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMore.Location = new System.Drawing.Point(54, 91);
            this.btnMore.Margin = new System.Windows.Forms.Padding(5);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(140, 52);
            this.btnMore.TabIndex = 6;
            this.btnMore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMore.Click += new System.EventHandler(this.btnMore_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(226, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ScreenTime";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblTime.Location = new System.Drawing.Point(86, 21);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(360, 65);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "Schermtijd is om!";
            // 
            // Stay
            // 
            this.Stay.Interval = 500;
            this.Stay.Tick += new System.EventHandler(this.Stay_Tick);
            // 
            // Tijd
            // 
            this.Tijd.Interval = 1000;
            this.Tijd.Tick += new System.EventHandler(this.Tijd_Tick);
            // 
            // Delay
            // 
            this.Delay.Interval = 2500;
            this.Delay.Tick += new System.EventHandler(this.Delay_Tick);
            // 
            // NoTaskmgr
            // 
            this.NoTaskmgr.Interval = 500;
            this.NoTaskmgr.Tick += new System.EventHandler(this.NoTaskmgr_Tick);
            // 
            // AutoSave
            // 
            this.AutoSave.Interval = 10000;
            this.AutoSave.Tick += new System.EventHandler(this.AutoSave_Tick);
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.White;
            this.pnlLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLogin.Controls.Add(this.lblStatus);
            this.pnlLogin.Controls.Add(this.pictureBox2);
            this.pnlLogin.Controls.Add(this.pictureBox1);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.btnCancel);
            this.pnlLogin.Controls.Add(this.tbPass);
            this.pnlLogin.Controls.Add(this.tbUsername);
            this.pnlLogin.Controls.Add(this.label6);
            this.pnlLogin.Controls.Add(this.label5);
            this.pnlLogin.Location = new System.Drawing.Point(618, 163);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(296, 293);
            this.pnlLogin.TabIndex = 2;
            this.pnlLogin.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(28, 188);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(224, 16);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Gebruikersnaam/wachtwoord onjuist";
            this.lblStatus.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(13, 150);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(13, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Depth = 0;
            this.btnLogin.Location = new System.Drawing.Point(154, 229);
            this.btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Primary = true;
            this.btnLogin.Size = new System.Drawing.Size(117, 40);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "inloggen";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Depth = 0;
            this.btnCancel.Location = new System.Drawing.Point(31, 229);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Primary = true;
            this.btnCancel.Size = new System.Drawing.Size(117, 40);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "annuleren";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbPass
            // 
            this.tbPass.Depth = 0;
            this.tbPass.Hint = "Wachtwoord";
            this.tbPass.Location = new System.Drawing.Point(44, 152);
            this.tbPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '\0';
            this.tbPass.SelectedText = "";
            this.tbPass.SelectionLength = 0;
            this.tbPass.SelectionStart = 0;
            this.tbPass.Size = new System.Drawing.Size(227, 23);
            this.tbPass.TabIndex = 5;
            this.tbPass.UseSystemPasswordChar = true;
            this.tbPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPass_KeyDown);
            // 
            // tbUsername
            // 
            this.tbUsername.Depth = 0;
            this.tbUsername.Hint = "Gebruikersnaam";
            this.tbUsername.Location = new System.Drawing.Point(44, 112);
            this.tbUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.PasswordChar = '\0';
            this.tbUsername.SelectedText = "";
            this.tbUsername.SelectionLength = 0;
            this.tbUsername.SelectionStart = 0;
            this.tbUsername.Size = new System.Drawing.Size(227, 23);
            this.tbUsername.TabIndex = 4;
            this.tbUsername.Text = "Admin";
            this.tbUsername.UseSystemPasswordChar = false;
            this.tbUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbUsername_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGray;
            this.label6.Location = new System.Drawing.Point(55, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "-Als Administrator-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(61, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 50);
            this.label5.TabIndex = 2;
            this.label5.Text = "Inloggen";
            // 
            // pnlMore
            // 
            this.pnlMore.BackColor = System.Drawing.Color.White;
            this.pnlMore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMore.Controls.Add(this.label8);
            this.pnlMore.Controls.Add(this.tbElse);
            this.pnlMore.Controls.Add(this.rbelse);
            this.pnlMore.Controls.Add(this.rb2);
            this.pnlMore.Controls.Add(this.rb1);
            this.pnlMore.Controls.Add(this.rb45);
            this.pnlMore.Controls.Add(this.rb30);
            this.pnlMore.Controls.Add(this.rb15);
            this.pnlMore.Controls.Add(this.btnMCancel);
            this.pnlMore.Controls.Add(this.btnGive);
            this.pnlMore.Controls.Add(this.lblMeerSTNaam);
            this.pnlMore.Controls.Add(this.label7);
            this.pnlMore.Location = new System.Drawing.Point(229, 314);
            this.pnlMore.Name = "pnlMore";
            this.pnlMore.Size = new System.Drawing.Size(342, 367);
            this.pnlMore.TabIndex = 3;
            this.pnlMore.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(196, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "minuten";
            // 
            // tbElse
            // 
            this.tbElse.Depth = 0;
            this.tbElse.Hint = "10";
            this.tbElse.Location = new System.Drawing.Point(159, 256);
            this.tbElse.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbElse.Name = "tbElse";
            this.tbElse.PasswordChar = '\0';
            this.tbElse.SelectedText = "";
            this.tbElse.SelectionLength = 0;
            this.tbElse.SelectionStart = 0;
            this.tbElse.Size = new System.Drawing.Size(31, 23);
            this.tbElse.TabIndex = 15;
            this.tbElse.UseSystemPasswordChar = false;
            // 
            // rbelse
            // 
            this.rbelse.AutoSize = true;
            this.rbelse.Depth = 0;
            this.rbelse.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbelse.ForeColor = System.Drawing.Color.White;
            this.rbelse.Location = new System.Drawing.Point(45, 249);
            this.rbelse.Margin = new System.Windows.Forms.Padding(0);
            this.rbelse.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbelse.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbelse.Name = "rbelse";
            this.rbelse.Ripple = true;
            this.rbelse.Size = new System.Drawing.Size(99, 30);
            this.rbelse.TabIndex = 14;
            this.rbelse.Text = "Aangepast:";
            this.rbelse.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Depth = 0;
            this.rb2.Font = new System.Drawing.Font("Roboto", 10F);
            this.rb2.ForeColor = System.Drawing.Color.White;
            this.rb2.Location = new System.Drawing.Point(45, 219);
            this.rb2.Margin = new System.Windows.Forms.Padding(0);
            this.rb2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rb2.MouseState = MaterialSkin.MouseState.HOVER;
            this.rb2.Name = "rb2";
            this.rb2.Ripple = true;
            this.rb2.Size = new System.Drawing.Size(60, 30);
            this.rb2.TabIndex = 13;
            this.rb2.Text = "2 uur";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Depth = 0;
            this.rb1.Font = new System.Drawing.Font("Roboto", 10F);
            this.rb1.ForeColor = System.Drawing.Color.White;
            this.rb1.Location = new System.Drawing.Point(45, 189);
            this.rb1.Margin = new System.Windows.Forms.Padding(0);
            this.rb1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rb1.MouseState = MaterialSkin.MouseState.HOVER;
            this.rb1.Name = "rb1";
            this.rb1.Ripple = true;
            this.rb1.Size = new System.Drawing.Size(60, 30);
            this.rb1.TabIndex = 12;
            this.rb1.Text = "1 uur";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // rb45
            // 
            this.rb45.AutoSize = true;
            this.rb45.Depth = 0;
            this.rb45.Font = new System.Drawing.Font("Roboto", 10F);
            this.rb45.ForeColor = System.Drawing.Color.White;
            this.rb45.Location = new System.Drawing.Point(45, 159);
            this.rb45.Margin = new System.Windows.Forms.Padding(0);
            this.rb45.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rb45.MouseState = MaterialSkin.MouseState.HOVER;
            this.rb45.Name = "rb45";
            this.rb45.Ripple = true;
            this.rb45.Size = new System.Drawing.Size(98, 30);
            this.rb45.TabIndex = 11;
            this.rb45.Text = "45 minuten";
            this.rb45.UseVisualStyleBackColor = true;
            // 
            // rb30
            // 
            this.rb30.AutoSize = true;
            this.rb30.Depth = 0;
            this.rb30.Font = new System.Drawing.Font("Roboto", 10F);
            this.rb30.ForeColor = System.Drawing.Color.White;
            this.rb30.Location = new System.Drawing.Point(45, 129);
            this.rb30.Margin = new System.Windows.Forms.Padding(0);
            this.rb30.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rb30.MouseState = MaterialSkin.MouseState.HOVER;
            this.rb30.Name = "rb30";
            this.rb30.Ripple = true;
            this.rb30.Size = new System.Drawing.Size(98, 30);
            this.rb30.TabIndex = 10;
            this.rb30.Text = "30 minuten";
            this.rb30.UseVisualStyleBackColor = true;
            // 
            // rb15
            // 
            this.rb15.AutoSize = true;
            this.rb15.Checked = true;
            this.rb15.Depth = 0;
            this.rb15.Font = new System.Drawing.Font("Roboto", 10F);
            this.rb15.ForeColor = System.Drawing.Color.White;
            this.rb15.Location = new System.Drawing.Point(45, 99);
            this.rb15.Margin = new System.Windows.Forms.Padding(0);
            this.rb15.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rb15.MouseState = MaterialSkin.MouseState.HOVER;
            this.rb15.Name = "rb15";
            this.rb15.Ripple = true;
            this.rb15.Size = new System.Drawing.Size(98, 30);
            this.rb15.TabIndex = 9;
            this.rb15.TabStop = true;
            this.rb15.Text = "15 minuten";
            this.rb15.UseVisualStyleBackColor = true;
            // 
            // btnMCancel
            // 
            this.btnMCancel.ActiveBorderThickness = 1;
            this.btnMCancel.ActiveCornerRadius = 20;
            this.btnMCancel.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMCancel.ActiveForecolor = System.Drawing.Color.White;
            this.btnMCancel.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMCancel.BackColor = System.Drawing.Color.White;
            this.btnMCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMCancel.BackgroundImage")));
            this.btnMCancel.ButtonText = "Annuleren";
            this.btnMCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMCancel.IdleBorderThickness = 1;
            this.btnMCancel.IdleCornerRadius = 20;
            this.btnMCancel.IdleFillColor = System.Drawing.Color.White;
            this.btnMCancel.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMCancel.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMCancel.Location = new System.Drawing.Point(27, 297);
            this.btnMCancel.Margin = new System.Windows.Forms.Padding(5);
            this.btnMCancel.Name = "btnMCancel";
            this.btnMCancel.Size = new System.Drawing.Size(140, 52);
            this.btnMCancel.TabIndex = 8;
            this.btnMCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMCancel.Click += new System.EventHandler(this.btnMCancel_Click);
            // 
            // btnGive
            // 
            this.btnGive.ActiveBorderThickness = 1;
            this.btnGive.ActiveCornerRadius = 20;
            this.btnGive.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGive.ActiveForecolor = System.Drawing.Color.White;
            this.btnGive.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGive.BackColor = System.Drawing.Color.White;
            this.btnGive.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGive.BackgroundImage")));
            this.btnGive.ButtonText = "Toepassen";
            this.btnGive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGive.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGive.IdleBorderThickness = 1;
            this.btnGive.IdleCornerRadius = 20;
            this.btnGive.IdleFillColor = System.Drawing.Color.White;
            this.btnGive.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGive.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGive.Location = new System.Drawing.Point(177, 297);
            this.btnGive.Margin = new System.Windows.Forms.Padding(5);
            this.btnGive.Name = "btnGive";
            this.btnGive.Size = new System.Drawing.Size(140, 52);
            this.btnGive.TabIndex = 7;
            this.btnGive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGive.Click += new System.EventHandler(this.btnGive_Click);
            // 
            // lblMeerSTNaam
            // 
            this.lblMeerSTNaam.AutoSize = true;
            this.lblMeerSTNaam.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeerSTNaam.ForeColor = System.Drawing.Color.DarkGray;
            this.lblMeerSTNaam.Location = new System.Drawing.Point(41, 65);
            this.lblMeerSTNaam.Name = "lblMeerSTNaam";
            this.lblMeerSTNaam.Size = new System.Drawing.Size(262, 21);
            this.lblMeerSTNaam.TabIndex = 6;
            this.lblMeerSTNaam.Text = "Extra schermtijd geven aan NAAM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(23, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(294, 57);
            this.label7.TabIndex = 5;
            this.label7.Text = "Meer Schermtijd";
            // 
            // pnlShutdown
            // 
            this.pnlShutdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pnlShutdown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlShutdown.Controls.Add(this.label9);
            this.pnlShutdown.Controls.Add(this.btnScancel);
            this.pnlShutdown.Controls.Add(this.btnSshutdown);
            this.pnlShutdown.Controls.Add(this.btnSlogout);
            this.pnlShutdown.Location = new System.Drawing.Point(577, 157);
            this.pnlShutdown.Name = "pnlShutdown";
            this.pnlShutdown.Size = new System.Drawing.Size(179, 192);
            this.pnlShutdown.TabIndex = 4;
            this.pnlShutdown.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkGray;
            this.label9.Location = new System.Drawing.Point(43, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 25);
            this.label9.TabIndex = 12;
            this.label9.Text = "Tot ziens!";
            // 
            // btnScancel
            // 
            this.btnScancel.Depth = 0;
            this.btnScancel.Location = new System.Drawing.Point(37, 138);
            this.btnScancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnScancel.Name = "btnScancel";
            this.btnScancel.Primary = true;
            this.btnScancel.Size = new System.Drawing.Size(103, 40);
            this.btnScancel.TabIndex = 11;
            this.btnScancel.Text = "annuleren";
            this.btnScancel.UseVisualStyleBackColor = true;
            this.btnScancel.Click += new System.EventHandler(this.btnScancel_Click);
            // 
            // btnSshutdown
            // 
            this.btnSshutdown.ActiveBorderThickness = 1;
            this.btnSshutdown.ActiveCornerRadius = 20;
            this.btnSshutdown.ActiveFillColor = System.Drawing.Color.Red;
            this.btnSshutdown.ActiveForecolor = System.Drawing.Color.White;
            this.btnSshutdown.ActiveLineColor = System.Drawing.Color.Red;
            this.btnSshutdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnSshutdown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSshutdown.BackgroundImage")));
            this.btnSshutdown.ButtonText = "Afsluiten";
            this.btnSshutdown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSshutdown.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSshutdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSshutdown.IdleBorderThickness = 1;
            this.btnSshutdown.IdleCornerRadius = 20;
            this.btnSshutdown.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnSshutdown.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSshutdown.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSshutdown.Location = new System.Drawing.Point(12, 78);
            this.btnSshutdown.Margin = new System.Windows.Forms.Padding(5);
            this.btnSshutdown.Name = "btnSshutdown";
            this.btnSshutdown.Size = new System.Drawing.Size(149, 52);
            this.btnSshutdown.TabIndex = 10;
            this.btnSshutdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSshutdown.Click += new System.EventHandler(this.btnSshutdown_Click);
            // 
            // btnSlogout
            // 
            this.btnSlogout.ActiveBorderThickness = 1;
            this.btnSlogout.ActiveCornerRadius = 20;
            this.btnSlogout.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSlogout.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnSlogout.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSlogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnSlogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSlogout.BackgroundImage")));
            this.btnSlogout.ButtonText = "Afmelden";
            this.btnSlogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSlogout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSlogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSlogout.IdleBorderThickness = 1;
            this.btnSlogout.IdleCornerRadius = 20;
            this.btnSlogout.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnSlogout.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSlogout.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSlogout.Location = new System.Drawing.Point(12, 31);
            this.btnSlogout.Margin = new System.Windows.Forms.Padding(5);
            this.btnSlogout.Name = "btnSlogout";
            this.btnSlogout.Size = new System.Drawing.Size(149, 52);
            this.btnSlogout.TabIndex = 9;
            this.btnSlogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSlogout.Click += new System.EventHandler(this.btnSlogout_Click);
            // 
            // Period
            // 
            this.Period.Interval = 20000;
            this.Period.Tick += new System.EventHandler(this.Period_Tick);
            // 
            // Stopper
            // 
            this.Stopper.Interval = 1000;
            this.Stopper.Tick += new System.EventHandler(this.Stopper_Tick);
            // 
            // frmTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(808, 532);
            this.ControlBox = false;
            this.Controls.Add(this.pnlShutdown);
            this.Controls.Add(this.pnlMore);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.pnlTime);
            this.Controls.Add(this.pnlMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTime";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTime";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTime_FormClosing);
            this.Load += new System.EventHandler(this.frmTime_Load);
            this.pnlMessage.ResumeLayout(false);
            this.pnlMessage.PerformLayout();
            this.pnlTime.ResumeLayout(false);
            this.pnlTime.PerformLayout();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlMore.ResumeLayout(false);
            this.pnlMore.PerformLayout();
            this.pnlShutdown.ResumeLayout(false);
            this.pnlShutdown.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMessage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Panel pnlTime;
        private Bunifu.Framework.UI.BunifuThinButton2 btnMore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTime;
        private Bunifu.Framework.UI.BunifuThinButton2 btnShutdown;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLogout;
        private System.Windows.Forms.Timer Stay;
        private System.Windows.Forms.Timer Tijd;
        private System.Windows.Forms.Timer Delay;
        private System.Windows.Forms.Timer NoTaskmgr;
        private System.Windows.Forms.Timer AutoSave;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialRaisedButton btnLogin;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancel;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbPass;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbUsername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlMore;
        private MaterialSkin.Controls.MaterialRadioButton rb2;
        private MaterialSkin.Controls.MaterialRadioButton rb1;
        private MaterialSkin.Controls.MaterialRadioButton rb45;
        private MaterialSkin.Controls.MaterialRadioButton rb30;
        private MaterialSkin.Controls.MaterialRadioButton rb15;
        private Bunifu.Framework.UI.BunifuThinButton2 btnMCancel;
        private Bunifu.Framework.UI.BunifuThinButton2 btnGive;
        private System.Windows.Forms.Label lblMeerSTNaam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbElse;
        private MaterialSkin.Controls.MaterialRadioButton rbelse;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel pnlShutdown;
        private MaterialSkin.Controls.MaterialRaisedButton btnScancel;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSshutdown;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSlogout;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer Period;
        private System.Windows.Forms.Timer Stopper;
    }
}