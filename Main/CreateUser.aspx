<%@ Page Title="" Language="C#" MasterPageFile="~/Main/MainMaster.Master" AutoEventWireup="true" CodeBehind="CreateUser.aspx.cs" Inherits="Program6.Main.CreateUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
   <tr>
      <td>
         <asp:Label ID="Label2" runat="server" Text="UserName:"></asp:Label>
      </td>
      <td>
         <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
      </td>
      <td>
         <asp:RequiredFieldValidator ID="rfvUser" runat="server" ControlToValidate="txtUser" ErrorMessage="Please enter a User name!" Font-Bold="True" Font-Size="Smaller" ForeColor="Red"></asp:RequiredFieldValidator>
      </td>
   </tr>
   <tr>
      <td>
         <asp:Label ID="Label3" runat="server" Text="Password:"></asp:Label>
      </td>
      <td>
         <asp:TextBox ID="txtPass" runat="server"></asp:TextBox>
      </td>
      <td>
         <asp:RequiredFieldValidator ID="rfvPass" runat="server" ControlToValidate="txtPass" ErrorMessage="Please enter a Password!" Font-Bold="True" Font-Size="Smaller" ForeColor="Red"></asp:RequiredFieldValidator>
      </td>
   </tr>
   <tr>
      <td>
         <asp:Label ID="lblCnfrm" runat="server" Text="Confirm Password:"></asp:Label>
      </td>
      <td>
         <asp:TextBox ID="txtcnfrm" runat="server"></asp:TextBox>
      </td>
      <td>
         <asp:RequiredFieldValidator ID="rfvCnfrm" runat="server" ControlToValidate="txtcnfrm" ErrorMessage="Please enter a confirmation Password!" Font-Bold="True" Font-Size="Smaller" ForeColor="Red"></asp:RequiredFieldValidator>
         <asp:CompareValidator ID="cvCnfrm" runat="server" ControlToCompare="txtPass" ControlToValidate="txtcnfrm" ErrorMessage="Please enter the same password:" Font-Overline="False" Font-Size="Smaller" ForeColor="Red"></asp:CompareValidator>
      </td>
   </tr>
   <tr>
      <td>
         <asp:Label ID="Label4" runat="server" Text="Email:"></asp:Label>
      </td>
      <td>
         <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
      </td>
      <td>
         <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="Please enter a email address!" Font-Bold="True" Font-Size="Smaller" ForeColor="Red"></asp:RequiredFieldValidator>
      </td>
   </tr>
   <tr>
      <td>
         <asp:Label ID="Label5" runat="server" Text="Favorite Product:"></asp:Label>
      </td>
      <td>
         <asp:TextBox ID="txtFav" runat="server"></asp:TextBox>
      </td>
      <td>
         <asp:RequiredFieldValidator ID="rfvFav" runat="server" ControlToValidate="txtFav" ErrorMessage="Please enter a Favorite product!" Font-Bold="True" Font-Size="Smaller" ForeColor="Red"></asp:RequiredFieldValidator>
      </td>
   </tr>
   <tr>
      <td>&nbsp;</td>
      <td>
         <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
      </td>
      <td>&nbsp;</td>
   </tr>
</table>
</asp:Content>
