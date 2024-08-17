<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Najava.aspx.cs" Inherits="Lab1.Najava" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">

        <div>
            Ime:
            <asp:TextBox ID="ime" runat="server"></asp:TextBox>
            
            <div>
            <asp:RequiredFieldValidator 

                ID="RequiredFieldValidator2" runat="server" 
                ErrorMessage="Mora da vnesete ime" 
                ControlToValidate="ime" 
                Style="color: red">
                
            </asp:RequiredFieldValidator>
              </div>
              
        </div>

        <div>
            Lozinka:
         <asp:TextBox ID="lozinka" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator
                ID="RequiredFieldValidator1" 
                runat="server" 
                ErrorMessage="Mora lozinka da vnesete" 
                ControlToValidate="lozinka"
                Style="color: red">

            </asp:RequiredFieldValidator>
           
        </div>

        <div>
            E-adresa:
            <asp:TextBox ID="email" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator 
                ID="RequiredFieldValidator3" 
                runat="server" 
                ErrorMessage="Mora email da vnesete" 
                ControlToValidate="email">

            </asp:RequiredFieldValidator>

            <asp:RegularExpressionValidator 
                ID="RegularExpressionValidator1" 
                runat="server" 
                ErrorMessage="Pogresen format na meil" 
                ControlToValidate="email" 
                ValidationExpression="\S+@\w+\.\w+"
                Style="color: red">
         

            </asp:RegularExpressionValidator>
        </div>

        <div>
            <asp:Button ID="kopce" runat="server" Text="Najavete se" OnClick="kopce_Click" />
        </div>

    </div>

</asp:Content>
