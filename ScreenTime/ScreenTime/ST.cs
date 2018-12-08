using System;
using System.Collections.Generic;
using System.Threading;
using System.IO;
using System.Net;
using System.Management;
using Microsoft.Win32;
using System.Data.SQLite;
using System.Diagnostics;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Runtime.InteropServices;


namespace ScreenTime
{
    class ST
    {
        public static string connectionstring()
        {
            return "Data source=" + Application.StartupPath + "\\ScreenTime.stdb";
        }

        public static string[] getusers()
        {
            List<string> usr = new List<string>();
            SQLiteConnection connection = new SQLiteConnection(connectionstring());
            connection.Open();
            SQLiteCommand command = new SQLiteCommand("SELECT * FROM UserData",connection);
            SQLiteDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                string usn = reader["Username"].ToString();
                usr.Add(usn);
            }
            connection.Close();
            string[] users = usr.ToArray();
            return users;
        }

        public static string[] getdata(string username)
        {
            Console.WriteLine("GETDATA called");
            List<string> data = new List<string>();
            SQLiteConnection connection = new SQLiteConnection("Data source=" + Application.StartupPath + "\\ScreenTime.stdb");
            connection.Open();
            SQLiteCommand command = new SQLiteCommand("SELECT * FROM UserData WHERE Username=@username", connection);
            command.Parameters.AddWithValue("@username", username);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                data.Add(username); //0
                data.Add(reader["Type"].ToString()); //1

                if(data[1]!="admin")
                {
                    Console.WriteLine("is user");
                    string[] gt = gettime(username);
                    data.Add(gt[0]); //2 - settime
                    data.Add(reader["Lefttime"].ToString()); //3
                    data.Add(reader["Lastdate"].ToString()); //4
                    data.Add(gt[1]); //5 from
                    data.Add(gt[2]); //6 to
                }
                
            }
            connection.Close();

            foreach (string item in data)
            {
                Console.WriteLine(data.IndexOf(item).ToString() + item);
            }

