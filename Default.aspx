<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CrawleyJ_Prog3.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <asp:GridView ID="ProductGrid" runat="server" AutoGenerateColumns="False" style="z-index: 1; position: relative; width: 50%; margin-left:25%; align-items: center; height: 176px" >
      <Columns>
         <asp:BoundField DataField="ProductID" HeaderText="Product ID" >
            <ItemStyle HorizontalAlign="Center"  Width="10%"></ItemStyle>

         </asp:BoundField><asp:BoundField DataField="ProductName" HeaderText="Product Name" >
            <ItemStyle HorizontalAlign="Left" Width="20%"></ItemStyle></asp:BoundField>
         <asp:BoundField DataField="UnitPrice" HeaderText="Unit Price" DataFormatString="{0:c}" HtmlEncode="False" >
            <ItemStyle HorizontalAlign="Right" Width="10%"></ItemStyle></asp:BoundField>
         <asp:BoundField DataField="Description" HeaderText="Description">
            <ItemStyle HorizontalAlign="right" Width="10%"></ItemStyle></asp:BoundField>

      </Columns>
</asp:GridView>
</asp:Content>
