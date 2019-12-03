<%@ Page Title="" Language="C#" MasterPageFile="~/Prog6/Prog6MasterPage.master" AutoEventWireup="true" CodeBehind="Shopping.aspx.cs" Inherits="Program6.Prog6.Member.Shopping" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    <table class="InputTable">
        <tr>
            <td class="auto-style15">
                <asp:Label ID="IDlbl" runat="server" Text="Enter ID:"></asp:Label>
            </td>
            <td class="auto-style15">
                <asp:Label ID="Namelbl" runat="server" Text="Name:"></asp:Label>
            </td>
            <td class="auto-style12" style="width: 617px">
                <asp:Label ID="Quantitylbl" runat="server" Text="Enter Quantity:"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style16" style="height: 29px">
                <asp:TextBox ID="IDtxt" runat="server" OnTextChanged="IDtxt_TextChanged"></asp:TextBox>
            </td>
            <td class="auto-style16" style="height: 29px">
                <asp:TextBox ID="Nametxt" runat="server" OnTextChanged="IDtxt_TextChanged" ReadOnly="True"></asp:TextBox>
            </td>
            <td class="auto-style17" style="height: 29px; width: 617px;">
                <asp:TextBox ID="Quantitytxt" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style20">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="IDtxt" ErrorMessage="ID cannot be empty!" Font-Size="Small" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td class="auto-style20">&nbsp;</td>
            <td class="auto-style21" style="width: 617px">
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
               <td class="auto-style23">
                   <asp:TextBox ID="Taxtxt" runat="server"  ReadOnly="True"></asp:TextBox>
               </td>
           </tr>
           <tr>
               <td class="auto-style1">
                   <asp:Button ID="btnAdd" runat="server" Text="Add" />
                   <br />
               </td>
               <td class="auto-style1">
                   <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click1" Text="Find" />
               </td>
               <td class="auto-style1">
                   <asp:Button ID="btnCompute" runat="server" OnClick="btnCompute_Click" Text="Compute" />
               </td>
               <td class="auto-style1">
                   <asp:Button ID="Resetbtn" runat="server" OnClick="Resetbtn_Click" Text="Reset" />
               </td>
           </tr>
       </table>
</asp:Content>