using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Software_Design_Soda_Maker.Models
{
    public class ChillingPlate
    {
        public void lowerTemperature(Water water)
        {
            water.temperature -= 5;
        }
    }
}