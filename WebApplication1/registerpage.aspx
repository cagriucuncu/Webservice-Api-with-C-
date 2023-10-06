<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registerpage.aspx.cs" Inherits="WebApplication1.registerpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
     <style>
     body {
    background-color: #d0d6e0;
    height: 100vh;
    display: flex;
    justify-content: center;
    align-items: center;
}
         .butonreg {
             margin-left:65px;
    background-color:#008CBA; 
  color: #F0F8FF;
  font-size: 14px;
  padding: 7px;
  border: none;
  border-radius: 5px;
  cursor: pointer;
}
         .ozel-buton {
             cursor: pointer;
  background-color:#FF8C00;
  color: #F0F8FF;
  font-size: 14px;
  padding: 7px;
  border: none;
  border-radius: 5px;
  margin-left:5px;
}






  
        .butonreg:hover {
            background-color: #45a049; 
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="Register Page"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="nametxt" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Surname"></asp:Label>
        &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="surnametxt" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Username"></asp:Label>
        &nbsp;
        <asp:TextBox ID="usertxt" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="E-mail"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="mailtxt" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Password"></asp:Label>
        &nbsp;
        <asp:TextBox ID="passtxt" runat="server"></asp:TextBox>
        <br />
        <br />

      
        <div id="addressContainer">
            <asp:Label ID="Label7" runat="server" Text="Address"></asp:Label>
            &nbsp;
            <asp:TextBox ID="addresstxt" runat="server"></asp:TextBox>
            <br />
        </div>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Register" CssClass="butonreg" />

        
        <input type="button" value="Add Address" onclick="addAddressField()" class="ozel-buton"/>
        <br />
        <br />

        <script>
            function addAddressField() {
                var container = document.getElementById("addressContainer");
                var newAddressField = document.createElement("input");
                newAddressField.type = "text";
                newAddressField.name = "address[]"; 
                container.appendChild(newAddressField);
                container.appendChild(document.createElement("br"));
            }
        </script>
        <asp:Label ID="lblMessage" runat="server"></asp:Label>
        &nbsp;<br />
        <br />
        <br />
    </form>
</body>
</html>