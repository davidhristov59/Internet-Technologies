using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Z1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void link1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Proizvodi.aspx?id=1&ime=Strucna Literatura");
            //dodavam ?id=1&ime... vo query stringot
            //? oznacuva prazno mesto
        }

        protected void link2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Proizvodi.aspx?id=2&ime=Beletristika");

        }

        protected void link3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Proizvodi.aspx?id=3&ime=Magazin");

        }

        
    }
}