<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
     <style>
     body {
    background-color: #d0d6e0;
    height: 100vh;
    display: flex;
    justify-content: center;
    align-items: center;
}

.my-button {
    background-color: #4CAF50;
    color: white;
  
    border: none;
    border-radius: 5px;
    cursor: pointer;
    font-size: 16px;
     width:70%;
    height:30px;
    text-align: center;
    margin-left:80px;
   
    justify-content: center; 
    font-size: 14px;
}
        .my-button:hover {
            background-color: #45a049; 
        }
    </style>
    
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
       
        <asp:Label ID="Label1" runat="server" style="margin-left: 50%;" Text="Login Page"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Username"></asp:Label>

        <asp:TextBox ID="usertxt" runat="server" OnTextChanged="TextBox1_TextChanged" style="margin-left: 15px; margin-top: 0px; margin-bottom: 0px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="password "></asp:Label>

        <asp:TextBox ID="passtxt" runat="server" OnTextChanged="TextBox1_TextChanged" style="margin-left: 15px; margin-top: 0px; margin-bottom: 0px" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" CssClass="my-button" />
                <br />
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" style="margin-left: 80px;" NavigateUrl="~/registerpage.aspx">dont have account register </asp:HyperLink>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
        <br />
        <br />
    </form>
</body>
</html>
