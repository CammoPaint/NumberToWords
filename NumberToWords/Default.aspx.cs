using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NumberToWords
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConvert_Click(object sender, EventArgs e)
        {
            lblResult.Text = Helpers.NumberHelper.ConvertNumberToCurrency(double.Parse(txtNumber.Text),"dollar","cent");
        }
    }
}