using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Software_Design_Soda_Maker.Models
{
   
    public class PouringButton : Button
    {
        public Soda Beverage { get; set; }
        public Indicator Indicators { get; set; }

        public PouringButton()
        {
            this.Indicators = new Indicator();
        }

    }
}