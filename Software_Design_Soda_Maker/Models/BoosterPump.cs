using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Software_Design_Soda_Maker.Models
{
    public class BoosterPump
    {
        public void increasePressure(Water water)
        {
            water.pressure -= 10;
        }
    }
}