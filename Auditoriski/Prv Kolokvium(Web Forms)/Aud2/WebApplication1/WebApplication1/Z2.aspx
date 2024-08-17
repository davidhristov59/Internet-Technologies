<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Z2.aspx.cs" Inherits="WebApplication1.Z2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">

        <div class="row mt-3">

            <asp:DropDownList ID="gradovi" runat="server" Width="300">
                <asp:ListItem>(grad)</asp:ListItem>
                <asp:ListItem>Ohrid</asp:ListItem>
                <asp:ListItem>Skopje</asp:ListItem>
                <asp:ListItem>Bitola</asp:ListItem>
            </asp:DropDownList>

            <div class="row mt-3">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Morate da selektirate grad!" ControlToValidate="gradovi" InitialValue="(grad)"></asp:RequiredFieldValidator>
            </div>

        </div>

        <div class="row mt-3">
            <asp:Button ID="registerButton" runat="server" Text="Registriraj se!" OnClick="registerButton_Click" Height="30" Width="150" />
        </div>

        <div>
            <asp:Label ID="selectedCity" runat="server" Text="Selektiraniot grad e: " EnableViewState="False"></asp:Label>
            <!--stavam enableviewsate=false za koga ke selektiram grad da otide vo labelata i posle drug koga ke selektiram da ne otide do nego nego da se izbrise stariot i se taka-->
                <!--kratko kazano da gi izbrisam prethodnite vrednosti-->
        </div>


    </div>

</asp:Content>
