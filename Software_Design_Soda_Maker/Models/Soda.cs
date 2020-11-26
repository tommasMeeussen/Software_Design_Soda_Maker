using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Software_Design_Soda_Maker.Models
{
    public class Soda
    {
        public string SodaName { get; set; }

        public Soda(string s)
        {
            this.SodaName = s;
        }
    }
}