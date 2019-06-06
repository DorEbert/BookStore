using Common.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Torrent_Server_Side.Commom.Models
{
    public class UserBoundary
    {
        public UserKey key { get; set; }
        public String username { get; set; }
        public String avatar { get; set; }
        public String role { get; set; }

        public long points { get; set; }

    
    }
  
}
