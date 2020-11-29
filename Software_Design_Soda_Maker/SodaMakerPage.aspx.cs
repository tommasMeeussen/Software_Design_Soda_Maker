using Software_Design_Soda_Maker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Software_Design_Soda_Maker
{
    public partial class SodaMakerPage : System.Web.UI.Page
    {
        static SodaMachine sodaM; 
        Cup currentCup = new Cup("small");
        //Cup fuck;

        protected void Page_Load(object sender, EventArgs e)
        {

            ReadData();
            if (sodaM == null)
            {
                sodaM = new SodaMachine();
                lblSmallCups.Text = sodaM.CupStorage.SmallCups.ToString();
                lblMedCups.Text = sodaM.CupStorage.MediumCups.ToString();
                lblLgCups.Text = sodaM.CupStorage.LargeCups.ToString();
            }
            //lblSmallCups.Text = sodaMachine.CupStorage.SmallCups.ToString();
        }

        public void ReadData()
        {
            //fuck = new Cup("small");
            //currentCup = new Cup("small");
            //sodaM = new SodaMachine();
        }

        public void takeCup()
        {
            sodaM.CupStorage.removeCup(sodaM.SelectedCup);
            sodaM.PouringButton.Indicators.LightStatus = true;
            lblIndicator.Text = "";
            btnTakeCup.Visible = false;
            btnDispense.Visible = true;
            if (sodaM.SelectedCup.Size == "small")
            {
                lblSmallCups.Text = sodaM.CupStorage.SmallCups.ToString();
            }
            else if (sodaM.SelectedCup.Size == "medium")
            {
                lblMedCups.Text = sodaM.CupStorage.MediumCups.ToString();
            }
            else if (sodaM.SelectedCup.Size == "large")
            {
                lblLgCups.Text = sodaM.CupStorage.LargeCups.ToString();
            }
            sodaM.SelectedCup = null;
            lblSelectedCup.Text = "Pick One";
        }

        public void selectCup(string cupSize)
        {
            //currentCup.selectSize(cupSize);
            Cup tempCup = new Cup(cupSize);
            sodaM.selectCup(cupSize);
            //sodaM.SelectedCup = currentCup;
            //sodaM.SelectedCup.selectSize(currentCup.Size);
            lblSelectedCup.Text = sodaM.SelectedCup.Size;

        }

        public void dispense()
        {
            if (sodaM.SelectedCup == null)
            {
                lblSelectedCup.Text = "Cup Size Must Be Selected First";
            }
            else if (sodaM.SelectedCup.Size == "small" && sodaM.CupStorage.SmallCups == 0 || sodaM.SelectedCup.Size == "medium" && sodaM.CupStorage.MediumCups == 0 || sodaM.SelectedCup.Size == "large" && sodaM.CupStorage.LargeCups == 0)
            {
                lblSelectedCup.Text = "Cup size unavailable, make another selection";
            }
            else
            {

                lblIndicator.Text = "Cup Full";
                sodaM.Nozzle.dispenseSoda(sodaM.Soda, sodaM.SelectedCup);
                sodaM.PouringButton.Indicators.LightStatus = true;
                btnTakeCup.Visible = true;
                btnDispense.Visible = false;
            }
        }

        protected void btnDispense_Click(object sender, EventArgs e)
        {
            dispense();
        }

        protected void btnSmall_Click(object sender, EventArgs e)
        {
            selectCup("small");
        }

        protected void btnMedium_Click(object sender, EventArgs e)
        {
            selectCup("medium");

        }

        protected void btnLarge_Click(object sender, EventArgs e)
        {
            selectCup("large");

        }

        protected void btnTakeCup_Click(object sender, EventArgs e)
        {
            takeCup();
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ReadData();

        }

        protected void btnAddSmall_Click(object sender, EventArgs e)
        {
            sodaM.CupStorage.SmallCups = sodaM.CupStorage.SmallCups + 1;
            lblSmallCups.Text = sodaM.CupStorage.SmallCups.ToString();
        }

        protected void btnAddMedium_Click(object sender, EventArgs e)
        {
            sodaM.CupStorage.MediumCups = sodaM.CupStorage.MediumCups + 1;
            lblMedCups.Text = sodaM.CupStorage.MediumCups.ToString();
        }

        protected void btnAddLg_Click(object sender, EventArgs e)
        {
            sodaM.CupStorage.LargeCups = sodaM.CupStorage.LargeCups + 1;
            lblLgCups.Text = sodaM.CupStorage.LargeCups.ToString();
        }
    }
}