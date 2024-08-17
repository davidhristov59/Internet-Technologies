using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Solution
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //so dvoen klik se kreira nastan 

        protected void SubmitButton_Click(object sender, EventArgs e) //se kreira so klik na kopceto vo Split sto sakame da dodademe event
        {
            var name = Name.Text;
            var currencyValue = DenarValue.Text;
            
            if(!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(currencyValue)) //ako ne e prazen stringot
            {

                currencies.Items.Add(new ListItem(name,currencyValue)); //DINAMICKO KREIRANJE NA STAVKA SO new ListItem, dodadi vo novata listata
                Name.Text = ""; //od kogak e klikneme zacuvaj da se vrati na prazno     
                DenarValue.Text = "";

                //kako sto go dodavame ke go update-tirame i brojot
                currenciesCounter.Text = currencies.Items.Count.ToString(); //ke ni gi izbroi valutite i update-ne vo text-ot

            }
        }

        protected void deleteSelected_Click(object sender, EventArgs e)
        {
            var selectedItem = currencies.SelectedItem;

            if(selectedItem != null)
            {
                currencies.Items.Remove(selectedItem);

                currenciesCounter.Text = currencies.Items.Count.ToString();
            }
        }

        
    }
}