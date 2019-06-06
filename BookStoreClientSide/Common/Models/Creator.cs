using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    public class Creator
    {
        public string smartspace { get; set; }
        public string email { get; set; }

        public override string ToString()
        {
            string msg = "";
            if (!string.IsNullOrEmpty(smartspace))
                msg += "smartspace=" + smartspace;
            if (!string.IsNullOrEmpty(email))
                msg += ", email=" + email + "";
            return msg;
        }
    }
}
