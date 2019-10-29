<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Shopping.aspx.cs" Inherits="CrawleyJ_Prog3.Shopping" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
 
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div>
      <link href="StyleSheet.css" rel="stylesheet"  type="text/css" />
      <table class="inputTable">
         <tr>
            <td class="auto-style15">
               <asp:Label ID="IDlbl" runat="server" Text="Enter ID:"></asp:Label>
            </td>
            <td class="auto-style15">
               <asp:Label ID="Namelbl" runat="server" Text="Name:"></asp:Label>
            </td>
            <td class="auto-style12">
               <asp:Label ID="Quantitylbl" runat="server" Text="Enter Quantity:"></asp:Label>
            </td>
         </tr>
         <tr>
            <td class="auto-style16">
               <asp:TextBox ID="IDtxt" runat="server" OnTextChanged="IDtxt_TextChanged"></asp:TextBox>
            </td>
            <td class="auto-style16">
               <asp:TextBox ID="Nametxt" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
            <td class="auto-style17">
               <asp:TextBox ID="Quantitytxt" runat="server"></asp:TextBox>
            </td>
         </tr>
         <tr>
            <td class="auto-style20">
               <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="IDtxt" ErrorMessage="ID cannot be empty!" Font-Size="Small" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td class="auto-style20">
               <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Nametxt" ErrorMessage="Name cannot be empty!" Font-Size="Small" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td class="auto-style21">
               <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="Quantitytxt" ErrorMessage="Quantity cannot be empty!" Font-Size="Small" ForeColor="Red"></asp:RequiredFieldValidator>
               <br />
               <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="Quantitytxt" ErrorMessage="Unit Quantity must be a positive number!" Font-Size="Small" ForeColor="Red" MaximumValue="100000" MinimumValue="0" Type="Integer">Quanitity must be a non-negative integer!</asp:RangeValidator>
            </td>
         </tr>
      </table>
   </div>
   <div>
      <table class="OutputTable">
         <tr>
            <td class="auto-style14">
               <asp:Label ID="Pricelbl" runat="server" Text="Price:"></asp:Label>
            </td>
            <td class="auto-style4">
               <asp:Label ID="sublbl" runat="server" Text="SubTotal"></asp:Label>
            </td>
            <td class="auto-style5">
               <asp:Label ID="Taxlbl" runat="server" Text="Tax"></asp:Label>
            </td>
            <td class="auto-style6">
               <asp:Label ID="GrandTotallbl" runat="server" Text="Grand Total"></asp:Label>
            </td>
         </tr>
         <tr>
            <td class="auto-style11">
               <asp:TextBox ID="Pricetxt" runat="server" CssClass="auto-style9"  ReadOnly="True"></asp:TextBox>
            </td>
            <td class="auto-style22">
               <asp:TextBox ID="SubTotaltxt0" runat="server"  ReadOnly="True"></asp:TextBox>
            </td>
            <td class="auto-style22">
               <asp:TextBox ID="SubTotaltxt" runat="server"  ReadOnly="True"></asp:TextBox>
            </td>
            <td class="auto-style22">
               <asp:TextBox ID="Taxtxt" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
         </tr>
         <tr>
            <td class="auto-style1">
               <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Pricetxt" ErrorMessage="Price cannot be empty!" Font-Size="Small" ForeColor="Red"></asp:RequiredFieldValidator>
               <br />
               <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="Pricetxt" ErrorMessage="Unit Price must be a positive number!" Font-Size="Small" ForeColor="Red" MaximumValue="100000" MinimumValue="0" Type="Double"></asp:RangeValidator>
            </td>
            <td class="auto-style1">
               <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
            </td>
            <td class="auto-style1">
               <asp:Button ID="btnCompute" runat="server" OnClick="btnCompute_Click" Text="Compute" />
            </td>
            <td class="auto-style1">
               <asp:Button ID="Resetbtn" runat="server" OnClick="Resetbtn_Click" Text="Reset" />
            </td>
         </tr>
      </table>
   </div>
</asp:Content>
