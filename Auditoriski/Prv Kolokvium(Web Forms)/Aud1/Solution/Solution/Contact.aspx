<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Solution.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <div class="row m-3">
       Ime na valuta: <asp:TextBox ID="Name" runat="server"></asp:TextBox>
    </div>

    <div class="row m-5">
       Vrednost vo denari: <asp:TextBox ID="DenarValue" runat="server"></asp:TextBox>
    </div>

    <div class="row m-5">
        <asp:Button ID="SubmitButton" runat="server" Text="Zacuvaj" OnClick="SubmitButton_Click" />
    </div>

    <div class="row m-5">
        Site valuti: </br>
        <asp:RadioButtonList ID="currencies" runat="server"></asp:RadioButtonList>

    </div> 

    <div class="row m-3">
        Vkupno valuti: <br />
        <asp:Label ID="currenciesCounter" runat="server" Text="Total"></asp:Label>
    </div>

    <div class="row mt-3">
        <asp:Button ID="deleteSelected" runat="server" Text="Remove" OnClick="deleteSelected_Click" />
    </div>

       

</asp:Content>
