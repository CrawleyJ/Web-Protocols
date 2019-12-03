<%@ Page Title="" Language="C#" MasterPageFile="~/Prog7/Prog7MasterPage.master" AutoEventWireup="true" CodeBehind="Updating.aspx.cs" Inherits="Program6.Prog7.Admin.Updating" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table class="OutputTable">
      <tr>
         <td class="auto-style25">
            <asp:Label ID="Idlbl" runat="server" Text="ID"></asp:Label>
         </td>
         <td class="auto-style24">
            <asp:Label ID="Namelbl" runat="server" Text="Name"></asp:Label>
         </td>
         <td class="auto-style26">
            <asp:Label ID="Pricelbl" runat="server" Text="Price"></asp:Label>
         </td>
         <td class="auto-style23" style="width: 128px">
            <asp:Label ID="Desclbl" runat="server" Text="Description"></asp:Label>
         </td>
      </tr>
      <tr>
         <td class="auto-style27">
            <asp:TextBox ID="Idtxt" runat="server"></asp:TextBox>
         </td>
         <td class="auto-style28">
            <asp:TextBox ID="Nametxt" runat="server"></asp:TextBox>
         </td>
         <td class="auto-style29">
            <asp:TextBox ID="Pricetxt" runat="server" Height="16px" Width="140px"></asp:TextBox>
         </td>
         <td class="auto-style30" style="width: 128px">
            <asp:TextBox ID="Desctxt" runat="server"></asp:TextBox>
         </td>
      </tr>
      <tr>
         <td class="auto-style25">
            <asp:Button ID="btnFirst" runat="server" OnClick="btnFirst_Click" Text="First" />
         </td>
         <td class="auto-style24">
            <asp:Button ID="btnPrevious" runat="server" OnClick="btnPrevious_Click" Text="Previous" />
         </td>
         <td class="auto-style26">
            <asp:Button ID="btnNext" runat="server" OnClick="btnNext_Click" Text="Next" />
         </td>
         <td class="auto-style23" style="width: 128px">
            <asp:Button ID="btnLast" runat="server" OnClick="btnLast_Click" Text="Last" />
         </td>
      </tr>
      <tr>
         <td class="auto-style25">
            <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update" />
         </td>
         <td class="auto-style24">
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
         </td>
         <td class="auto-style26">
            <asp:Button ID="btnNew" runat="server" OnClick="btnNew_Click" Text="New" />
         </td>
         <td class="auto-style23" style="width: 128px">
            <asp:TextBox ID="txtMessage" runat="server" ReadOnly="True"></asp:TextBox>
         </td>
      </tr>
   </table>

</asp:Content>