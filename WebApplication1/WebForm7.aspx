<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm7.aspx.cs" Inherits="WebApplication1.WebForm7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
      <style>
   .my-button {
    background-color: #4CAF50;
    color: white;
  
    border: none;
    border-radius: 5px;
    cursor: pointer;
    font-size: 16px;
     width:160px;
    height:20px;
    margin:5px;
    margin-left:45px;
    text-align: center;
    
    
    font-size: 14px;
}
        .my-button:hover {
            background-color: #45a049; 
        }
         </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Şifremi Unuttum<br />
    <br />
&nbsp;Mail&nbsp;
    <asp:TextBox ID="mailtxt" runat="server"></asp:TextBox>
&nbsp;
    <br />
    <asp:Button ID="resetbuton" runat="server" OnClick="resetbuton_Click" Text="resetle"  CssClass="my-button" />
</asp:Content>
