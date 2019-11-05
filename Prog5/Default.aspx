<%@ Page Title="" Language="C#" MasterPageFile="~/Prog5/Prog5_Master.master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CrawleyJ_Prog5.Prog5.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
   <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ShoppingBagConnectionString %>" SelectCommand="SELECT [ProductID], [ProductName], [UnitPrice] FROM [Product]"></asp:SqlDataSource>
<asp:GridView class="OutputTable" ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ProductID" DataSourceID="SqlDataSource1" AllowPaging="True" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" PageSize="5">
   <AlternatingRowStyle BackColor="White" />
   <Columns>
      <asp:BoundField DataField="ProductID" HeaderText="ProductID" ReadOnly="True" SortExpression="ProductID" />
      <asp:BoundField DataField="ProductName" HeaderText="ProductName" SortExpression="ProductName" />
      <asp:BoundField DataField="UnitPrice" HeaderText="UnitPrice" SortExpression="UnitPrice" />
   </Columns>
   <FooterStyle BackColor="#CCCC99" />
   <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
   <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
   <RowStyle BackColor="#F7F7DE" />
   <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
   <SortedAscendingCellStyle BackColor="#FBFBF2" />
   <SortedAscendingHeaderStyle BackColor="#848384" />
   <SortedDescendingCellStyle BackColor="#EAEAD3" />
   <SortedDescendingHeaderStyle BackColor="#575357" />
</asp:GridView>
</asp:Content>
