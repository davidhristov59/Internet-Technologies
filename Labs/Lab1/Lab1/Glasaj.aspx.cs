using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab1
{
    public partial class Glasaj : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadInitialData();
            }
        }

        protected void LoadInitialData() //dinamicki
        {
            predmeti.Items.Add("Internet Tehnologii");
            predmeti.Items.Add("Internet");
            predmeti.Items.Add("Digitalna Elektronika");

            krediti.Items.Add("6");
            krediti.Items.Add("5.5");
            krediti.Items.Add("5.5");

        }

        protected string LoadProfessorName(string subject)
        {
            if (subject == "Internet Tehnologii")
            {
                return "Goce Armenski";
            }

            if (subject == "Internet")
            {
                return "Stefan Andonov";
            }

            if (subject == "Digitalna Elektronika")
            {
                return "Ana Kostovska";
            }

            else
            {
                return "";
            }

        }

        protected void kopce_Click(object sender, EventArgs e)
        {
            Response.Redirect($"UspeshnoGlasanje.aspx?email={Session["UserEmail"]}");
        }

        protected void predmeti_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelaprofesor.Text = LoadProfessorName(predmeti.SelectedItem.Text);
        }

        protected void dodadiButton_Click(object sender, EventArgs e)
        {
            predmeti.Items.Add(predmet_text.Text);
            krediti.Items.Add(krediti_text.Text);
        }

        protected void izbrisiButton_Click(object sender, EventArgs e)
        {
            if (predmeti.SelectedIndex != -1)
            {
                predmeti.Items.RemoveAt(predmeti.SelectedIndex); //BITNO REMOVEAT
                krediti.Items.RemoveAt(krediti.SelectedIndex);

            }
        }
    }
}