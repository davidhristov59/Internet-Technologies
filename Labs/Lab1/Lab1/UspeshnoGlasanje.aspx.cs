using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab1
{
    public partial class UspeshnoGlasanje : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["email"] != null)
                {
                    string mail = Request.QueryString.Get("email");
                    poslednalabela.Text = "Vi blagodarime na ucestvoto vo akcijata za izbor na najinterens predmet na FINKI. Rezultatite ke gi dobiete na E-MAIL" + mail;
                }
            }
            
        }


    }
}