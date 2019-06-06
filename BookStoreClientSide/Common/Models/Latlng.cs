using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    public class Latlng
    {
        public double lat { get; set; }
        public double lng { get; set; }

    
      public override string ToString()
        {
            return "[lat=" + lat + ", lng=" + lng + "]";
        }
    }
}
