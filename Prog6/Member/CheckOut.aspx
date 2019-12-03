<%@ Page Title="" Language="C#" MasterPageFile="~/Prog6/Prog6MasterPage.master" AutoEventWireup="true" CodeBehind="CheckOut.aspx.cs" Inherits="Program6.Prog6.Member.CheckOut" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ShoppingBagConnectionString %>" SelectCommand="SELECT * FROM [ShoppingBag]"></asp:SqlDataSource>
   <asp:GridView ID="OutputTable" class="OutputTable" runat="server" AutoGenerateColumns="False" DataKeyNames="ProductID" DataSourceID="SqlDataSource1">
      <Columns>
         <asp:BoundField DataField="ProductID" HeaderText="ProductID" ReadOnly="True" SortExpression="ProductID" />
         <asp:BoundField DataField="ProductName" HeaderText="ProductName" SortExpression="ProductName" />
         <asp:BoundField DataField="UnitPrice" HeaderText="UnitPrice" SortExpression="UnitPrice" />
         <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
         <asp:BoundField DataField="Cost" HeaderText="Cost" SortExpression="Cost" />
      </Columns>
   </asp:GridView>
   <asp:Button ID="btnCheckout" runat="server" OnClick="btnCompute_Click" Text="Check out" />
    <asp:TextBox ID="totaltxt" runat="server"></asp:TextBox>
    <asp:Label ID="Label1" runat="server" Text="Total Cost"></asp:Label>
</asp:Content>