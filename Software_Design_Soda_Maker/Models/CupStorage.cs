using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Software_Design_Soda_Maker.Models
{
    public class CupStorage
    {
        public int SmallCups { get; set; }
        public int MediumCups { get; set; }
        public int LargeCups { get; set; }

        public CupStorage(int s, int m, int l)
        {
            this.SmallCups = s;
            this.MediumCups = m;
            this.LargeCups = l;
        }

        public void removeCup(Cup c)
        {
            if (c.Size.Equals("small")){
                this.SmallCups = SmallCups - 1;
            }
            else if (c.Size.Equals("medium"))
            {
                MediumCups--;
            }
            else
            {
                LargeCups--;
            }
        }
    }
}