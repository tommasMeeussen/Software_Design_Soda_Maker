using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Software_Design_Soda_Maker.Models
{
    public class SodaMachine
    {
        public CupStorage cupStorage { get; set; }
        public Soda soda { get; set; }
        public Nozzle nozzle { get; set; }
        public PouringButton pouringButton { get; set; }
        public CupSizeButton smallButton { get; set; }
        public CupSizeButton mediumButton { get; set; }
        public CupSizeButton largeButton { get; set; }
        public Cup selectedCup { get; set; }

        public SodaMachine()
        {

        }
    }
}