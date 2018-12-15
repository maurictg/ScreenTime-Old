using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations;


namespace LIST.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Vul a.u.b. alle velden in")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Vul a.u.b. alle velden in")]
        public string Password { get; set; }
    }
          
    
}