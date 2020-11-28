using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Software_Design_Soda_Maker.Models
{
    public class CupSizeButton : Button
    {
        public string SelectedSize { get; set; }

        public CupSizeButton(string size)
        {
            this.SelectedSize = size;
        }
    }
}