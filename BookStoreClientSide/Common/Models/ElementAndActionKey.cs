using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    public class ElementAndActionKey
    {
        public string smartspace { get; set; }
        public string id { get; set; }

        public override string ToString()
        {
            return "[smartspace=" + smartspace + ", id=" + id + "]";
        }
    }
}
