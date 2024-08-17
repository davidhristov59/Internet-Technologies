using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Z3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            labela.Text = "Studentot David Hristov polagal " + ime.Text + " na datum " + datum.Text + "i dobil ocena " + ocena.Text;
        }
    }
}