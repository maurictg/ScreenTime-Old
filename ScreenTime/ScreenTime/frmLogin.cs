using System;
using System.Windows.Forms;
using System.Threading.Tasks;


namespace ScreenTime
{
    public partial class frmLogin : Form
    {

        public frmLogin()
        {

            KERNEL.setfiles();
            GUI.stopwindows();

            if (ST.testconnection() == false)
            {
                MessageBox.Show("Er is iets fout met de database. Screentime werkt niet.", "ERROR, ROEP BEHEERDER", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            InitializeComponent();

        }

        private void btnLLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void login()
        {
            if (!string.IsNullOrEmpty(tbLPass.Text))
            {
                int result = ST.login(ddUsername.selectedValue, tbLPass.Text);
                if (result == 0)
                {
                    lblStatus.Text = "Wachtwoord is onjuist";
                    lblStatus.Visible = true;
                    tbLPass.Clear();
                }
                else if (result == 2)
                {
                    lblStatus.Text = "Er is een fout opgetreden";
                    lblStatus.Visible = true;
                    tbLPass.Clear();
                }
                else
                {
                    tbLPass.Clear();
                    Task.Run(() => GUI.restartwindows());
                    Stay.Stop();
                    directory();

                    start(ddUsername.selectedValue);
                }
            }
            else
            {
                lblStatus.Text = "Vul a.u.b. een wachtwoord in";
                lblStatus.Visible = true;
            }
        }

        private void start(string username)
        {
            frmTime time = new frmTime(username);
            time.Show();
            this.Hide();
        }

        private void directory()
        {
            if (ddUsername.selectedValue.ToString() != "Admin")
            {
                KERNEL.folders(ddUsername.selectedValue, false);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            ddUsername.Items = ST.getusers();
            ddUsername.selectedIndex = 0;
        }

        private void Stay_Tick(object sender, EventArgs e)
        {
            this.BringToFront();
            this.Activate();
        }

        //unlock engine
        bool unlocked = false;
        private void lblStatus_MouseDoubleClick(object sender, MouseEventArgs e) { unlocked = true; }
        private void btnCheat_Click(object sender, EventArgs e)
        {
            if (unlocked == true)
            {
                GUI.restartwindows();
                Application.Exit();
            }
        }

        private void tbLPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (lblStatus.Visible == true) { lblStatus.Visible = false; }
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }


    }
}
