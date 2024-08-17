<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    

    <div class="row mt=3">

        <asp:ListBox ID="Destinations" runat="server">
            <asp:ListItem Value="200">Bitola</asp:ListItem>
            <asp:ListItem Value="300">Skopje</asp:ListItem>
            <asp:ListItem Value="120">Strumica</asp:ListItem>
            <asp:ListItem Value="150">Veles</asp:ListItem>
        </asp:ListBox>

    </div>

    <div class="row mt=5">

        <asp:Button ID="SubmitDestination" runat="server" Text="Zacuvaj" OnClick="submitedDestination" />

    </div>

    <div class="row mt-5">
        <asp:Label ID="SelectedDestination" runat="server" Text=""></asp:Label>
    </div>

</asp:Content>
