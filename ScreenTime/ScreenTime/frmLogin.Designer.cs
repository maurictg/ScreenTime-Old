namespace ScreenTime
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblRemember = new System.Windows.Forms.Label();
            this.cbRemember = new Bunifu.Framework.UI.BunifuCheckbox();
            this.btnLLogin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label2 = new System.Windows.Forms.Label();
            this.ddUsername = new Bunifu.Framework.UI.BunifuDropdown();
            this.tbLPass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.Stay = new System.Windows.Forms.Timer(this.components);
            this.btnCheat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlLogin.BackColor = System.Drawing.Color.White;
            this.pnlLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLogin.Controls.Add(this.lblStatus);
            this.pnlLogin.Controls.Add(this.lblRemember);
            this.pnlLogin.Controls.Add(this.cbRemember);
            this.pnlLogin.Controls.Add(this.btnLLogin);
            this.pnlLogin.Controls.Add(this.label2);
            this.pnlLogin.Controls.Add(this.ddUsername);
            this.pnlLogin.Controls.Add(this.tbLPass);
            this.pnlLogin.Controls.Add(this.label1);
            this.pnlLogin.Location = new System.Drawing.Point(271, 74);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(301, 302);
            this.pnlLogin.TabIndex = 0;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(27, 208);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(224, 16);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Gebruikersnaam/wachtwoord onjuist";
            this.lblStatus.Visible = false;
            this.lblStatus.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblStatus_MouseDoubleClick);
            // 
            // lblRemember
            // 
            this.lblRemember.AutoSize = true;
            this.lblRemember.Enabled = false;
            this.lblRemember.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblRemember.Location = new System.Drawing.Point(208, 75);
            this.lblRemember.Name = "lblRemember";
            this.lblRemember.Size = new System.Drawing.Size(88, 18);
            this.lblRemember.TabIndex = 6;
            this.lblRemember.Text = "Onthoud mij";
            this.lblRemember.Visible = false;
            // 
            // cbRemember
            // 
            this.cbRemember.BackColor = System.Drawing.Color.LightSlateGray;
            this.cbRemember.ChechedOffColor = System.Drawing.Color.LightSlateGray;
            this.cbRemember.Checked = false;
            this.cbRemember.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cbRemember.Enabled = false;
            this.cbRemember.ForeColor = System.Drawing.Color.White;
            this.cbRemember.Location = new System.Drawing.Point(182, 75);
            this.cbRemember.Name = "cbRemember";
            this.cbRemember.Size = new System.Drawing.Size(20, 20);
            this.cbRemember.TabIndex = 5;
            this.cbRemember.Visible = false;
            // 
            // btnLLogin
            // 
            this.btnLLogin.ActiveBorderThickness = 1;
            this.btnLLogin.ActiveCornerRadius = 20;
            this.btnLLogin.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLLogin.ActiveForecolor = System.Drawing.Color.White;
            this.btnLLogin.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLLogin.BackColor = System.Drawing.Color.White;
            this.btnLLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLLogin.BackgroundImage")));
            this.btnLLogin.ButtonText = "Inloggen";
            this.btnLLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLLogin.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnLLogin.IdleBorderThickness = 1;
            this.btnLLogin.IdleCornerRadius = 20;
            this.btnLLogin.IdleFillColor = System.Drawing.Color.White;
            this.btnLLogin.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLLogin.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLLogin.Location = new System.Drawing.Point(65, 237);
            this.btnLLogin.Margin = new System.Windows.Forms.Padding(5);
            this.btnLLogin.Name = "btnLLogin";
            this.btnLLogin.Size = new System.Drawing.Size(161, 49);
            this.btnLLogin.TabIndex = 4;
            this.btnLLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLLogin.Click += new System.EventHandler(this.btnLLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label2.Location = new System.Drawing.Point(26, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gebruikersnaam";
            // 
            // ddUsername
            // 
            this.ddUsername.BackColor = System.Drawing.Color.Transparent;
            this.ddUsername.BorderRadius = 3;
            this.ddUsername.DisabledColor = System.Drawing.Color.Gray;
            this.ddUsername.ForeColor = System.Drawing.Color.White;
            this.ddUsername.Items = new string[0];
            this.ddUsername.Location = new System.Drawing.Point(30, 126);
            this.ddUsername.Name = "ddUsername";
            this.ddUsername.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ddUsername.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ddUsername.selectedIndex = -1;
            this.ddUsername.Size = new System.Drawing.Size(184, 32);
            this.ddUsername.TabIndex = 2;
            // 
            // tbLPass
            // 
            this.tbLPass.Depth = 0;
            this.tbLPass.Hint = "Wachtwoord";
            this.tbLPass.Location = new System.Drawing.Point(30, 182);
            this.tbLPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbLPass.Name = "tbLPass";
            this.tbLPass.PasswordChar = '\0';
            this.tbLPass.SelectedText = "";
            this.tbLPass.SelectionLength = 0;
            this.tbLPass.SelectionStart = 0;
            this.tbLPass.Size = new System.Drawing.Size(238, 23);
            this.tbLPass.TabIndex = 1;
            this.tbLPass.UseSystemPasswordChar = true;
            this.tbLPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbLPass_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(54, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inloggen";
            // 
            // Stay
            // 
            this.Stay.Interval = 500;
            this.Stay.Tick += new System.EventHandler(this.Stay_Tick);
            // 
            // btnCheat
            // 
            this.btnCheat.FlatAppearance.BorderSize = 0;
            this.btnCheat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheat.Location = new System.Drawing.Point(0, 3);
            this.btnCheat.Name = "btnCheat";
            this.btnCheat.Size = new System.Drawing.Size(2, 2);
            this.btnCheat.TabIndex = 1;
            this.btnCheat.UseVisualStyleBackColor = true;
            this.btnCheat.Click += new System.EventHandler(this.btnCheat_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.label3.Location = new System.Drawing.Point(-3, 480);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "ScreenTime ©MaurICT 2018";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(864, 493);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCheat);
            this.Controls.Add(this.pnlLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuDropdown ddUsername;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbLPass;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLLogin;
        private Bunifu.Framework.UI.BunifuCheckbox cbRemember;
        private System.Windows.Forms.Label lblRemember;
        private System.Windows.Forms.Timer Stay;
        private System.Windows.Forms.Button btnCheat;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label3;
    }
}

