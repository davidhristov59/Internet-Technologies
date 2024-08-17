<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Katalog.aspx.cs" Inherits="WebApplication1.Z1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <!--QueryString - prenos na podatoci pomegju 2 strani. GET REQUEST do nasiot server url/ ? - so ? se oznacuva -->

    <div class="container">

        <div class="col-md-14 text-center">
            <p>Категории</p>
        </div>

        <div class="col-md-8 text-center">
            <asp:LinkButton ID="link1" runat="server" OnClick="link1_Click">Стручна литература</asp:LinkButton> <br />
            <asp:LinkButton ID="link2" runat="server" OnClick="link2_Click">Белетристика</asp:LinkButton> <br />
            <asp:LinkButton ID="link3" runat="server" OnClick="link3_Click">Магазин</asp:LinkButton> <br />

        </div>

    </div>

</asp:Content>
