using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;

namespace LIST.Classes
{
    public class Engine
    {
        public static string connectionstring()
        {
            return @"Server=localhost\SQLEXPRESS;Database=LIST;uid=listdef;pwd=data;";
            //create login [IIS APPPOOL\ASP.NET v4.0] from windows;exec sp_addsrvrolemember N'IIS APPPOOL\ASP.NET v4.0', sysadmin
            //Data Source=(localdb)\.\IIS_DB;Initial Catalog=OldFashionedDB;Integrated Security=True
            //return  ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        public static void WriteError(string error, string ip)
        {
            string timestamp = DateTime.Now.ToShortDateString() +" "+ DateTime.Now.ToShortTimeString();
            try
            {
                SqlConnection connection = new SqlConnection(connectionstring());
                SqlCommand command = new SqlCommand("INSERT INTO errorlog(timestamp, ip, error) VALUES (@timestamp,@ip,@error)", connection);
                command.Parameters.AddWithValue("@timestamp", timestamp);
                command.Parameters.AddWithValue("@ip", ip);
                command.Parameters.AddWithValue("@error", error);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch //er kan geen error worden gelogd in de db, dus het ligt aan de db
            {
                try
                {
                    string fullerror = "Error: " + error + ", Tijdstempel: " + timestamp + Environment.NewLine + "IP-Adres: " + ip + "=====================";
                    //string efilepath = System.Web.HttpContext.Current.Server.MapPath("~/App_Data/errorslog.txt");
                    //if (!File.Exists(efilepath)) { File.WriteAllText(efilepath, fullerror); }
                    //else
                    //{
                    //    File.AppendAllText(efilepath, fullerror); //log error in txt bestand

                    //}
                    Console.WriteLine(fullerror);
                }
                catch
                {

                }
            }
        }
    }
}