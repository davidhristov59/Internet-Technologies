using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitedDestination(object sender, EventArgs e)
        {
            
            var selectedItem = Destinations.SelectedItem;
            
            if (selectedItem != null) {
                SelectedDestination.Text = "Selektiranata destinacija e: " + selectedItem.Text + " i rastojanieto do Skopje e " + selectedItem.Value + " km ";
            }
            else
            {
                SelectedDestination.Text = "Nemate selektirano destinacija";
            }
            

            //poveke ako sakame da selektirame odednas
            /*
            var listItems = Destinations.Items;

            foreach (ListItem item in listItems)
            {
                if (item.Selected)
                {
                    SelectedDestination.Text += item.Text + "<br/>";
                }
            }
            */

        }
    }
}