<%@ Page Title="" Language="C#" MasterPageFile="~/Prog6/Prog6MasterPage.Master" AutoEventWireup="true" CodeBehind="SetRoles.aspx.cs" Inherits="CrawleyJ_Prog5.Prog6.Admin.SetRoles" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table class="OutputTable">
        <tr>
            <td class="auto-style25">
                <asp:Label ID="Idlbl" runat="server" Text="User Name"></asp:Label>
            </td>
            <td class="auto-style24">
                <asp:Label ID="Namelbl" runat="server" Text="Email"></asp:Label>
            </td>
            <td class="auto-style26">
                <asp:Label ID="Pricelbl" runat="server" Text="Role"></asp:Label>
            </td>
            <td class="auto-style23" style="width: 128px">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style27">
                <asp:TextBox ID="Usertxt" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style28">
                <asp:TextBox ID="Emailtxt" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style29">
                <asp:TextBox ID="Roletxt" runat="server" Height="16px" Width="140px"></asp:TextBox>
            </td>
            <td class="auto-style30" style="width: 128px">&nbsp;</td>
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
            <td class="auto-style24">&nbsp;</td>
            <td class="auto-style26">&nbsp;</td>
            <td class="auto-style23" style="width: 128px">
                <asp:TextBox ID="txtMessage" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
    </table>

</asp:Content>
