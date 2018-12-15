using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIST.Models
{
    public class Authentication
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
        public int Type { get; set; }
        //0 (leerling) 1 (docent) 2 (mediatheek) 3  (ouder) 4 (decaan) 5 (admin)
    }

}
