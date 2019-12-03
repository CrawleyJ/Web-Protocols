<%@ Page Title="" Language="C#" MasterPageFile="~/Prog7/Prog7MasterPage.master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Program6.Prog7.Default" %>


<%@ Register src="ShoppingItem.ascx" tagname="ShoppingItem" tagprefix="uc1" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
  
    
    <uc1:ShoppingItem ID="ShoppingItem1" runat="server" />
    
  
    
</asp:Content>