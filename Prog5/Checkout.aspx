<%@ Page Title="" Language="C#" MasterPageFile="~/Prog5/Prog5_Master.master" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="CrawleyJ_Prog5.Prog5.Checkout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
   <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ShoppingBagConnectionString %>" SelectCommand="SELECT * FROM [ShoppingBag]"></asp:SqlDataSource>
   <asp:GridView class="OutputTable" ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ProductID" DataSourceID="SqlDataSource1">
      <Columns>
         <asp:BoundField DataField="ProductID" HeaderText="ProductID" ReadOnly="True" SortExpression="ProductID" />
         <asp:BoundField DataField="ProductName" HeaderText="ProductName" SortExpression="ProductName" />
         <asp:BoundField DataField="UnitPrice" HeaderText="UnitPrice" SortExpression="UnitPrice" />
         <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
         <asp:BoundField DataField="Cost" HeaderText="Cost" SortExpression="Cost" />
      </Columns>
   </asp:GridView>
   <div style="margin-left: 560px">
      <asp:Button ID="Button1" runat="server" CssClass="Compute" OnClick="Button1_Click" Text="Button" />
   </div>
</asp:Content>
