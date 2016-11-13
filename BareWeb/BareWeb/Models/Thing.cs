using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BareWeb.Models
{
    public class Thing
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool Remember { get; set; }
        public List<int> Selections { get; set; }
        // N.B. There is no "Auth" property, so no amount of malice can bind an Auth value.
    }
}