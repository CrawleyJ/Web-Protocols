<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderingProduct.aspx.cs" Inherits="Prog2.OrderingProduct"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
   
<head runat="server">   
    <title>CS3870-Fall 2019-Program2</title>
    <link href="StyleSheet.css" rel="stylesheet"  type="text/css" />
    </head>
<body>
   <ul class="navigation">
      <li><a href="default.aspx">Default</a></li>
      <li><a href="OrderingProduct.aspx">Ordering Form</a></li>      
   </ul>
   <h1>Web Protocols, Technologies, and Applications</h1>
   <h2> By: Jamal Crawley</h2>
   <h3>CS 3870: Program 2</h3>   

   
    <form id="form1" runat="server">
        <div>
           <table class="inputTable">
              <tr>
                 <td class="auto-style15">
                    <asp:Label ID="IDlbl" runat="server" Text="Enter ID:"></asp:Label>
                 </td>
                 <td class="auto-style14">
                    <asp:Label ID="Pricelbl" runat="server" Text="Enter Price:"></asp:Label>
                 </td>
                 <td class="auto-style12">
                    <asp:Label ID="Quantitylbl" runat="server" Text="Enter Quantity:"></asp:Label>
                 </td>
              </tr>
              <tr>
                 <td class="auto-style16">
                    <asp:TextBox ID="IDtxt" runat="server" OnTextChanged="IDtxt_TextChanged"></asp:TextBox>
                 </td>
                 <td class="auto-style11">
                    <asp:TextBox ID="Pricetxt" runat="server" CssClass="auto-style9" OnTextChanged="Pricetxt_TextChanged"></asp:TextBox>
                 </td>
                 <td class="auto-style17">
                    <asp:TextBox ID="Quantitytxt" runat="server" OnTextChanged="Quantitytxt_TextChanged"></asp:TextBox>
                 </td>
              </tr>
              <tr>
                 <td class="auto-style20">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="IDtxt" ErrorMessage="ID cannot be empty!" Font-Size="Small" ForeColor="Red"></asp:RequiredFieldValidator>
                 </td>
                 <td class="auto-style19">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Pricetxt" ErrorMessage="Price cannot be empty!" Font-Size="Small" ForeColor="Red"></asp:RequiredFieldValidator>
                    <br />
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="Pricetxt" ErrorMessage="Unit Price must be a positive number!" Font-Size="Small" ForeColor="Red" MaximumValue="100000" MinimumValue="0" Type="Double"></asp:RangeValidator>
                 </td>
                 <td class="auto-style21">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Quantity cannot be empty!" ControlToValidate="Quantitytxt" Font-Size="Small" ForeColor="Red"></asp:RequiredFieldValidator>
                    <br />
                    <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="Quantitytxt" ErrorMessage="Unit Quantity must be a positive number!" Font-Size="Small" ForeColor="Red" MaximumValue="100000" MinimumValue="0" Type="Integer">Quanitity must be a non-negative integer!</asp:RangeValidator>
                 </td>
              </tr>
           </table>
        </div>
        <div>
           <table class="OutputTable">
              <tr>
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
                 <td class="Output">
                    <asp:TextBox ID="SubTotaltxt" runat="server" ReadOnly="True"></asp:TextBox>
                 </td>
                 <td class="auto-style5">
                    <asp:TextBox ID="Taxtxt" runat="server" ReadOnly="True"></asp:TextBox>
                 </td>
                 <td class="auto-style6">
                    <asp:TextBox ID="GrandTotaltxt" runat="server" ReadOnly="True"></asp:TextBox>
                 </td>
              </tr>
              <tr>                 
                 <td class="auto-style4">
                    <asp:Button ID="btnCompute" runat="server" Text="Compute" OnClick="btnCompute_Click" />
                 </td>
                 <td class="auto-style5">
                    <asp:Button ID="Resetbtn" runat="server" Text="Reset" OnClick="Resetbtn_Click" />
                 </td>
                 <td class="auto-style6">&nbsp;</td>
              </tr>
           </table>
        </div>
    </form>
</body>
</html>
