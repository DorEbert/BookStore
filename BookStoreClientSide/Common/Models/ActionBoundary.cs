using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    public class ActionBoundary
    {
        public ElementAndActionKey actionKey { get; set; }
        public ElementAndActionKey element { get; set; }
        public UserKey player { get; set; }
        public string type { get; set; }
        public DateTime created { get; set; }
        public Dictionary<string, object> properties { get; set; }
    }
}
