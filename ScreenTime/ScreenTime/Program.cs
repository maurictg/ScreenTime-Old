using System;
using System.Linq;
using System.Windows.Forms;

namespace ScreenTime
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (args.Contains("usersettings"))
            {
                Application.Run(new frmSettings());
            }
            else if(args.Contains("directlogin"))
            {
                string winuser = Environment.UserName;
                Application.Run(new frmTime(ST.getuser(winuser), true));
            }
            else if(args.Contains("install"))
            {
                string pth = System.Reflection.Assembly.GetEntryAssembly().Location;
                string ename = System.IO.Path.GetFileName(pth);
                string[] files = System.IO.Directory.GetFiles(Application.StartupPath);
                System.IO.Directory.CreateDirectory("C:\\ScreenTime");
                foreach(string file in files)
                {
                    System.IO.File.Copy(file, "C:\\Screentime\\" + System.IO.Path.GetFileName(file));
                }
                MessageBox.Show("Restarting to finish installation...");
                System.Diagnostics.Process.Start("C:\\ScreenTime\\" + ename);
                Application.ExitThread();
            }
            else
            {
                Application.Run(new frmLogin());
            }
            
        }
    }
}
