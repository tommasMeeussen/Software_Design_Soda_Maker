using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Software_Design_Soda_Maker.Models
{
    public class CupSizeButton : Button
    {
        String selectedSize { get; set; }

        public CupSizeButton(String size)
        {
            this.selectedSize = size;
        }
    }
}