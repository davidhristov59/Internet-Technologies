<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Z4.aspx.cs" Inherits="WebApplication1.Z4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">

        <div>
            Telefonski broj:
            <asp:TextBox ID="broj" runat="server"></asp:TextBox>


            <div>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Morate da vnesete broj!" ControlToValidate="broj"></asp:RequiredFieldValidator>
                <!--<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Pogresen format na broj vnesovte!" ControlToValidate="broj" ValidationExpression="\+389 7[0125678] \d{3} \d{3}"></asp:RegularExpressionValidator>--> <!-- +389 70 340 505 -->
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Gresen format" ControlToValidate="broj" ValidationExpression="07[0125678]\-[0-9]{3}\-[0-9]{3}"></asp:RegularExpressionValidator> <!-- 070-340-505-->
            </div>
        </div>

        <div>
            <asp:Label ID="labela" runat="server" Text=""></asp:Label>
        </div>

        <div>
            <asp:Button ID="kopce" runat="server" Text="Validiraj!" OnClick="kopce_Click" />
        </div>

    </div>


</asp:Content>
