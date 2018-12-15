using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIST.Classes
{
    public static class Layout
    {
        public static string[] MessageColor(string result)
        {
            string[] res = new string[2];
            string color = "grey";
            if (result.StartsWith("[Err]")) { result = result.Replace("[Err]", ""); color = "red"; }
            else if (result.StartsWith("[Suc]")) { result = result.Replace("[Suc]", ""); color = "green"; }
            else if (result.StartsWith("[Inf]")) { result = result.Replace("[Inf]", ""); color = "blue"; }

            res[0] = result;
            res[1] = color;

            return res;
        }
    }
}
