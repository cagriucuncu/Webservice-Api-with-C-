<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm6.aspx.cs" Inherits="WebApplication1.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
    <asp:Label ID="Label6" runat="server"></asp:Label>
    <asp:GridView ID="GridView2" runat="server" OnSelectedIndexChanged="GridView2_SelectedIndexChanged">
    </asp:GridView>
    <br />
&nbsp;<asp:Label ID="Label2" runat="server" Text="Username"></asp:Label>
&nbsp;&nbsp;
    <br />
    <asp:TextBox ID="usertxt" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
&nbsp;<asp:Label ID="Label3" runat="server" Text="Mail"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    <asp:TextBox ID="mailtxt" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
    <br />
&nbsp;<asp:Label ID="Label4" runat="server" Text="password"></asp:Label>
&nbsp;
    <br />
    <asp:TextBox ID="passtxt" runat="server" ValidateRequestMode="Disabled"></asp:TextBox>
    <br />
    <asp:Button ID="guncelle" runat="server" OnClick="guncelle_Click" Text="Güncelle" />
    <asp:Button ID="deletebuton" runat="server" OnClick="dellbuton_Click1" Text="  Sil  " />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Adress" OnClick="Buttonadres_Click" />
    <br />
    <br />
    <asp:Label ID="Label1" runat="server"></asp:Label>
    <p>
    </p>
</asp:Content>
