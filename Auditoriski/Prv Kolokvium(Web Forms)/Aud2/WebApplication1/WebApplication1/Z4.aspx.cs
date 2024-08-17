using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Z4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void kopce_Click(object sender, EventArgs e)
        {
            labela.Text = "Brojot sto go vnesovte e: " + broj.Text;

        }
    }
}