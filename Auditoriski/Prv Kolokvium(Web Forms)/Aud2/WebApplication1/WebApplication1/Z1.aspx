<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Z1.aspx.cs" Inherits="WebApplication1.Z1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">

        <div class="row">

            Vnesi e-mail:
            <asp:TextBox ID="email" runat="server"></asp:TextBox>
            
            <div class="row mt-3">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Poleto e zadolzitelno" ControlToValidate="email"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="E-mailot e vnesen vo pogresen format" ControlToValidate="email" ValidationExpression="\S+@\w+\.\w+"></asp:RegularExpressionValidator>
            </div>

        </div>

        <div class="row">

            Vnesi password:
            <asp:TextBox ID="lozinka" runat="server" TextMode="Password"></asp:TextBox>

            <div class="row mt-3">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Morate da vnesete lozinka" ControlToValidate="lozinka"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Lozinkata e kratka!" ControlToValidate="lozinka" ValidationExpression=^.{5,}$></asp:RegularExpressionValidator>
                <!-- "^{5,10}"-->
            </div>

        </div>

        <div class="row">

            Potvrdi ja svojata lozinka:
            <asp:TextBox ID="potvrdilozinka" runat="server" TextMode="Password"></asp:TextBox>

            <div class="row mt-3">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Morate da vnesete lozinka" ControlToValidate="potvrdilozinka"></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Lozinkite mora da se sovpagaat" ControlToCompare="lozinka" ControlToValidate="potvrdilozinka"></asp:CompareValidator>
            </div>

        </div>

        <div class="row">
            <asp:Button ID="register" runat="server" Text="Register" OnClick="register_Click" />
        </div>

        <div class="row">
            <asp:Label ID="labela" runat="server" Text=""></asp:Label>
        </div>

    </div>

</asp:Content>
