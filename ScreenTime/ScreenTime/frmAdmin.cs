using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Reflection;
using System.Diagnostics;
using MaterialSkin.Controls;

namespace ScreenTime
{
    public partial class frmAdmin : MaterialForm
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        string[] allusers;
        string[] userdata;
        string[] windowsusers;
        string selecteduser = string.Empty;
        List<string> schema = new List<string>();
        List<string> tijdschema = new List<string>();
        string selectedday = string.Empty;
        string from = string.Empty;
        string to = string.Empty;
        bool useWindowsAccounts = false;

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            loadusers();
            dpFrom.Format = DateTimePickerFormat.Custom;
            dpFrom.CustomFormat = "HH:mm";
            dpFrom.ShowUpDown = true;
            dpTo.Format = DateTimePickerFormat.Custom;
            dpTo.CustomFormat = "HH:mm";
            dpTo.ShowUpDown = true;
            pnlAdd.Location = new Point((this.Width - pnlAdd.Width) / 2, (this.Height - pnlAdd.Height) / 2);
            pnlUInfo.Location = new Point((this.Width - pnlUInfo.Width) / 2, (this.Height - pnlUInfo.Height) / 2);
            pnlIntegration.Location = new Point((this.Width - pnlIntegration.Width) / 2, (this.Height - pnlIntegration.Height) / 2);
            pnlPolicy.Location = new Point((this.Width - pnlPolicy.Width) / 2, (this.Height - pnlPolicy.Height) / 2);
            lblIP.Text = WINDOWS.GetLocalIPAddress();
            windowsusers = WINDOWS.getUsers();
            lbWinusers.Items.AddRange(windowsusers);
            cbWindowsName.Items.AddRange(windowsusers);
            useWindowsAccounts = ST.useWindowsAccounts();
            swModus.Value = useWindowsAccounts;
        }

        private void ddUsername_onItemSelected(object sender, EventArgs e)
        {
            selecteduser = ddUsername.selectedValue;
            userdata = ST.getdata(selecteduser);
            schema.Clear();
            schema.AddRange(ST.getschema(selecteduser));
            tijdschema.Clear();
            tijdschema.AddRange(ST.gettijdschema(selecteduser));
            pnlInfo.Visible = true;
            pnlInfo.BringToFront();
        }

        private void tbBar_Scroll(object sender, EventArgs e)
        {
            lblTime.Text = tbBar.Value.ToString();
        }

        private void updateschema()
        {
            string day = selectedday;
            from = dpFrom.Value.ToShortTimeString();
            to = dpTo.Value.ToShortTimeString();
            int tim = tbBar.Value * 60;
            string time = tim.ToString();

            switch (day)
            {
                case "Maandag":
                    schema[0] = from;
                    schema[1] = to;
                    tijdschema[0] = time;
                    break;
                case "Dinsdag":
                    schema[2] = from;
                    schema[3] = to;
                    tijdschema[1] = time;
                    break;
                case "Woensdag":
                    schema[4] = from;
                    schema[5] = to;
                    tijdschema[2] = time;
                    break;
                case "Donderdag":
                    schema[6] = from;
                    schema[7] = to;
                    tijdschema[3] = time;
                    break;
                case "Vrijdag":
                    schema[8] = from;
                    schema[9] = to;
                    tijdschema[4] = time;
                    break;
                case "Zaterdag":
                    schema[10] = from;
                    schema[11] = to;
                    tijdschema[5] = time;
                    break;
                case "Zondag":
                    schema[12] = from;
                    schema[13] = to;
                    tijdschema[6] = time;
                    break;
            }
        }

        private void lbDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (selectedday != string.Empty) { updateschema(); }
                string day = lbDay.SelectedItem.ToString();
                selectedday = day;
                lblDag.Text = day;
                string time = string.Empty;

                switch(day)
                {
                    case "Maandag":
                        from = schema[0];
                        to = schema[1];
                        time = tijdschema[0];
                        break;
                    case "Dinsdag":
                        from = schema[2];
                        to = schema[3];
                        time = tijdschema[1];
                        break;
                    case "Woensdag":
                        from = schema[4];
                        to = schema[5];
                        time = tijdschema[2];
                        break;
                    case "Donderdag":
                        from = schema[6];
                        to = schema[7];
                        time = tijdschema[3];
                        break;
                    case "Vrijdag":
                        from = schema[8];
                        to = schema[9];
                        time = tijdschema[4];
                        break;
                    case "Zaterdag":
                        from = schema[10];
                        to = schema[11];
                        time = tijdschema[5];
                        break;
                    case "Zondag":
                        from = schema[12];
                        to = schema[13];
                        time = tijdschema[6];
                        break;
                }
                dpFrom.Value = DateTime.Parse(from);
                dpTo.Value = DateTime.Parse(to);
                double tim = double.Parse(time);
                tim = tim / 60;
                int ti = Convert.ToInt32(tim);
                tbBar.Value = ti;
                lblTime.Text = ti.ToString();
            }
            catch
            {

            }
        }

        private void loadusers()
        {
            allusers = ST.getusers();
            ddUsername.Clear();
            ddUsers2.Clear();
            ddUsername.Items = allusers;
            ddUsers2.Items = allusers; ;
            try { ddUsername.RemoveItem("Admin"); } catch { }
        }


        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            pnlAdd.Visible = false;
            tbUsername.Clear();
            tbPass1.Clear();
            tbPass2.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(tbUsername.Text == string.Empty || tbPass1.Text == string.Empty || tbPass2.Text == string.Empty)
            {
                MessageBox.Show("Vul a.u.b. alle velden in", "Vul alle velden in");
            }
            else if(tbPass1.Text != tbPass2.Text)
            {
                MessageBox.Show("Ingevoerde wachtwoorden komen niet overeen");
            }
            else
            {
                ST.adduser(tbUsername.Text, tbPass1.Text);
                pnlAdd.Visible = false;
                tbUsername.Clear();
                tbPass1.Clear();
                tbPass2.Clear();
                loadusers();
            }
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            pnlAdd.Visible = true;
            pnlAdd.BringToFront();
        }

        private void btnSaveTime_Click(object sender, EventArgs e)
        {
            if (selectedday != string.Empty) { updateschema(); }
            ST.updateschema(schema.ToArray(), selecteduser);
            ST.updatetijdschema(tijdschema.ToArray(), selecteduser);
            pnlInfo.Visible = false;
            loadusers();
            lbDay.ClearSelected();
            lblDag.Text = "Selecteer een dag";
            selectedday = string.Empty;
        }

        private void btnCancelTime_Click(object sender, EventArgs e)
        {
            selectedday = string.Empty;
            pnlInfo.Visible = false;
            lbDay.ClearSelected();
            lblDag.Text = "Selecteer een dag";
        }

        private void frmAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\Admin";
                DirectoryInfo di = new DirectoryInfo(path);
                di.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
            }
            catch
            {

            }
            Application.Exit();
        }

        private void btnSaveInfo_Click(object sender, EventArgs e)
        {
            if(cbWindowsName.Text != "Geen")
            {
                ST.updateuser(selecteduser, tbUsernameInfo.Text, tbInfoPass.Text, cbWindowsName.Text);
                
            }
            else
            {
                ST.updateuser(selecteduser, tbUsernameInfo.Text, tbInfoPass.Text);
            }
            loadusers();
            pnlUInfo.Visible = false;
        }

        private void btnCancelInfo_Click(object sender, EventArgs e)
        {
            pnlUInfo.Visible = false;
        }

        private void ddUsers2_onItemSelected(object sender, EventArgs e)
        {
            try { selecteduser = ddUsers2.selectedValue;
                tbUsernameInfo.Text = selecteduser;
                tbInfoPass.Text = ST.getpass(selecteduser);
                pnlUInfo.BringToFront();
                pnlUInfo.Visible = true;
                string winuser = ST.getuser(selecteduser, true);
                loadpolicy(selecteduser);

                if(winuser != null)
                {
                    cbWindowsName.Text = winuser;
                }
                else
                {
                    cbWindowsName.Text = "Geen";
                }


            }
            catch { }
            
        }

        private void btnSaveAPW_Click(object sender, EventArgs e)
        {
            if(ST.getpass("Admin")==tbApass.Text)
            {
                if(tbAnpw.Text == tbAnpw2.Text)
                {
                    ST.updateadmin(tbAnpw.Text);
                    MessageBox.Show("Wijzigingen opgeslagen");
                    tbAnpw.Clear();
                    tbApass.Clear();
                }
                else
                {
                    tbAnpw2.Clear();
                    tbApass.Clear();
                    MessageBox.Show("Ingevoerde wachtwoorden komen niet overeen");
                }
            }
            else
            {
                MessageBox.Show("Wachtwoord is onjuist");
                tbAnpw.Clear();
                tbApass.Clear();
            }
        }

        private void dpFrom_ValueChanged(object sender, EventArgs e)
        {
        }

        private void dpTo_ValueChanged(object sender, EventArgs e)
        {
        }

        private void pbDelUser_Click(object sender, EventArgs e)
        {
            if(selecteduser != string.Empty)
            {
                if(MessageBox.Show("Wilt u "+selecteduser+" definitief verwijderen?","Verwijderen",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    ST.deluser(selecteduser);
                    selecteduser = string.Empty;
                    loadusers();
                    if(pnlUInfo.Visible == true) { pnlUInfo.Visible = false; }
                }
            }
            else
            {
                MessageBox.Show("Selecteer a.u.b. eerst een gebruiker");
            }

        }

        private void btnInteg_Click(object sender, EventArgs e)
        {
            if (useWindowsAccounts == false)
            {
                if(MessageBox.Show("Wilt u ScreenTime integreren in Windows","Screentime integreren?",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    integdefault();
                }
            }
            else
            {
                pnlIntegration.Visible = true;
                pnlIntegration.BringToFront();
            }
           

        }

        private void integdefault()
        {
            try
            {
                string epath = Assembly.GetEntryAssembly().Location;
                string startup = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
                string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                KERNEL.createdesktopshortcut(desktop, epath);
                KERNEL.createusershortcut(startup, epath);

                MessageBox.Show("Integratie gelukt!", "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + Environment.NewLine + ex.ToString(), "Integratie mislukt!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Process.Start(Assembly.GetExecutingAssembly().Location);
            Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            

            foreach (Process pr in Process.GetProcessesByName("ScreenTime"))
            {
                pr.Kill();
            }

            Application.Exit();
            
        }

        private void btnUserSettings_Click(object sender, EventArgs e)
        {
            Process.Start(Assembly.GetExecutingAssembly().Location, "usersettings");
        }

        private void btnAScheme_Click(object sender, EventArgs e)
        {
            string day = selectedday;
            from = dpFrom.Value.ToShortTimeString();
            to = dpTo.Value.ToShortTimeString();
            int tim = tbBar.Value * 60;
            string time = tim.ToString();

           
                //case "Maandag":
                    schema[0] = from;
                    schema[1] = to;
                    tijdschema[0] = time;
                //case "Dinsdag":
                    schema[2] = from;
                    schema[3] = to;
                    tijdschema[1] = time;
                //case "Woensdag":
                    schema[4] = from;
                    schema[5] = to;
                    tijdschema[2] = time;
                //case "Donderdag":
                    schema[6] = from;
                    schema[7] = to;
                    tijdschema[3] = time;
                //case "Vrijdag":
                    schema[8] = from;
                    schema[9] = to;
                    tijdschema[4] = time;
                //case "Zaterdag":
                    schema[10] = from;
                    schema[11] = to;
                    tijdschema[5] = time;
                //case "Zondag":
                    schema[12] = from;
                    schema[13] = to;
                    tijdschema[6] = time;
            
        }

        private void btnCloseAI_Click(object sender, EventArgs e)
        {
            pnlIntegration.Visible = false;
        }

        private void swModus_Click(object sender, EventArgs e)
        {
            if(swModus.Value == true)
            {

            }
            else
            {

            }
            ST.updatemode(swModus.Value);
            useWindowsAccounts = swModus.Value;
        }

        private void lbWinusers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbWinusers.SelectedItem != null)
            {
                string name = ST.getuser(lbWinusers.SelectedItem.ToString());
                if(string.IsNullOrEmpty(name))
                {
                    lblGUN.Text = "Geen gekoppeld";
                }
                else
                {
                    lblGUN.Text = name;
                }
            }
        }

        private void btnIntegrateA_Click(object sender, EventArgs e)
        {
            string un = lbWinusers.SelectedItem.ToString();
            string startup = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            startup = startup.Replace(Environment.UserName, un);
            desktop = desktop.Replace(Environment.UserName, un);
            string epath = Assembly.GetEntryAssembly().Location;
            KERNEL.createdirectshortcut(startup, epath);
            KERNEL.createdesktopshortcut(desktop, epath);
            //epath: C:\Users\MaurICT\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup\ST\ScreenTime.exe
            MessageBox.Show("ScreenTime geintegreerd voor " + un);
        }

        private void btnCancelPolicy_Click(object sender, EventArgs e)
        {
            pnlPolicy.Visible = false;
        }

        private void loadpolicy(string username)
        {
            string[] policy = ST.getpolicy(username);
            swtmg.Value = (policy[0] == "0") ? false : true;
            swset.Value = (policy[1] == "0") ? false : true;
            swcmd.Value = (policy[2] == "0") ? false : true;
            swmc.Value = (policy[3] == "0") ? false : true;
            swss.Value = (policy[4] == "0") ? false : true;
        }

        private void btnSavePolicy_Click(object sender, EventArgs e)
        {
            string username = ddUsers2.selectedValue;
            string[] policys = { (swtmg.Value) ? "1" : "0", (swset.Value) ? "1" : "0", (swcmd.Value) ? "1" : "0", (swmc.Value) ? "1" : "0", (swss.Value) ? "1" : "0" };
            ST.updatepolicy(username, policys);
            pnlPolicy.Visible = false;
        }

        private void lblPolicys_Click(object sender, EventArgs e)
        {
            pnlPolicy.BringToFront();
            pnlPolicy.Visible = true;
        }
    }
}
