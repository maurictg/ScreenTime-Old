using System;
using System.Drawing;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;
using System.Net.Sockets;
using HenkTcp;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenTime
{
    public partial class frmTime : Form
    {
        string[] userdata;

        string lastdate = "";
        string username = "";
        int settime = 0;
        int lefttime = 0;
        string usertype = "user";
        string day = string.Empty;
        string from = string.Empty;
        string to = string.Empty;
        string ip = WINDOWS.GetLocalIPAddress();
        int port = 10901;
        bool isDirect = false;
        string[] policys;

        public frmTime(string username, bool isdirect = false)
        {
            InitializeComponent();
            Task.Run(() => getdata(username));
            policys = ST.getpolicy(username);
            isDirect = isdirect;
        }

        private void frmTime_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = Color.DimGray;
            pnlMessage.Location = new Point((this.Width - pnlMessage.Width) / 2, (this.Height - pnlMessage.Height) / 2);
            pnlTime.Location = new Point((this.Width - pnlTime.Width) / 2, (this.Height - pnlTime.Height) / 2);
            pnlLogin.Location = new Point((this.Width - pnlLogin.Width) / 2, (this.Height - pnlLogin.Height) / 2);
            pnlMore.Location = new Point((this.Width - pnlMore.Width) / 2, (this.Height - pnlMore.Height) / 2);
            pnlShutdown.Location = new Point((this.Width - pnlShutdown.Width) / 2, (this.Height - pnlShutdown.Height) / 2);
            if(isDirect)
            {
                btnLogout.Enabled = false;
            }
        }

        static HenkTcpServer Server = new HenkTcpServer();

        private void startserver()
        {
            Server.Start(ip, port, 10, "ScreenTime", "YourSalt");
            Server.DataReceived += Server_DataReceived;
            Server.ClientConnected += Server_ClientConnected;
            Server.ClientDisconnected += Server_ClientDisconnected;
        }

        private void stopserver()
        {
            try
            {
                Server.Stop();
            }
            catch(Exception ex)
            {
                Console.Write("ERROR: " + ex.ToString());
            }
        }

        private void Server_ClientDisconnected(object sender, TcpClient e)
        {
            Console.WriteLine($"Client {e.GetHashCode()} Disconnect");
        }

        private void Server_ClientConnected(object sender, TcpClient e)
        {
            Console.WriteLine($"Client {e.GetHashCode()} connected");
            Server.Write(e, "#CONNECTED");
        }

        private void Server_DataReceived(object sender, HenkTcp.Message e)
        {
            this.Invoke((MethodInvoker)delegate ()
            {
                string data = e.MessageString;
                if (data.StartsWith("#MSG"))
                {
                    data = data.Replace("#MSG", "");
                    showmsg(data);
                    //e.Reply("Bericht weergeven");
                }
                else if (data.StartsWith("#STOP"))
                {
                    tijdblock();
                    //e.Reply("Tijd successvol gestopt");
                }
                else if (data.StartsWith("#MORE"))
                {
                    data = data.Replace("#MORE", "");
                    int more = int.Parse(data);
                    int newtime = more * 60;
                    showmsg(more.ToString() + " minuten gekregen!");

                    //e.Reply("Tijd gegeven.");
                    lefttime = newtime;
                    ST.updatetime(username, lefttime);
                    Task.Run(() => GUI.restartwindows());
                    starttime();
                    pnlMore.Visible = false;
                    this.TransparencyKey = Color.DimGray;
                    Period.Stop(); //om te voorkomen dat de period over gaat als er tijd is bijgekregen
                    pnlTime.Visible = false;
                }
            });
            
        }

        private void checkperiod()
        {
            string[] froma = from.Split(':');
            string[] toa = to.Split(':');
            
            TimeSpan ft = new TimeSpan(int.Parse(froma[0]), int.Parse(froma[1]), 0); //00:00:00
            TimeSpan tt = new TimeSpan(int.Parse(toa[0]), int.Parse(toa[1]), 0); //00:00:00
            TimeSpan now = DateTime.Now.TimeOfDay;
            if((now > ft) && (now < tt))
            {
                Console.WriteLine("Timespan TRUE");
            }
            else
            {
                Console.WriteLine("Timespan FALSE");
                periodover();
            }



        }

        private void periodover()
        {
            stoptime();
            GUI.stopwindows();
            this.TransparencyKey = Color.DarkKhaki;
            lblTime.Text = "Schermperiode is om";
            pnlTime.BringToFront();
            pnlTime.Visible = true;
        }

        private void tijdover()
        {
            GUI.stopwindows();
            this.TransparencyKey = Color.DarkKhaki;
            lblTime.Text = "Schermtijd is om";
            pnlTime.BringToFront();
            pnlTime.Visible = true;
            
        }

        private void tijdblock()
        {
            stoptime();
            GUI.stopwindows();
            this.TransparencyKey = Color.DarkKhaki;
            lblTime.Text = "Tijd gestopt door Admin";
            pnlTime.BringToFront();
            pnlTime.Visible = true;
        }

        private void showmsg(string text)
        {
            this.TransparencyKey = Color.DimGray;
            pnlMessage.BringToFront();
            lblMessage.Text = text;
            pnlMessage.Visible = true;
            Delay.Start();
        }

        private void starttime()
        {
            if(Stay.Enabled == true) { Stay.Stop(); }
            Period.Start();
            Tijd.Start();
            AutoSave.Start();
            if(policys[0]=="1"){NoTaskmgr.Start();}
            getpolicy();
            Task.Run(() => ST.updatestamp(username));
            startserver();
        }

        private void stoptime()
        {
            Period.Stop();
            AutoSave.Stop();
            Tijd.Stop();
            Stay.Start();
            Stopper.Stop();
            tijdover();
            ST.updatetime(username, lefttime);
        }

        private void getdata(string un)
        {
            userdata = ST.getdata(un);
            username = userdata[0];
            usertype = userdata[1];

            try
            {
                settime = int.Parse(userdata[2]);
                lefttime = int.Parse(userdata[3]);
                lastdate = userdata[4];
                from = userdata[5];
                to = userdata[6];
            }
            catch(Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.ToString());
            }

            if(usertype.Equals("admin"))
            {
                this.Invoke((MethodInvoker)delegate()
                {
                    showmsg("Welkom administrator");
                    frmAdmin ad = new frmAdmin();
                    ad.Show();
                    this.Hide();
                });
            }
            else
            {
                Task.Run(() => WINDOWS.setwallpaper(username));
                if (!lastdate.Equals(DateTime.Now.ToShortDateString()))
                {
                    lefttime = settime;
                }
                else
                {
                   // MessageBox.Show(lefttime.ToString());
                }

                this.Invoke((MethodInvoker)delegate ()
                {
                    starttime();
                });
            }
            
        }

        private void Stay_Tick(object sender, EventArgs e)
        {
            this.BringToFront();
            this.Activate();
        }

        private void Tijd_Tick(object sender, EventArgs e)
        {
            lefttime--;
            if(lefttime < 1)
            {
                stoptime();
            }
            else if(lefttime == 119)
            {
                //2 min
                showmsg("Nog 2 minuten over!");
            }
            else if(lefttime == 299)
            {
                //5 min
                showmsg("Nog 5 minuten over!");
            }
            else if (lefttime == 899)
            {
                //15 min
                showmsg("Nog 15 minuten over!");
            }
            else if (lefttime == 1799)
            {
                //30 min
                showmsg("Nog 30 minuten over!");
            }
            else if (lefttime == 3599)
            {
                //60 min
                showmsg("Nog 1 uur!");
            }
            else if (lefttime == 5399)
            {
                //90 min
                showmsg("Nog 1,5 uur!");
            }
            else if (lefttime == 7199)
            {
                //120 min
                showmsg("Nog 2 uur!");
            }
        }

        private void Delay_Tick(object sender, EventArgs e)
        {
            Delay.Stop();
            pnlMessage.Visible = false;
        }

        private void NoTaskmgr_Tick(object sender, EventArgs e)
        {
            try
            {
                foreach(var process in Process.GetProcessesByName("taskmgr"))
                {
                    process.Kill();
                }
            }
            catch
            {

            }
        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            pnlTime.Visible = false;
            pnlLogin.Visible = true;
            pnlLogin.BringToFront();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (usertype != "admin") { ST.updatetime(username, lefttime); }
            KERNEL.folders(username, true);
            KERNEL.restart();
            WINDOWS.resetwallpaper(string.Empty);
        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            pnlShutdown.Visible = true;
            pnlShutdown.BringToFront();
        }

        private void AutoSave_Tick(object sender, EventArgs e)
        {
            ST.updatetime(username,lefttime);
        }

        private void tbPass_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) { login(); } else { lblStatus.Visible = false; }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlTime.Visible = true;
            pnlTime.BringToFront();
            pnlLogin.Visible = false;
        }

        private void login()
        {
            if(tbUsername.Text != string.Empty && tbPass.Text != string.Empty)
            {
                if (tbUsername.Text == "Admin")
                {
                    if(ST.login(tbUsername.Text,tbPass.Text)==1)
                    {
                        //if pw ok & user=admin
                        tbUsername.Clear();
                        tbPass.Clear();
                        NoTaskmgr.Stop();
                        pnlLogin.Visible = false;
                        pnlMore.Visible = true;
                        pnlMore.BringToFront();
                        lblMeerSTNaam.Text = "Extra schermtijd geven aan " + username;
                    }
                    else
                    {
                        lblStatus.Text = "Gebruikersnaam of wachtwoord onjuist";
                        lblStatus.Visible = true;
                        tbUsername.Clear();
                        tbPass.Clear();
                    }
                }
                else
                {
                    lblStatus.Text = "Log in als Admin a.u.b.";
                    lblStatus.Visible = true;
                    tbUsername.Clear();
                    tbPass.Clear();
                }
            }
            else
            {
                lblStatus.Text = "Vul alle velden in";
                lblStatus.Visible = true;
            }
            
            
        }

        private void btnLogin_Click(object sender, EventArgs e) { login();}
        
        private void btnMCancel_Click(object sender, EventArgs e)
        {
            if (policys[0] == "1") { NoTaskmgr.Start(); }
            pnlMore.Visible = false;
            pnlTime.Visible = true;
            pnlTime.BringToFront();
        }

        private void btnGive_Click(object sender, EventArgs e)
        {
            int newtime = 0;
            if(rb15.Checked == true)
            {
                newtime = 900;
            }
            else if(rb30.Checked == true)
            {
                newtime = 1800;
            }
            else if(rb45.Checked == true)
            {
                newtime = 2700;
            }
            else if(rb1.Checked == true)
            {
                newtime = 3600;
            }
            else if(rb2.Checked == true)
            {
                newtime = 7200;
            }
            else if(rbelse.Checked == true)
            {
                try
                {
                    newtime = int.Parse(tbElse.Text);
                    newtime = newtime * 60;
                }
                catch
                {
                    MessageBox.Show("Voer a.u.b. een juist getal in");
                }
            }
            //tijd toestaan
            lefttime = newtime;
            ST.updatetime(username, lefttime);
            Task.Run(() => GUI.restartwindows());
            starttime();
            pnlMore.Visible = false;
            this.TransparencyKey = Color.DimGray;
            Period.Stop(); //om te voorkomen dat de period over gaat als er tijd is bijgekregen
        }

        private void frmTime_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (usertype != "admin") { ST.updatetime(username, lefttime); }
            KERNEL.folders(username, true);
            WINDOWS.resetwallpaper(string.Empty);
            stopserver();
        }

        private void tbUsername_KeyDown(object sender, KeyEventArgs e)
        {
            lblStatus.Visible = false;
        }

        private void btnScancel_Click(object sender, EventArgs e)
        {
            pnlShutdown.Visible = false;
            pnlTime.BringToFront();
        }

        private void btnSlogout_Click(object sender, EventArgs e)
        {
            stopserver();
            WINDOWS.resetwallpaper(string.Empty);
            WINDOWS.logout();
            Application.Exit();
        }

        private void btnSshutdown_Click(object sender, EventArgs e)
        {
            stopserver();
            WINDOWS.resetwallpaper(string.Empty);
            WINDOWS.shutdown();
            Application.Exit();
        }

        private void Period_Tick(object sender, EventArgs e)
        {
            checkperiod();
        }

        private void getpolicy()
        {
            if (policys[1] == "1")
            {
                killlist.Add("SystemSettings");
            }
            if (policys[2] == "1")
            {
                killlist.Add("cmd");
            }
            if (policys[3] == "1")
            {
                killlist.Add("Minecraft.Windows");
            }
            if (policys[4] == "1")
            {
                killlist.Add("StarStableOnlineLauncher");
            }
            Stopper.Start();
        }


        List<string> killlist = new List<string>();
        int error = 0;
        string exc = "";

        private void Stopper_Tick(object sender, EventArgs e)
        {
            
            foreach(string processname in killlist)
            {
                foreach (var process in Process.GetProcessesByName(processname))
                {
                    try { process.Kill(); } catch(Exception ex) { error++; if (error > 20) { exc = ex.ToString(); Console.WriteLine("ERROR: " + exc); } }
                }
            }
            

        }
    }
}
