<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Z5.aspx.cs" Inherits="WebApplication1.Z5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

 <div class="container">

     <div>
         <asp:ValidationSummary class="danger" ID="ValidationSummary1" runat="server" />
         <!--gi stavam na display:none site validatori i im stavam ista klasa-->
     </div>

     <div>
         Ime na ispitot:
         <asp:TextBox ID="ime" runat="server"></asp:TextBox>

         <div>
             <asp:RequiredFieldValidator class="danger" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Mora da vnesete ime na ispitot!" ControlToValidate="ime" InitialValue="ispit" Display="None"></asp:RequiredFieldValidator>
         </div>
     </div>

     <div>
         Ocenata:
         <asp:TextBox ID="ocena" runat="server"></asp:TextBox>

         <div>
             <asp:RequiredFieldValidator class="danger" ID="RequiredFieldValidator2" runat="server" ErrorMessage="Mora da vnesete validna ocenka" ControlToValidate="ocena" InitialValue="ocena" Display="None"></asp:RequiredFieldValidator>
             <asp:RangeValidator class="danger" ID="RangeValidator1" runat="server" ErrorMessage="Ocenkata e vo gresen opseg" ControlToValidate="ocena" MaximumValue="10" MinimumValue="5" Type="Integer" Display="None"></asp:RangeValidator>
         </div>

     </div>

     <div>
         Datumot na polaganje: 
         <asp:TextBox ID="datum" runat="server"></asp:TextBox>

         <div>
             <asp:RequiredFieldValidator class="danger" ID="RequiredFieldValidator3" runat="server" ErrorMessage="Mora da vnesete validen datum" ControlToValidate="datum" InitialValue="datum" Display="None"></asp:RequiredFieldValidator>
             <asp:CompareValidator class="danger" ID="CompareValidator1" runat="server" ErrorMessage="Gresen datum!" ControlToValidate="datum" Operator="LessThanEqual" ValueToCompare="05-04-2024" Display="None"></asp:CompareValidator>
         </div>

     </div>

     <div>
         <asp:Button ID="Button1" runat="server" Text="Validiraj" OnClick="Button1_Click" />
     </div>

     <div>
         <asp:Label ID="labela" runat="server" Text=" "></asp:Label>
     </div>

 </div>

</asp:Content>
