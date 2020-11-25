using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Software_Design_Soda_Maker.Models
{
    public class PouringButton : Button
    {
        Soda Beverage { get; set; }
        Indicator indicator { get; set; }

    }
}