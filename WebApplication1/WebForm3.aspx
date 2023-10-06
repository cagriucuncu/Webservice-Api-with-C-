<%@ Page Language="C#" Async="true" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication1.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
     <title>Veri Çekme Örneği</title> 
    <script src="https://ajax.aspnetcdn.com/ajax/jQuery/jquery-3.2.1.min.js"></script>  

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="true"></asp:GridView>
        </div>
   
   <script type="text/javascript">  
       $(document).ready(function () {
           $.ajax({
               type: "POST",
               url: "WebService1.asmx/HelloWorld",
               data: "{'myUserName':'MyUserNameIsRaj'}",
               contentType: "application/json",
               datatype: "json",
               success: function (responseFromServer) {
                   alert(responseFromServer.d)
               }
           });
       });
   </script>  
        <asp:Label ID="lblMessage" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>