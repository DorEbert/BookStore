using System;
using System.Collections.Generic;

namespace Common.Models
{
    public class ElementBoundary
    {
        public ElementAndActionKey key { get; set; }
        public Creator creator { get; set; }
        public Latlng latlng { get; set; }
        public string elementType { get; set; }
        public string name { get; set; }

        // the spring can handle with:
        public bool expired { get; set; }
        public Dictionary<string, object> elementProperties { get; set; }

        public DateTime created;
    }
}