<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Currencies.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   
    <div class="row mt-3">

       Ime na valuta:  <asp:TextBox ID="Name" runat="server"></asp:TextBox>

    </div>

     <div class="row mt-3">

         Vrednost vo denari: <asp:TextBox ID="DenarValue" runat="server"></asp:TextBox>

    </div>

     <div class="row mt-3">

         <asp:Button ID="SubmitButton" runat="server" Text="Zacuvaj" />

     </div>

     <div class="row mt-3">
          
        Site valuti: <br />
         <asp:RadioButtonList ID="Currencies" runat="server"></asp:RadioButtonList>

     </div>

</asp:Content>
