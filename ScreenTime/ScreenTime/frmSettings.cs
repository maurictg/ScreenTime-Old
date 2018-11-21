using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using MaterialSkin.Animations;
using MaterialSkin.Controls;

namespace ScreenTime
{
    public partial class frmSettings : MaterialForm
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        string username = string.Empty;
        string[] userdata;
        int lefttime = 0;
        int settime = 0;


        private void frmSettings_Load(object sender, EventArgs e)
        {
            pnlCPW.Location = new Point((this.Width - pnlCPW.Width) / 2, (this.Height - pnlCPW.Height) / 2);
            pnlWallpaper.Location = new Point((this.Width - pnlWallpaper.Width) / 2, (this.Height - pnlWallpaper.Height) / 2);

            username = ST.getlatestuser();
            try { userdata = ST.getdata(username); } catch { MessageBox.Show("Error"); }
            try
            {
                loadlabels();
                tmrRefresh.Start();
            }
            catch
            {
                Application.Exit();
            }

            try
            {
                string ifile = Application.StartupPath + "\\Data\\" + username + ".png";
                if(File.Exists(ifile))
                {
                    Image img = Image.FromFile(ifile);
                    pbWallpaper.BackgroundImage = img;
                }
                else
                {
                    Image img = Image.FromFile("C:\\windows\\web\\wallpaper\\windows\\img0.jpg");
                    pbWallpaper.BackgroundImage = img;
                }
            }
            catch
            {

            }
        }

        private void loadlabels()
        {
            lblName.Text = "Welkom " + username + "!";
            double time = double.Parse(userdata[3]);
            time = time / 60;
            lefttime = Convert.ToInt32(time);
            double ttime = int.Parse(userdata[2]);
            ttime = ttime / 60;
            settime = Convert.ToInt32(ttime);
            if(lefttime > settime)
            {
                pbTijdOver.MaximumValue = lefttime;
            }
            else
            {
                pbTijdOver.MaximumValue = settime;
            }

            pbTijdOver.Value = lefttime;
            lblTijdOver.Text = lefttime + " van de "+settime+" minuten over";

            lblVan.Text = userdata[5];
            lblTot.Text = userdata[6];
        }

        private void btnCPW_Click(object sender, EventArgs e)
        {
            pnlCPW.BringToFront();
            pnlCPW.Visible = true;
        }

        private void btnSavePw_Click(object sender, EventArgs e)
        {
            if (tbOldpw.Text == string.Empty || tbNewpw.Text == string.Empty || tbNewpw2.Text == string.Empty)
            {
                MessageBox.Show("Vul a.u.b. alle velden in");
            }
            else if(tbNewpw.Text != tbNewpw2.Text)
            {
                MessageBox.Show("Ingevoerde wachtwoorden komen niet overeen");
            }
            else
            {
                if(tbOldpw.Text != ST.getpass(username))
                {
                    MessageBox.Show("Oud wachtwoord is onjuist.");
                    tbOldpw.Clear();
                }
                else
                {
                    ST.updateuser(username, username, tbNewpw.Text);
                    tbOldpw.Clear();
                    tbNewpw.Clear();
                    tbNewpw2.Clear();
                    MessageBox.Show("Wijzigingen opgeslagen", "Opgeslagen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tbOldpw.Clear();
            tbNewpw.Clear();
            tbNewpw2.Clear();
            pnlCPW.Visible = false;
        }

        private void btnWallpaper_Click(object sender, EventArgs e)
        {
            pnlWallpaper.BringToFront();
            pnlWallpaper.Visible = true;
        }

        private void btnSetW_Click(object sender, EventArgs e)
        {
            if(image == null)
            {
                MessageBox.Show("Selecteer eerst een afbeelding");
            }
            else
            {
                try
                {
                    WINDOWS.createwallpaper(image, username);
                    pnlWallpaper.Visible = false;
                }
                catch
                {
                    MessageBox.Show("ERROR: Afbeelding kon niet worden ingesteld.");
                }

            }
        }

        private void btnWClose_Click(object sender, EventArgs e)
        {
            pnlWallpaper.Visible = false;
        }

        byte[] image;

        private void btnWChoose_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile("C:\\windows\\web\\wallpaper\\windows\\img0.jpg");
            pbWallpaper.BackgroundImage = img;
            WINDOWS.resetwallpaper(username);
            
        }

        private void pbWallpaper_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Image img = Image.FromFile(ofd.FileName);
                    Bitmap bm = new Bitmap(img);
                    MemoryStream ms = new MemoryStream();
                    bm.Save(ms, ImageFormat.Png);
                    image = ms.GetBuffer();
                    Image img2 = Image.FromStream(ms);
                    pbWallpaper.BackgroundImage = img2;
                }
                catch
                {
                    MessageBox.Show("Geselecteerd bestand is geen geldige afbeelding");
                }
                
            }
        }

        private void tmrRefresh_Tick(object sender, EventArgs e)
        {
            try { userdata = ST.getdata(username); } catch { MessageBox.Show("Error"); }
            try
            {
                loadlabels();
            }
            catch
            {

            }
        }
    }
}