            return data.ToArray();
        }

        public static string[] gettime(string username)
        {
            List<string> td = new List<string>();
            string[] schema = getschema(username);
            string from = string.Empty;
            string to = string.Empty;
            string settime = string.Empty;
            string day = string.Empty;
            //Dag ophalen
            DayOfWeek dw = DateTime.Now.DayOfWeek;
            switch (dw)
            {
                case DayOfWeek.Monday:
                    from = schema[0];
                    to = schema[1];
                    day = "mon";
                    break;
                case DayOfWeek.Tuesday:
                    from = schema[2];
                    to = schema[3];
                    day = "tue";
                    break;
                case DayOfWeek.Wednesday:
                    from = schema[4];
                    to = schema[5];
                    day = "wed";
                    break;
                case DayOfWeek.Thursday:
                    from = schema[6];
                    to = schema[7];
                    day = "thu";
                    break;
                case DayOfWeek.Friday:
                    from = schema[8];
                    to = schema[9];
                    day = "fri";
                    break;
                case DayOfWeek.Saturday:
                    from = schema[10];
                    to = schema[11];
                    day = "sat";
                    break;
                case DayOfWeek.Sunday:
                    from = schema[12];
                    to = schema[13];
                    day = "sun";
                    break;
            }

           
            SQLiteConnection connection = new SQLiteConnection("Data source=" + Application.StartupPath + "\\ScreenTime.stdb");
            SQLiteCommand command = new SQLiteCommand("SELECT * FROM TimeData WHERE Username=@username",connection);
            command.Parameters.AddWithValue("@username", username);
            connection.Open();
            SQLiteDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                settime = reader[day].ToString();
            }
            connection.Close();

            td.Add(settime); //0
            td.Add(from); //1
            td.Add(to); //2

            return td.ToArray();

        }

        public static string[] getschema(string username)
        {
            Console.WriteLine("GETSCHEMA called");
            List<string> data = new List<string>();
            SQLiteConnection connection = new SQLiteConnection("Data source=" + Application.StartupPath + "\\ScreenTime.stdb");
            SQLiteCommand command = new SQLiteCommand("SELECT * FROM TimeData WHERE Username=@username", connection);
            command.Parameters.AddWithValue("@username", username);
            connection.Open();
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                data.Add(reader["monfrom"].ToString()); //0
                data.Add(reader["monto"].ToString());
                data.Add(reader["tuefrom"].ToString()); //2
                data.Add(reader["tueto"].ToString());
                data.Add(reader["wedfrom"].ToString()); //4
                data.Add(reader["wedto"].ToString());
                data.Add(reader["thufrom"].ToString()); //6
                data.Add(reader["thuto"].ToString());
                data.Add(reader["frifrom"].ToString()); //8
                data.Add(reader["frito"].ToString());
                data.Add(reader["satfrom"].ToString()); //10
                data.Add(reader["satto"].ToString());
                data.Add(reader["sunfrom"].ToString()); //12
                data.Add(reader["sunto"].ToString());
            }
            connection.Close();

            return data.ToArray();
        }

        public static string[] gettijdschema(string username)
        {
            Console.WriteLine("GETTIJDSCHEMA called");
            List<string> data = new List<string>();
            SQLiteConnection connection = new SQLiteConnection("Data source=" + Application.StartupPath + "\\ScreenTime.stdb");
            SQLiteCommand command = new SQLiteCommand("SELECT * FROM TimeData WHERE Username=@username", connection);
            command.Parameters.AddWithValue("@username", username);
            connection.Open();
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                data.Add(reader["mon"].ToString()); //0
                data.Add(reader["tue"].ToString());
                data.Add(reader["wed"].ToString()); //2
                data.Add(reader["thu"].ToString());
                data.Add(reader["fri"].ToString()); //4
                data.Add(reader["sat"].ToString());
                data.Add(reader["sun"].ToString()); //6
            }
            connection.Close();
            return data.ToArray();
        }



        public static int login(string username, string password)
        {
            string pass = null;
            try
            {
                SQLiteConnection connection = new SQLiteConnection("Data source=" + Application.StartupPath + "\\ScreenTime.stdb");
                SQLiteCommand command = new SQLiteCommand("SELECT * FROM UserData WHERE Username=@username", connection);
                command.Parameters.AddWithValue("@username", username);
                connection.Open();
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    pass = reader["Password"].ToString();
                }
                connection.Close();

                if (pass == password && !string.IsNullOrEmpty(pass))
                {
                    return 1; //juist
                }
                else
                {
                    return 0; //onjuist
                }
            }
            catch
            {
                return 2;
            }
           
        }

        public static void updatetime(string username, int lefttime)
        {
            SQLiteConnection connection = new SQLiteConnection("Data source=" + Application.StartupPath + "\\ScreenTime.stdb");
            SQLiteCommand command = new SQLiteCommand("UPDATE UserData SET Lefttime='"+ lefttime.ToString() + "' WHERE Username=@username", connection);
            command.Parameters.AddWithValue("@username", username);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static void updatestamp(string username)
        {
            SQLiteConnection connection = new SQLiteConnection("Data source=" + Application.StartupPath + "\\ScreenTime.stdb");
            SQLiteCommand command = new SQLiteCommand("UPDATE UserData SET Lastdate=@lastdate, Lasttime=@lasttime WHERE Username=@username", connection);
            SQLiteCommand command2 = new SQLiteCommand("UPDATE Settings SET Remember=@username", connection);
            command.Parameters.AddWithValue("@lastdate", DateTime.Now.ToShortDateString());
            command.Parameters.AddWithValue("@lasttime", DateTime.Now.ToLongTimeString());
            command.Parameters.AddWithValue("@username", username);
            command2.Parameters.AddWithValue("@username", username);
            connection.Open();
            command.ExecuteNonQuery();
            command2.ExecuteNonQuery();
            connection.Close();
        }

        public static bool testconnection()
        {
            try
            {
                SQLiteConnection connection = new SQLiteConnection("Data source=" + Application.StartupPath + "\\ScreenTime.stdb");
                connection.Open();
                connection.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static void adduser(string username, string password)
        {
            SQLiteConnection connection = new SQLiteConnection(connectionstring());
            SQLiteCommand command = new SQLiteCommand("INSERT INTO UserData(Username, Password, Type, Settime, Lefttime) VALUES (@un,@pw,'user','0','0')", connection);
            SQLiteCommand command2 = new SQLiteCommand("INSERT INTO TimeData(Username, monfrom, monto, tuefrom, tueto, wedfrom, wedto, thufrom, thuto, frifrom, frito, satfrom, satto, sunfrom, sunto, mon, tue, wed, thu, fri, sat, sun) VALUES (@un,'00:01','00:02','00:03','00:04','00:05','00:06','00:07','00:08','00:09','00:10','00:11','00:12','00:13','00:14','0','0','0','0','0','0','0')", connection);
            SQLiteCommand command3 = new SQLiteCommand("INSERT INTO Policy(Username, distmg, disset, discmd, dismc, disss VALUES @un, @false, @false, @false, @false, @false");
            command.Parameters.AddWithValue("@un", username);
            command2.Parameters.AddWithValue("@un", username);
            command3.Parameters.AddWithValue("@un", username);
            command3.Parameters.AddWithValue("@false", "0");
            command.Parameters.AddWithValue("@pw", password);
            connection.Open();
            command.ExecuteNonQuery();
            command2.ExecuteNonQuery();
            command3.ExecuteNonQuery();
            connection.Close();
        }

        public static void deluser(string username)
        {
            SQLiteConnection connection = new SQLiteConnection(connectionstring());
            SQLiteCommand command = new SQLiteCommand("DELETE FROM UserData WHERE Username=@un", connection);
            SQLiteCommand command2 = new SQLiteCommand("DELETE FROM TimeData WHERE Username=@un", connection);
            command.Parameters.AddWithValue("@un", username);
            command2.Parameters.AddWithValue("@un", username);
            connection.Open();
            command.ExecuteNonQuery();
            command2.ExecuteNonQuery();
            connection.Close();
        }

        public static string getuser(string user, bool getwinuser = false)
        {

            try
            {
                SQLiteConnection connection = new SQLiteConnection(connectionstring());
                SQLiteCommand command = new SQLiteCommand("", connection);

                if (getwinuser)
                {
                    command.CommandText = "SELECT * FROM UserData WHERE Username=@un";
                    command.Parameters.AddWithValue("@un", user);
                }
                else
                {
                    command.CommandText = "SELECT * FROM UserData WHERE Windowsuser=@un";
                    command.Parameters.AddWithValue("@un", user);
                }
                connection.Open();
                string un = ""; string winu = "";
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    un = reader["Username"].ToString();
                    winu = reader["Windowsuser"].ToString();
                }
                connection.Close();
                return (getwinuser == true) ? winu : un;
            }
            catch(Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.ToString());
                return null;
            }
           

        }

        public static void updateuser(string username, string un, string pw, string winuser = null)
        {
            SQLiteConnection connection = new SQLiteConnection(connectionstring());
            SQLiteCommand command = new SQLiteCommand("", connection);
            if (winuser != null)
            {
                command.CommandText = "UPDATE UserData SET Username=@un, Password=@pw, Windowsuser=@wu WHERE Username=@username";
                command.Parameters.AddWithValue("@wu", winuser);
            }
            else
            {
                command.CommandText = "UPDATE UserData SET Username=@un, Password=@pw WHERE Username=@username";
            }
            SQLiteCommand command2 = new SQLiteCommand("UPDATE TimeData SET Username=@un WHERE Username=@username", connection);
            command.Parameters.AddWithValue("@username", username);
            command2.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@un", un);
            command2.Parameters.AddWithValue("@un", un);
            command.Parameters.AddWithValue("@pw", pw);
            connection.Open();
            command.ExecuteNonQuery();
            command2.ExecuteNonQuery();
            connection.Close();
        }

        public static void updateadmin(string password)
        {
            SQLiteConnection connection = new SQLiteConnection(connectionstring());
            SQLiteCommand command = new SQLiteCommand("UPDATE UserData SET Password=@password WHERE Username='Admin'", connection);
            command.Parameters.AddWithValue("@password", password);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static void updateschema(string[] schema, string username)
        {
            try
            {
                SQLiteConnection connection = new SQLiteConnection(connectionstring());
                SQLiteCommand command = new SQLiteCommand("UPDATE TimeData SET monfrom=@mf, monto=@mt, tuefrom=@tf, tueto=@tt, wedfrom=@wf, wedto=@wt, thufrom=@df, thuto=@dt, frifrom=@ff, frito=@ft, satfrom=@zf, satto=@zt, sunfrom=@sf, sunto=@st WHERE Username=@username", connection);
                command.Parameters.AddWithValue("@mf", schema[0]);
                command.Parameters.AddWithValue("@mt", schema[1]);
                command.Parameters.AddWithValue("@tf", schema[2]);
                command.Parameters.AddWithValue("@tt", schema[3]);
                command.Parameters.AddWithValue("@wf", schema[4]);
                command.Parameters.AddWithValue("@wt", schema[5]);
                command.Parameters.AddWithValue("@df", schema[6]);
                command.Parameters.AddWithValue("@dt", schema[7]);
                command.Parameters.AddWithValue("@ff", schema[8]);
                command.Parameters.AddWithValue("@ft", schema[9]);
                command.Parameters.AddWithValue("@zf", schema[10]);
                command.Parameters.AddWithValue("@zt", schema[11]);
                command.Parameters.AddWithValue("@sf", schema[12]);
                command.Parameters.AddWithValue("@st", schema[13]);
                command.Parameters.AddWithValue("@username", username);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.ToString());
            }

        }

        public static void updatetijdschema(string[] schema, string username)
        {
            try
            {
                SQLiteConnection connection = new SQLiteConnection(connectionstring());
                SQLiteCommand command = new SQLiteCommand("UPDATE TimeData SET mon=@mon, tue=@tue, wed=@wed, thu=@thu, fri=@fri, sat=@sat, sun=@sun WHERE Username=@username", connection);
                command.Parameters.AddWithValue("@mon", schema[0]);
                command.Parameters.AddWithValue("@tue", schema[1]);
                command.Parameters.AddWithValue("@wed", schema[2]);
                command.Parameters.AddWithValue("@thu", schema[3]);
                command.Parameters.AddWithValue("@fri", schema[4]);
                command.Parameters.AddWithValue("@sat", schema[5]);
                command.Parameters.AddWithValue("@sun", schema[6]);
                command.Parameters.AddWithValue("@username", username);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.ToString());
            }

        }

        public static bool useWindowsAccounts()
        {
            string mode = string.Empty;
            SQLiteConnection connection = new SQLiteConnection(connectionstring());
            SQLiteCommand command = new SQLiteCommand("SELECT * FROM Settings", connection);
            connection.Open();
            SQLiteDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                mode = reader["Mode"].ToString();
            }
            connection.Close();
            return (mode == "0") ? false : true;
        }

        public static void updatemode(bool WindowsAccounts)
        {
            string val = "0";
            if(WindowsAccounts)
            {
                val = "1";
            }
            SQLiteConnection connection = new SQLiteConnection(connectionstring());
            SQLiteCommand command = new SQLiteCommand("UPDATE Settings SET Mode=@val", connection);
            command.Parameters.AddWithValue("@val", val);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static string getpass(string username)
        {
            string pw = string.Empty;
            SQLiteConnection connection = new SQLiteConnection(connectionstring());
            connection.Open();
            SQLiteCommand command = new SQLiteCommand("SELECT * FROM UserData WHERE Username=@un", connection);
            command.Parameters.AddWithValue("@un", username);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                pw = reader["Password"].ToString();
            }
            connection.Close();
            return pw;
        }

        public static string getlatestuser()
        {
            string un = string.Empty;
            SQLiteConnection connection = new SQLiteConnection(connectionstring());
            connection.Open();
            SQLiteCommand command = new SQLiteCommand("SELECT * FROM Settings", connection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                un = reader["Remember"].ToString();
            }
            connection.Close();
            return un;
        }

        public static void updatepolicy(string username, string[] policys)
        {
            try
            {
                SQLiteConnection connection = new SQLiteConnection(connectionstring());
                SQLiteCommand command = new SQLiteCommand("UPDATE Policy SET distmg=@tmg, disset=@set, discmd=@cmd, dismc=@mc, disss=@ss WHERE Username=@un", connection);
                command.Parameters.AddWithValue("@un", username);
                command.Parameters.AddWithValue("@tmg", policys[0]);
                command.Parameters.AddWithValue("@set", policys[1]);
                command.Parameters.AddWithValue("@cmd", policys[2]);
                command.Parameters.AddWithValue("@mc", policys[3]);
                command.Parameters.AddWithValue("@ss", policys[4]);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.ToString());
            }

        }

        public static string[] getpolicy(string username)
        {
            try
            {
                string[] policy = new string[5];
                SQLiteConnection connection = new SQLiteConnection(connectionstring());
                SQLiteCommand command = new SQLiteCommand("SELECT * FROM Policy WHERE Username=@un", connection);
                command.Parameters.AddWithValue("@un", username);
                connection.Open();
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string[] policys = { (string)reader["distmg"], (string)reader["disset"], (string)reader["discmd"], (string)reader["dismc"], (string)reader["disss"] };
                    policy = policys;
                }
                connection.Close();
                return policy;
            }
            catch(Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.ToString());
                return null;
            }
            
        }
    }

    static class KERNEL
    {
        public static void setfiles()
        {
            if (!File.Exists(Application.StartupPath + "\\ScreenTime.stdb"))
            {
                SQLiteConnection.CreateFile(Application.StartupPath + "\\ScreenTime.stdb");
                SQLiteConnection con = new SQLiteConnection(ST.connectionstring());
                SQLiteCommand cmd = new SQLiteCommand("CREATE TABLE UserData(Username, Password, Type, Settime, Lefttime, Lastdate, Lasttime, Windowsuser)", con);
                SQLiteCommand cmd0 = new SQLiteCommand("CREATE TABLE Settings(Remember, Mode)", con); //remember is voor settings
                SQLiteCommand cmd1 = new SQLiteCommand("CREATE TABLE TimeData(Username, monfrom, monto, tuefrom, tueto, wedfrom, wedto, thufrom, thuto, frifrom, frito, satfrom, satto, sunfrom, sunto, mon, tue, wed, thu, fri, sat, sun)", con);
                SQLiteCommand cmd01 = new SQLiteCommand("CREATE TABLE Policy(Username, distmg, disset, discmd, dismc, disss)",con);
                SQLiteCommand cmd02 = new SQLiteCommand("INSERT INTO Settings(Remember, Mode) VALUES ('NULL','0')",con);
                SQLiteCommand cmd2 = new SQLiteCommand("INSERT INTO UserData(Username, Password, Type) VALUES ('Admin','Admin123','admin')", con);
                SQLiteCommand cmd3 = new SQLiteCommand("INSERT INTO UserData(Username, Password, Type, Settime, Lefttime) VALUES ('Test','test123','user','30','30')", con);
                SQLiteCommand cmd4 = new SQLiteCommand("INSERT INTO TimeData(Username, monfrom, monto, tuefrom, tueto, wedfrom, wedto, thufrom, thuto, frifrom, frito, satfrom, satto, sunfrom, sunto, mon, tue, wed, thu, fri, sat, sun) VALUES ('Test','00:01','00:02','00:03','00:04','00:05','00:06','00:07','00:08','00:09','00:10','00:11','00:12','00:13','00:14','0','0','0','0','0','0','0')", con);
                SQLiteCommand cmd5 = new SQLiteCommand("INSERT INTO Policy(Username, distmg, disset, discmd, dismc, disss) VALUES ('Test', '1', @false, @false, @false, @false)",con);
                cmd5.Parameters.AddWithValue("@false", "0");

                con.Open();
                cmd.ExecuteNonQuery();
                cmd0.ExecuteNonQuery();
                cmd01.ExecuteNonQuery();
                cmd02.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();
                cmd4.ExecuteNonQuery();
                cmd5.ExecuteNonQuery();
                con.Close();
            }
            if (!File.Exists(Application.StartupPath + "\\Bunifu_UI_v1.5.3.dll") || !File.Exists(Application.StartupPath + "\\MaterialSkin.dll"))
            {
                using (var client = new WebClient())
                {
                    client.DownloadFile("https://drive.google.com/uc?export=download&id=1ykNGF15Jk2DN8HWGFmswg18rtXFp3OdD", Application.StartupPath + "\\ScreenTime.mdf");
                    client.DownloadFile("https://drive.google.com/uc?export=download&id=1du-YfhPoJsIYUuAnSllWWQUQHl1hsU9O", Application.StartupPath + "\\Bunifu_UI_v1.5.3.dll");
                    client.DownloadFile("https://drive.google.com/uc?export=download&id=1kiim6pVqwtjwicUxbYpME-uLFMa6l-2J", Application.StartupPath + "\\MaterialSkin.dll");

                }

                MessageBox.Show("ScreenTime needs to be restarted to finish downloading");
                Application.Exit();
            }

            if (!File.Exists(Application.StartupPath + "\\no_gui.bat"))
            {
                File.WriteAllText(Application.StartupPath + "\\no_gui.bat", "SETCONSOLE /hide" + Environment.NewLine + "Taskkill /IM explorer.exe /F" + Environment.NewLine);
            }

            if(!Directory.Exists(Application.StartupPath+"\\Data"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\Data");
            }

        }

        public static void createdesktopshortcut(string desktoppath, string executablepath)
        {
            string patht = Path.Combine(desktoppath, "Instellingen.lnk");

            IWshRuntimeLibrary.WshShell wsh = new IWshRuntimeLibrary.WshShell();
            IWshRuntimeLibrary.IWshShortcut shortcut = (IWshRuntimeLibrary.IWshShortcut)wsh.CreateShortcut(patht);
            shortcut.Arguments = "usersettings";
            shortcut.TargetPath = executablepath;
            shortcut.Description = "ScreenTime Instellingen";
            shortcut.IconLocation = Path.GetDirectoryName(executablepath) + "\\clock.ico";
            shortcut.Save();
        }

        public static void createdirectshortcut(string startuppath, string executablepath)
        {
            string patht = Path.Combine(startuppath, "ScreenTime.lnk");

            IWshRuntimeLibrary.WshShell wsh = new IWshRuntimeLibrary.WshShell();
            IWshRuntimeLibrary.IWshShortcut shortcut = (IWshRuntimeLibrary.IWshShortcut)wsh.CreateShortcut(patht);
            shortcut.Arguments = "directlogin";
            shortcut.TargetPath = executablepath;
            shortcut.Description = "ScreenTime";
            shortcut.IconLocation = Path.GetDirectoryName(executablepath) + "\\clock.ico";
            shortcut.Save();
        }

        public static void createusershortcut(string startuppath, string executablepath)
        {
            string patht = Path.Combine(startuppath, "ScreenTime.lnk");

            IWshRuntimeLibrary.WshShell wsh = new IWshRuntimeLibrary.WshShell();
            IWshRuntimeLibrary.IWshShortcut shortcut = (IWshRuntimeLibrary.IWshShortcut)wsh.CreateShortcut(patht);
            shortcut.TargetPath = executablepath;
            shortcut.Description = "ScreenTime";
            shortcut.IconLocation = Path.GetDirectoryName(executablepath) + "\\clock.ico";
            shortcut.Save();
        }

        public static void restart()
        {
            new Thread(() =>
            {
                Process.Start(System.Reflection.Assembly.GetExecutingAssembly().Location);
            }).Start();
            Application.ExitThread();
        }

        public static void wallpaper()
        {

        }

        public static void folders(string username, bool hide)
        {
            if(hide)
            {
                try
                {
                    string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\" + username;
                    DirectoryInfo di = new DirectoryInfo(path);
                    di.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
                }
                catch
                {

                }
            }
            else
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\" + username;
                if (!Directory.Exists(path))
                {
                    DirectoryInfo di = Directory.CreateDirectory(path);
                    di.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
                    di.Attributes = di.Attributes & ~FileAttributes.Hidden;
                }
                else
                {
                    DirectoryInfo di = new DirectoryInfo(path);
                    di.Attributes = di.Attributes & ~FileAttributes.Hidden;
                }
            }
        }
    }

    static class GUI
    {
        [DllImport("user32.dll", SetLastError = true)]
        static extern bool PostMessage(IntPtr hWnd, [MarshalAs(UnmanagedType.U4)] uint Msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);


        [DllImport("kernel32.dll", ExactSpelling = true)]
        public static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        const int WM_USER = 0x0400; //http://msdn.microsoft.com/en-us/library/windows/desktop/ms644931(v=vs.85).aspx

        public static void restartwindows()
        {

            foreach (var proces in Process.GetProcessesByName("cmd"))
            {
                proces.Kill();
            }

            try
            {
                var ptr = FindWindow("Shell_TrayWnd", null);
                PostMessage(ptr, WM_USER + 436, (IntPtr)0, (IntPtr)0);

                do
                {
                    ptr = FindWindow("Shell_TrayWnd", null);

                    if (ptr.ToInt32() == 0)
                    {
                        Console.WriteLine("Restarted windows GUI");
                        break;
                    }

                    Thread.Sleep(1000);
                } while (true);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex.ToString());
                Console.ReadKey(true);
            }
            Console.WriteLine("Restarting the shell.");
            string explorer = string.Format("{0}\\{1}", Environment.GetEnvironmentVariable("WINDIR"), "explorer.exe");
            Process process = new Process();
            process.StartInfo.FileName = explorer;
            process.StartInfo.UseShellExecute = true;
            process.Start();

        }

        public static bool stopwindows()
        {
            try
            {
                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;
                    Process.Start(/*AppDomain.CurrentDomain.BaseDirectory*/
            Application.StartupPath + "\\no_gui.bat");
                }).Start();
                return true;
            }
            catch
            {
                return false;
            }
            
        }

        /*
         * void voooid(string args){}
         * Task.Run(() => voooid("argument"));
         */
    }
    
    static class WINDOWS
    {
        
        const int SetDeskWallpaper = 20;
        const int UpdateIniFile = 0x01;
        const int SendWinIniChange = 0x02;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

        public static void createwallpaper(byte[] image, string username)
        {
            
            string FileName = Application.StartupPath + "\\Data\\" + username + ".png";
            File.WriteAllBytes(FileName, image);
                try
                {
                    RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true);
                    SystemParametersInfo(SetDeskWallpaper, 0, FileName, UpdateIniFile | SendWinIniChange);
                }
                catch(Exception ex)
                {
                    Console.WriteLine("ERROR: " + ex.ToString());
                }
        }

        public static void setwallpaper(string username)
        {
            string path = Application.StartupPath + "\\Data\\" + username + ".png";
            if(File.Exists(path))
            {
                try
                {
                    RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true);
                    SystemParametersInfo(SetDeskWallpaper, 0, path, UpdateIniFile | SendWinIniChange);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR: " + ex.ToString());
                }
            }
        }

        public static void resetwallpaper(string username)
        {
            try
            {
                string FileName = "C:\\windows\\web\\wallpaper\\windows\\img0.jpg";
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true);
                SystemParametersInfo(SetDeskWallpaper, 0, FileName, UpdateIniFile | SendWinIniChange);
                if (username != string.Empty) { File.Delete(Application.StartupPath + "\\Data\\" + username + ".png"); }
            }
            catch(Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.ToString());
            }
            
        }

        public static void shutdown()
        {
            DoExitWin(EWX_SHUTDOWN);
        }

        public static void reboot()
        {
            DoExitWin(EWX_REBOOT);
        }

        public static void logout()
        {
            DoExitWin(EWX_LOGOFF);
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        internal struct TokPriv1Luid
        {
            public int Count;
            public long Luid;
            public int Attr;
        }

        [DllImport("kernel32.dll", ExactSpelling = true)]
        internal static extern IntPtr GetCurrentProcess();

        [DllImport("advapi32.dll", ExactSpelling = true, SetLastError = true)]
        internal static extern bool OpenProcessToken(IntPtr h, int acc, ref IntPtr
        phtok);

        [DllImport("advapi32.dll", SetLastError = true)]
        internal static extern bool LookupPrivilegeValue(string host, string name,
        ref long pluid);

        [DllImport("advapi32.dll", ExactSpelling = true, SetLastError = true)]
        internal static extern bool AdjustTokenPrivileges(IntPtr htok, bool disall,
        ref TokPriv1Luid newst, int len, IntPtr prev, IntPtr relen);

        [DllImport("user32.dll", ExactSpelling = true, SetLastError = true)]
        internal static extern bool ExitWindowsEx(int flg, int rea);

        internal const int SE_PRIVILEGE_ENABLED = 0x00000002;
        internal const int TOKEN_QUERY = 0x00000008;
        internal const int TOKEN_ADJUST_PRIVILEGES = 0x00000020;
        internal const string SE_SHUTDOWN_NAME = "SeShutdownPrivilege";
        internal const int EWX_LOGOFF = 0x00000000;
        internal const int EWX_SHUTDOWN = 0x00000001;
        internal const int EWX_REBOOT = 0x00000002;
        internal const int EWX_FORCE = 0x00000004;
        internal const int EWX_POWEROFF = 0x00000008;
        internal const int EWX_FORCEIFHUNG = 0x00000010;

        private static void DoExitWin(int flg)
        {
            bool ok;
            TokPriv1Luid tp;
            IntPtr hproc = GetCurrentProcess();
            IntPtr htok = IntPtr.Zero;
            ok = OpenProcessToken(hproc, TOKEN_ADJUST_PRIVILEGES | TOKEN_QUERY, ref htok);
            tp.Count = 1;
            tp.Luid = 0;
            tp.Attr = SE_PRIVILEGE_ENABLED;
            ok = LookupPrivilegeValue(null, SE_SHUTDOWN_NAME, ref tp.Luid);
            ok = AdjustTokenPrivileges(htok, false, ref tp, 0, IntPtr.Zero, IntPtr.Zero);
            ok = ExitWindowsEx(flg, 0);
        }

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        public static string[] getUsers()
        {
            List<string> windowsusers = new List<string>();
            SelectQuery query = new SelectQuery("Win32_UserAccount");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
            foreach (ManagementObject envVar in searcher.Get())
            {
                windowsusers.Add(envVar["Name"].ToString());
            }

            return windowsusers.ToArray();
        }


    }

   
}
