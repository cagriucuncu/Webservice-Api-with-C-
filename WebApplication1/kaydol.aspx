<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="kaydol.aspx.cs" Inherits="WebApplication1.kaydol" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style>
   
         .butonreg {
             margin-left:87px;
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
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" style="margin-left:15px;"  Text="Register Page"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" style="margin-left:20px;" Text="Name"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="nametxt" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" style="margin-left:15px;" Text="Surname"></asp:Label>
        &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="surnametxt" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" style="margin-left:15px;" Text="Username"></asp:Label>
        &nbsp;
        <asp:TextBox ID="usertxt" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" style="margin-left:15px;" Text="E-mail"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="mailtxt" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" style="margin-left:15px;" Text="Password"></asp:Label>
        &nbsp;
        <asp:TextBox ID="passtxt" runat="server"></asp:TextBox>
        <br />
        <br />

      
        <div id="addressContainer">
            <asp:Label ID="Label7" runat="server" style="margin-left:15px;" Text="Address"></asp:Label>
            &nbsp;
            <asp:TextBox ID="addresstxt" runat="server"></asp:TextBox>
            <br />
        </div>
        <br />
        <asp:Button ID="butonregister" runat="server" OnClick="butonregister_Click" Text="Register" CssClass="butonreg" />

        
        <input type="button" value="Add Address"  onclick="addAddressField()" class="ozel-buton"/>
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
</asp:Content>
