<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="girisyap.aspx.cs" Inherits="WebApplication1.girisyap" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style>
   .my-button {
    background-color: #4CAF50;
    color: white;
  
    border: none;
    border-radius: 5px;
    cursor: pointer;
    font-size: 16px;
     width:180px;
    height:30px;
    text-align: center;
    margin-left:100px;
   
    justify-content: center; 
    font-size: 14px;
}
        .my-button:hover {
            background-color: #45a049; 
        }
         </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
        <div>
        </div>
       
        <asp:Label ID="Label1" runat="server" style="margin-left:150px;" Text="Login Page"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" style="margin-left:15px;" Text="Username"></asp:Label>

        <asp:TextBox ID="usertxt" runat="server" OnTextChanged="TextBox1_TextChanged" style="margin-left: 15px; margin-top: 0px; margin-bottom: 0px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" style="margin-left:15px;" Text="password "></asp:Label>

        <asp:TextBox ID="passtxt" runat="server" OnTextChanged="TextBox1_TextChanged" style="margin-left: 15px; margin-top: 0px; margin-bottom: 0px" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Login" runat="server" Text="Login" OnClick="Login_Click" CssClass="my-button" />
                <br />
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" style="margin-left: 80px;" NavigateUrl="~/registerpage.aspx">dont have account register </asp:HyperLink>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
        <br />
        <br />
    
</asp:Content>
 

