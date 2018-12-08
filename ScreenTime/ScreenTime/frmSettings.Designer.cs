namespace ScreenTime
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.lblName = new System.Windows.Forms.Label();
            this.pbTijdOver = new Bunifu.Framework.UI.BunifuProgressBar();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.btnWallpaper = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnCPW = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTot = new System.Windows.Forms.Label();
            this.lblVan = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTijdOver = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlCPW = new System.Windows.Forms.Panel();
            this.btnSavePw = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tbNewpw2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbNewpw = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbOldpw = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlWallpaper = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btnWChoose = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pbWallpaper = new System.Windows.Forms.PictureBox();
            this.btnSetW = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnWClose = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label7 = new System.Windows.Forms.Label();
            this.tmrRefresh = new System.Windows.Forms.Timer(this.components);
            this.bunifuCards1.SuspendLayout();
            this.pnlCPW.SuspendLayout();
            this.pnlWallpaper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWallpaper)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.White;
            this.lblName.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblName.Location = new System.Drawing.Point(177, 73);
            this.lblName.Name = "lblName";
            this.lblName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblName.Size = new System.Drawing.Size(242, 51);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Welkom NAAM";
            // 
            // pbTijdOver
            // 
            this.pbTijdOver.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pbTijdOver.BackColor = System.Drawing.Color.Silver;
            this.pbTijdOver.BorderRadius = 5;
            this.pbTijdOver.Location = new System.Drawing.Point(31, 69);
            this.pbTijdOver.MaximumValue = 100;
            this.pbTijdOver.Name = "pbTijdOver";
            this.pbTijdOver.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pbTijdOver.Size = new System.Drawing.Size(298, 21);
            this.pbTijdOver.TabIndex = 1;
            this.pbTijdOver.Value = 0;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuCards1.Controls.Add(this.btnWallpaper);
            this.bunifuCards1.Controls.Add(this.btnCPW);
            this.bunifuCards1.Controls.Add(this.label5);
            this.bunifuCards1.Controls.Add(this.lblTot);
            this.bunifuCards1.Controls.Add(this.lblVan);
            this.bunifuCards1.Controls.Add(this.label4);
            this.bunifuCards1.Controls.Add(this.label3);
            this.bunifuCards1.Controls.Add(this.label2);
            this.bunifuCards1.Controls.Add(this.lblTijdOver);
            this.bunifuCards1.Controls.Add(this.label1);
            this.bunifuCards1.Controls.Add(this.pbTijdOver);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(12, 127);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(576, 321);
            this.bunifuCards1.TabIndex = 2;
            // 
            // btnWallpaper
            // 
            this.btnWallpaper.ActiveBorderThickness = 1;
            this.btnWallpaper.ActiveCornerRadius = 20;
            this.btnWallpaper.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnWallpaper.ActiveForecolor = System.Drawing.Color.White;
            this.btnWallpaper.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnWallpaper.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnWallpaper.BackColor = System.Drawing.Color.White;
            this.btnWallpaper.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWallpaper.BackgroundImage")));
            this.btnWallpaper.ButtonText = "Wallpaper";
            this.btnWallpaper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWallpaper.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWallpaper.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnWallpaper.IdleBorderThickness = 1;
            this.btnWallpaper.IdleCornerRadius = 20;
            this.btnWallpaper.IdleFillColor = System.Drawing.Color.White;
            this.btnWallpaper.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnWallpaper.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnWallpaper.Location = new System.Drawing.Point(364, 126);
            this.btnWallpaper.Margin = new System.Windows.Forms.Padding(5);
            this.btnWallpaper.Name = "btnWallpaper";
            this.btnWallpaper.Size = new System.Drawing.Size(192, 48);
            this.btnWallpaper.TabIndex = 11;
            this.btnWallpaper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnWallpaper.Click += new System.EventHandler(this.btnWallpaper_Click);
            // 
            // btnCPW
            // 
            this.btnCPW.ActiveBorderThickness = 1;
            this.btnCPW.ActiveCornerRadius = 20;
            this.btnCPW.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCPW.ActiveForecolor = System.Drawing.Color.White;
            this.btnCPW.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCPW.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCPW.BackColor = System.Drawing.Color.White;
            this.btnCPW.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCPW.BackgroundImage")));
            this.btnCPW.ButtonText = "Wachtwoord wijzigen";
            this.btnCPW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCPW.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCPW.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCPW.IdleBorderThickness = 1;
            this.btnCPW.IdleCornerRadius = 20;
            this.btnCPW.IdleFillColor = System.Drawing.Color.White;
            this.btnCPW.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCPW.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCPW.Location = new System.Drawing.Point(364, 71);
            this.btnCPW.Margin = new System.Windows.Forms.Padding(5);
            this.btnCPW.Name = "btnCPW";
            this.btnCPW.Size = new System.Drawing.Size(192, 48);
            this.btnCPW.TabIndex = 10;
            this.btnCPW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCPW.Click += new System.EventHandler(this.btnCPW_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(395, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Instellingen";
            // 
            // lblTot
            // 
            this.lblTot.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTot.AutoSize = true;
            this.lblTot.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTot.Location = new System.Drawing.Point(183, 170);
            this.lblTot.Name = "lblTot";
            this.lblTot.Size = new System.Drawing.Size(60, 26);
            this.lblTot.TabIndex = 8;
            this.lblTot.Text = "00:00";
            // 
            // lblVan
            // 
            this.lblVan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblVan.AutoSize = true;
            this.lblVan.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblVan.Location = new System.Drawing.Point(74, 170);
            this.lblVan.Name = "lblVan";
            this.lblVan.Size = new System.Drawing.Size(60, 26);
            this.lblVan.TabIndex = 7;
            this.lblVan.Text = "00:00";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(140, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tot";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(26, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Van";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(26, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Computerperiode:";
            // 
            // lblTijdOver
            // 
            this.lblTijdOver.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTijdOver.AutoSize = true;
            this.lblTijdOver.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTijdOver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblTijdOver.Location = new System.Drawing.Point(26, 93);
            this.lblTijdOver.Name = "lblTijdOver";
            this.lblTijdOver.Size = new System.Drawing.Size(92, 26);
            this.lblTijdOver.TabIndex = 3;
            this.lblTijdOver.Text = "0 minuten";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(26, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tijd over vandaag:";
            // 
            // pnlCPW
            // 
            this.pnlCPW.BackColor = System.Drawing.Color.White;
            this.pnlCPW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCPW.Controls.Add(this.btnSavePw);
            this.pnlCPW.Controls.Add(this.btnCancel);
            this.pnlCPW.Controls.Add(this.tbNewpw2);
            this.pnlCPW.Controls.Add(this.tbNewpw);
            this.pnlCPW.Controls.Add(this.tbOldpw);
            this.pnlCPW.Controls.Add(this.label6);
            this.pnlCPW.Location = new System.Drawing.Point(1, 158);
            this.pnlCPW.Name = "pnlCPW";
            this.pnlCPW.Size = new System.Drawing.Size(233, 235);
            this.pnlCPW.TabIndex = 11;
            this.pnlCPW.Visible = false;
            // 
            // btnSavePw
            // 
            this.btnSavePw.Depth = 0;
            this.btnSavePw.Location = new System.Drawing.Point(115, 187);
            this.btnSavePw.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSavePw.Name = "btnSavePw";
            this.btnSavePw.Primary = true;
            this.btnSavePw.Size = new System.Drawing.Size(101, 36);
            this.btnSavePw.TabIndex = 15;
            this.btnSavePw.Text = "Wijzigen";
            this.btnSavePw.UseVisualStyleBackColor = true;
            this.btnSavePw.Click += new System.EventHandler(this.btnSavePw_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Depth = 0;
            this.btnCancel.Location = new System.Drawing.Point(13, 187);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Primary = true;
            this.btnCancel.Size = new System.Drawing.Size(101, 36);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Annuleren";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbNewpw2
            // 
            this.tbNewpw2.Depth = 0;
            this.tbNewpw2.Hint = "Wachtwoord herhalen";
            this.tbNewpw2.Location = new System.Drawing.Point(14, 123);
            this.tbNewpw2.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbNewpw2.Name = "tbNewpw2";
            this.tbNewpw2.PasswordChar = '\0';
            this.tbNewpw2.SelectedText = "";
            this.tbNewpw2.SelectionLength = 0;
            this.tbNewpw2.SelectionStart = 0;
            this.tbNewpw2.Size = new System.Drawing.Size(202, 23);
            this.tbNewpw2.TabIndex = 13;
            this.tbNewpw2.UseSystemPasswordChar = true;
            // 
            // tbNewpw
            // 
            this.tbNewpw.Depth = 0;
            this.tbNewpw.Hint = "Nieuw wachtwoord";
            this.tbNewpw.Location = new System.Drawing.Point(14, 94);
            this.tbNewpw.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbNewpw.Name = "tbNewpw";
            this.tbNewpw.PasswordChar = '\0';
            this.tbNewpw.SelectedText = "";
            this.tbNewpw.SelectionLength = 0;
            this.tbNewpw.SelectionStart = 0;
            this.tbNewpw.Size = new System.Drawing.Size(202, 23);
            this.tbNewpw.TabIndex = 12;
            this.tbNewpw.UseSystemPasswordChar = true;
            // 
            // tbOldpw
            // 
            this.tbOldpw.Depth = 0;
            this.tbOldpw.Hint = "Huidig wachtwoord";
            this.tbOldpw.Location = new System.Drawing.Point(13, 51);
            this.tbOldpw.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbOldpw.Name = "tbOldpw";
            this.tbOldpw.PasswordChar = '\0';
            this.tbOldpw.SelectedText = "";
            this.tbOldpw.SelectionLength = 0;
            this.tbOldpw.SelectionStart = 0;
            this.tbOldpw.Size = new System.Drawing.Size(202, 23);
            this.tbOldpw.TabIndex = 11;
            this.tbOldpw.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(18, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Wachtwoord wijzigen";
            // 
            // pnlWallpaper
            // 
            this.pnlWallpaper.BackColor = System.Drawing.Color.White;
            this.pnlWallpaper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlWallpaper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlWallpaper.Controls.Add(this.label8);
            this.pnlWallpaper.Controls.Add(this.btnWChoose);
            this.pnlWallpaper.Controls.Add(this.pbWallpaper);
            this.pnlWallpaper.Controls.Add(this.btnSetW);
            this.pnlWallpaper.Controls.Add(this.btnWClose);
            this.pnlWallpaper.Controls.Add(this.label7);
            this.pnlWallpaper.Location = new System.Drawing.Point(594, 89);
            this.pnlWallpaper.Name = "pnlWallpaper";
            this.pnlWallpaper.Size = new System.Drawing.Size(436, 317);
            this.pnlWallpaper.TabIndex = 12;
            this.pnlWallpaper.Visible = false;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(97, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(243, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Klik om een achtergrond te kiezen";
            // 
            // btnWChoose
            // 
            this.btnWChoose.ActiveBorderThickness = 1;
            this.btnWChoose.ActiveCornerRadius = 20;
            this.btnWChoose.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnWChoose.ActiveForecolor = System.Drawing.Color.White;
            this.btnWChoose.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnWChoose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnWChoose.BackColor = System.Drawing.Color.White;
            this.btnWChoose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWChoose.BackgroundImage")));
            this.btnWChoose.ButtonText = "Standaard";
            this.btnWChoose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWChoose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWChoose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnWChoose.IdleBorderThickness = 1;
            this.btnWChoose.IdleCornerRadius = 20;
            this.btnWChoose.IdleFillColor = System.Drawing.Color.White;
            this.btnWChoose.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnWChoose.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnWChoose.Location = new System.Drawing.Point(5, 262);
            this.btnWChoose.Margin = new System.Windows.Forms.Padding(5);
            this.btnWChoose.Name = "btnWChoose";
            this.btnWChoose.Size = new System.Drawing.Size(147, 48);
            this.btnWChoose.TabIndex = 15;
            this.btnWChoose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnWChoose.Click += new System.EventHandler(this.btnWChoose_Click);
            // 
            // pbWallpaper
            // 
            this.pbWallpaper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbWallpaper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbWallpaper.Location = new System.Drawing.Point(35, 34);
            this.pbWallpaper.Name = "pbWallpaper";
            this.pbWallpaper.Size = new System.Drawing.Size(367, 220);
            this.pbWallpaper.TabIndex = 14;
            this.pbWallpaper.TabStop = false;
            this.pbWallpaper.Click += new System.EventHandler(this.pbWallpaper_Click);
            // 
            // btnSetW
            // 
            this.btnSetW.ActiveBorderThickness = 1;
            this.btnSetW.ActiveCornerRadius = 20;
            this.btnSetW.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSetW.ActiveForecolor = System.Drawing.Color.White;
            this.btnSetW.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSetW.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSetW.BackColor = System.Drawing.Color.White;
            this.btnSetW.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSetW.BackgroundImage")));
            this.btnSetW.ButtonText = "Instellen";
            this.btnSetW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetW.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetW.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSetW.IdleBorderThickness = 1;
            this.btnSetW.IdleCornerRadius = 20;
            this.btnSetW.IdleFillColor = System.Drawing.Color.White;
            this.btnSetW.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSetW.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSetW.Location = new System.Drawing.Point(155, 262);
            this.btnSetW.Margin = new System.Windows.Forms.Padding(5);
            this.btnSetW.Name = "btnSetW";
            this.btnSetW.Size = new System.Drawing.Size(130, 48);
            this.btnSetW.TabIndex = 13;
            this.btnSetW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSetW.Click += new System.EventHandler(this.btnSetW_Click);
            // 
            // btnWClose
            // 
            this.btnWClose.ActiveBorderThickness = 1;
            this.btnWClose.ActiveCornerRadius = 20;
            this.btnWClose.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnWClose.ActiveForecolor = System.Drawing.Color.White;
            this.btnWClose.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnWClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnWClose.BackColor = System.Drawing.Color.White;
            this.btnWClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWClose.BackgroundImage")));
            this.btnWClose.ButtonText = "Sluiten";
            this.btnWClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWClose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnWClose.IdleBorderThickness = 1;
            this.btnWClose.IdleCornerRadius = 20;
            this.btnWClose.IdleFillColor = System.Drawing.Color.White;
            this.btnWClose.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnWClose.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnWClose.Location = new System.Drawing.Point(287, 262);
            this.btnWClose.Margin = new System.Windows.Forms.Padding(5);
            this.btnWClose.Name = "btnWClose";
            this.btnWClose.Size = new System.Drawing.Size(142, 48);
            this.btnWClose.TabIndex = 12;
            this.btnWClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnWClose.Click += new System.EventHandler(this.btnWClose_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(125, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(214, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Bureaubladachtergrond";
            // 
            // tmrRefresh
            // 
            this.tmrRefresh.Interval = 60000;
            this.tmrRefresh.Tick += new System.EventHandler(this.tmrRefresh_Tick);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 469);
            this.Controls.Add(this.pnlWallpaper);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pnlCPW);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScreenTime Instellingen";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.pnlCPW.ResumeLayout(false);
            this.pnlCPW.PerformLayout();
            this.pnlWallpaper.ResumeLayout(false);
            this.pnlWallpaper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWallpaper)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private Bunifu.Framework.UI.BunifuProgressBar pbTijdOver;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.Label lblTijdOver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTot;
        private System.Windows.Forms.Label lblVan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCPW;
        private System.Windows.Forms.Panel pnlCPW;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancel;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbNewpw2;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbNewpw;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbOldpw;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialRaisedButton btnSavePw;
        private Bunifu.Framework.UI.BunifuThinButton2 btnWallpaper;
        private System.Windows.Forms.Panel pnlWallpaper;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSetW;
        private Bunifu.Framework.UI.BunifuThinButton2 btnWClose;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuThinButton2 btnWChoose;
        private System.Windows.Forms.PictureBox pbWallpaper;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer tmrRefresh;
    }
}