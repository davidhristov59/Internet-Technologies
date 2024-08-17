<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Z6.aspx.cs" Inherits="WebApplication1.Z6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">

        <div>
            Validiciona grupa 1
            <asp:TextBox ID="valgrupa1" runat="server" ValidationGroup="grupa1"></asp:TextBox>

            <div>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Mora da vnesete vo poleto!" ControlToValidate="valgrupa1" ValidationGroup="grupa1"></asp:RequiredFieldValidator>
            </div>

            <div>
                <asp:Button ID="valgrupa1Kopce" runat="server" Text="Grupa 1" ValidationGroup="grupa1" OnClick="valgrupa1Kopce_Click" />
            </div>

            <div>
                <asp:Label ID="labela1" runat="server" Text=""></asp:Label>
            </div>

        </div>

        <div>
        Validiciona grupa 2
        <asp:TextBox ID="valgrupa2" runat="server" ValidationGroup="grupa2"></asp:TextBox>

        <div>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Mora da vnesete vo poleto!" ControlToValidate="valgrupa2" ValidationGroup="grupa2"></asp:RequiredFieldValidator>
        </div>

        <div>
            <asp:Button ID="valgrupa2Kopce" runat="server" Text="Grupa 2" ValidationGroup="grupa2" OnClick="valgrupa2Kopce_Click" />
        </div>

            <div>
                <asp:Label ID="labela2" runat="server" Text=""></asp:Label>
            </div>

</div>


    </div>

</asp:Content>
