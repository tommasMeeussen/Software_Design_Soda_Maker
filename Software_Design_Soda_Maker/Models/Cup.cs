using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Software_Design_Soda_Maker.Models
{
    public class Cup
    {
        public string Size { get; set; }

        public Cup(string s)
        {
            this.Size = s;
        }

        public Cup(){
            Size = "shit";
        }
        
        public void selectSize(string s)
        {
            Size = s;
        }
    }
}