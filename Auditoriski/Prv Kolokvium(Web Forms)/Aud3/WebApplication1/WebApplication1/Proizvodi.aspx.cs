using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Proizvodi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                //treba da gi zemam informaciite od query stringot
            }

            // База на податоци - ke se vcituvaat koga stranata ke se loadira prviot pat - isPostBack svojstvoto e false, sto znaci na prvoto vcituvanje na stranata
            string[] sl = {
                    "Modern Operating Systems by Andrew S. Tanenbaum",
                    "Advanced Programming in the UNIX Environment by W. Richard Stevens",
                    "The Mythical Man-month by Frederick Phillips Brooks",
                    "Introduction to the Theory of Computation by Michael Sipser",
                    "Thinking in Systems: A Primer by Donella H. Meadows"
                };

            string[] sl_c = {
                    "45", "60", "20", "55", "30"
                };

            string[] be = {
                    "Origin by Dan Brown",
                    "The Hobbit by J. R. R. Tolkien",
                    "Harry Potter and the Philosopher's Stone by J. K. Rowling",
                    "Sherlock Holmes Series by Arthur Conan Doyle",
                    "Hercule Poirot Mysteries Series by Agatha Christie"
                };

            string[] be_c = {
                    "10", "9", "9", "50", "40"
                };

            string[] mg = {
                    "WIRED",
                    "PC Magazine",
                    "MIT Technology Review",
                    "Linux Magazine",
                    "Fast Company"
                };

            string[] mg_c = {
                    "2", "3", "1", "3", "2"
                };


            //pristapuvame query stringot
            var selected_category_id = Convert.ToInt32(Request.QueryString.Get("id"));//go zimame OD query stringot - sto dodadovme
            var selected_category_name = Request.QueryString.Get("ime");
            //2 opcija 
            //var selected_cat_name = Request.QueryString["ime"];

            naslov.Text = selected_category_name; //da go prikazuva naslovot na selektiratana kategorija 

            switch (selected_category_id)
            {
                case 0:
                    //go popolnuvam listboxot so dadenite podatoci
                    naslovi.DataSource = sl; //so DataBind polnam vnatre, A DataSource od kade da se zemat
                    ceni.DataSource = sl_c;
                    break;
                case 1:
                    naslovi.DataSource = be;
                    ceni.DataSource = be_c;
                    break;
                case 2:
                    naslovi.DataSource = mg;
                    ceni.DataSource = mg_c;
                    break;
            }

            //moram da go napolnam nekako i toa ke go napravam so DataBind
            naslovi.DataBind();
            ceni.DataBind(); 

        }

        protected void back_Click(object sender,EventArgs e)
        {
            Response.Redirect("Katalog.aspx");
        }

        protected void naslovi_SelectedIndexChanged(object sender, EventArgs e) //so gromceto go napraviv - event v properties
        {
            //koga ke selektiram nesto 

            //var naslov_selected = naslovi.SelectedIndex;
            ceni.SelectedIndex = naslovi.SelectedIndex; ; //sto ke selektirame vo naslovi i vo cenata ke se selktira paralelno

            if(ViewState["total_changes"] != null)
            {
                ViewState["total_changes"] = Convert.ToInt32(ViewState["total_changes"]) ;
                
            }
            else
            {
                ViewState["total_changes"] = 1; 
            }

            total.Text = ((int)ViewState["total_changes"]).ToString();
        }

        protected void dodadi_Click(object sender, EventArgs e)
        {
            if (naslovi.SelectedItem != null && ceni.SelectedItem != null)
            {
                ArrayList lista;

                if (Session["card"] == null)
                {
                    lista = new ArrayList();
                }
                else
                {
                    lista = (ArrayList)Session["card"];
                }

                lista.Add(new ListItem(naslovi.SelectedItem.Text, ceni.SelectedItem.Text));

                koshnichka.DataSource = lista;

                koshnichka.DataTextField = "Text";
                koshnichka.DataValueField = "Value";

                koshnichka.DataBind();

                Session["kosnichka"] = lista;
            }
        }
    }
}