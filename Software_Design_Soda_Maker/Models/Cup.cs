using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Software_Design_Soda_Maker.Models
{
    public class Cup
    {
        public string size { get; set; }

        public Cup(String s)
        {
            this.size = s;
        }
    }
}