using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Z6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void valgrupa1Kopce_Click(object sender, EventArgs e)
        {
            labela1.Text = valgrupa1.Text;
        }

        protected void valgrupa2Kopce_Click(object sender, EventArgs e)
        {
            labela2.Text = valgrupa2.Text;
        }
    }
}