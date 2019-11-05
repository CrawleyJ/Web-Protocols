<%@ Page Title="" Language="C#" MasterPageFile="~/Main/MainMaster.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CrawleyJ_Prog5.Main.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   <style type="text/css">
      .auto-style22 {
         width: 598px;
      }
      .auto-style23 {
         width: 300px;
      }
   </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table class="OutputTable" style="width:100%;">
   <tr>
      <td class="auto-style23">
         <asp:Label ID="lblUser" runat="server" Text="Username"></asp:Label>
      </td>
      <td class="auto-style22">
         <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
      </td>
      <td class="auto-style22">
         <asp:RequiredFieldValidator ID="rfvUser" runat="server" ControlToValidate="txtUser" ErrorMessage="Please enter a User name!" Font-Size="Smaller" ForeColor="Red"></asp:RequiredFieldValidator>
      </td>
   </tr>
      <tr>
      <td class="auto-style23">
         <asp:Label ID="lblPass" runat="server" Text="Password"></asp:Label>
      </td>
      <td class="auto-style22">
         <asp:TextBox ID="txtPass" runat="server"></asp:TextBox>
      </td>
      <td class="auto-style22">
         <asp:RequiredFieldValidator ID="rfvUser0" runat="server" ControlToValidate="txtPass" ErrorMessage="Please enter a User name!" Font-Size="Smaller" ForeColor="Red"></asp:RequiredFieldValidator>
      </td>
      </tr>
   <tr>
      <td class="auto-style23">
         <asp:LinkButton ID="lbRegister" runat="server" OnClick="LinkButton1_Click" PostBackUrl="~/Main/CreateUser.aspx">Register</asp:LinkButton>
      </td>
      <td class="auto-style22">
         <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
      </td>
      <td class="auto-style22">
         &nbsp;</td>
   </tr>
   </table>
</asp:Content>
