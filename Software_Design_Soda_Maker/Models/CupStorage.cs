using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Software_Design_Soda_Maker.Models
{
    public class CupStorage
    {
        int smallCups { get; set; }
        int mediumCups { get; set; }
        int largeCups { get; set; }

        public CupStorage(int s, int m, int l)
        {
            this.smallCups = s;
            this.mediumCups = m;
            this.largeCups = l;
        }
    }
}