using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Http;

namespace LIST.Classes.Authentication
{
    public static class Authenticator
    {
        
    }

    public class LoginSystem
    {

        static string connectionstring = LIST.Classes.Engine.connectionstring();

        //LIST_core.Classes.EncryptionEngine eengine = new EncryptionEngine();
        static string result;
        public static string Login(string username, string password, string ip) //de ip is alleen voor error-logging
        {
            string cmdText = "SELECT * FROM logindata WHERE username = @username";
            string getpw = "";
            string getuc = "";
            int type = 0;

           
            try
            {
                SqlConnection connection = new SqlConnection(connectionstring);
                SqlCommand command = new SqlCommand(cmdText, connection);
                command.Parameters.AddWithValue("@username", username);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    getpw = reader["password"].ToString(); //wachtwoord uit db ophalen
                    getuc = reader["token"].ToString(); //token ophalen
                    type = int.Parse(reader["type"].ToString()); //type = 0 (leerling) 1 (docent) 2 (decaan) 3 (administrator)
                }
                connection.Close();
                connection.Dispose();

                try
                {
                    if (LIST.Classes.Encryption.HASH.checkPBKDF2(password, getpw))
                    {
                        result = type.ToString() + getuc; //return de token + type (gebruikt om te weten naar welke page hij moet redirecten)
                    }
                    else
                    {
                        result = null; //als de result null is, dan is de gebruikersnaam of het wachtwoord onjuist
                        Engine.WriteError("UNPW onjuist: " + getpw + ":" + password + ":" + getuc,"#");
                    }
                }
                catch(Exception ex)
                {
                    Engine.WriteError("ERR "+ex.ToString(),"#");
                    return "error";

                }

            }
            catch (Exception ex) //kan niet inloggen
            {
                
                LIST.Classes.Engine.WriteError(ex.ToString(), ip);
                result = "error";
            }


            return result;
        }
    }
}