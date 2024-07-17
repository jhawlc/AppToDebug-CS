using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppToDebug
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double price;
            double VATRate;

            VATRate = 20.5;

            price = int.Parse(TextBox1.Text) * VATRate;

            ResultLabel.Text = price.ToString();

        }
    }
}