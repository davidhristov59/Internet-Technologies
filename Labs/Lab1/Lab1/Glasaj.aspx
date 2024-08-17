<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Glasaj.aspx.cs" Inherits="Lab1.Glasaj" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">

        <div>
            <asp:Label ID="labelaprofesor" runat="server" Text=""></asp:Label>
        </div>

        <div>
            <asp:ListBox ID="predmeti" runat="server" AutoPostBack="True" OnSelectedIndexChanged="predmeti_SelectedIndexChanged"></asp:ListBox>
            <asp:ListBox ID="krediti" runat="server" ></asp:ListBox>
        </div>

        <div>
            <asp:Button ID="kopceGlasaj" runat="server" Text="Glasaj" OnClick="kopce_Click" />
        </div>

        <hr />

        <div>
            Predmet:
            <asp:TextBox ID="predmet_text" runat="server"></asp:TextBox>
        </div>

        <div>
            Krediti:
            <asp:TextBox ID="krediti_text" runat="server"></asp:TextBox>
        </div>

        <div>
            <asp:Button ID="dodadiButton" runat="server" Text="Add" OnClick="dodadiButton_Click" />
        </div>

        <div>
            <asp:Button ID="izbrisiButton" runat="server" Text="Delete" OnClick="izbrisiButton_Click" />
          </div>

    </div>

</asp:Content>
