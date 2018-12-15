using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIST.Models
{
    public class News
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Article { get; set; }
    }

    public class Errorlog
    {
        public int Id { get; set; }
        public DateTime Timestamp { get; set; }
        public string Error { get; set; }
        public string Token { get; set; }
    }
}
