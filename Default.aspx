<%@ Page Title="" Language="C#" MasterPageFile="~/Master.master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CrawleyJ_Prog4.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
   <asp:GridView ID="ProductGrid" runat="server" AutoGenerateColumns="False" CssClass="auto-style22" style="margin-left:25%; align-items: center; ">
   <Columns>
      <asp:BoundField DataField="ProductID" HeaderText="Product ID">
      <ItemStyle HorizontalAlign="Center" Width="10%" />
      </asp:BoundField>
      <asp:BoundField DataField="ProductName" HeaderText="Product Name">
      <ItemStyle HorizontalAlign="Left" Width="20%" />
      </asp:BoundField>
      <asp:BoundField DataField="UnitPrice" DataFormatString="{0:c}" HeaderText="Unit Price" HtmlEncode="False">
      <ItemStyle HorizontalAlign="Right" Width="10%" />
      </asp:BoundField>
      <asp:BoundField DataField="Description" HeaderText="Description">
      <ItemStyle HorizontalAlign="right" Width="10%" />
      </asp:BoundField>
   </Columns>
</asp:GridView>
</asp:Content>
