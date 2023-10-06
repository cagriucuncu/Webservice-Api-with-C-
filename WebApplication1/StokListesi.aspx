<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="StokListesi.aspx.cs" Inherits="WebApplication1.StokListesi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.5.2/css/bootstrap.min.css">
    <link rel="stylesheet" href="https://cdn.datatables.net/1.13.5/css/dataTables.bootstrap4.min.css">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table id="depoTable" class="table table-striped table-bordered">
            <thead>
      <tr>
        <th>ID</th>
        <th>UrunKodu</th>
        <th>UrunAdi</th>
        <th>KDVOrani</th>
        <th>IndirimliTutar</th>
        <th>Tutar</th>
        <th>Envanter</th>
        <th>UreticiFirmaAdi</th>
        <th>n11</th>
        <th>ggidiyor</th>
        <th>getir</th>
        <th>trendyol_marketplace</th>
        <th>hepsiburada</th>
        <th>trendyol</th>
        <th>amazon</th>
        <th>eptt</th>
        <th>GuncellemeTarihi</th>
        <th>UrunAciklamasi</th>
        <th>Resimler</th>
        <th>Barkodlar</th>
        <th>Gruplar</th>
        <th>Kategori</th>
        <th>EticaretteGoruntulensin</th>
      </tr>
    </thead>
            <tbody>
         
            </tbody>
        </table>
     <style>
        
    #lblMessage {
        font-weight: bold;
        color:  #f44336;
        
    }

         .logout {
           background-color: #f44336; 
  border: none;
  color: white;
  padding: 5px;
  text-align: center;
  text-decoration: none;
  display: inline-block;
  font-size: 15px;
  border-radius: 5px;
  
}

</style>
        <script src="https://code.jquery.com/jquery-3.7.0.js"></script>
        <script src="https://cdn.datatables.net/1.13.5/js/jquery.dataTables.min.js"></script>
        <script src="https://cdn.datatables.net/1.13.5/js/dataTables.bootstrap4.min.js"></script>
         <script>
             function getDepoListesi() {
                 $.ajax({
                     type: "POST",
                     url: "WebService1.asmx/GetDepoListesi",
                     dataType: "xml",
                     success: function (response) {
                         // Parse the XML response to JSON
                         var jsonString = $(response).find("string").text();
                         var jsonData = JSON.parse(jsonString);

                         // Initialize DataTable with the 'columns' option
                         $('#depoTable').DataTable({
                             
                             data: jsonData,
                             columns: [
                                 { data: 'ID' },
                                 { data: 'UrunKodu' },
                                 { data: 'UrunAdi' },
                                 { data: 'KDVOrani' },
                                 { data: 'IndirimliTutar' },
                                 { data: 'Tutar' },
                                 { data: 'Envanter' },
                                 { data: 'UreticiFirmaAdi' },
                                 { data: 'n11' },
                                 { data: 'ggidiyor' },
                                 { data: 'getir' },
                                 { data: 'trendyol_marketplace' },
                                 { data: 'hepsiburada' },
                                 { data: 'trendyol' },
                                 { data: 'amazon' },
                                 { data: 'eptt' },
                                 { data: 'GuncellemeTarihi' },
                                 { data: 'UrunAciklamasi' },
                                 {
                                     data: 'Resimler',
                                     render: function (data) {
                                         var imagesHtml = '';
                                         imagesHtml = '<img src="' + data + '" alt="Product Image" width="100">';
                                         return imagesHtml;
                                     }
                                 },
                                 {
                                     data: 'Barkodlar',
                                     render: function (data) {
                                         var barkodHtml = '';
                                         if (data && data.length > 0) {
                                             data.forEach(function (barkod) {
                                                 barkodHtml = '<p>Barkodu: ' + barkod.Barkodu + ', Birim: ' + barkod.Birim + ', Fiyat: ' + barkod.Fiyat + '</p>';
                                             });
                                         }
                                         return barkodHtml;
                                     }
                                 },
                                 {
                                     data: 'Gruplar',

                                 },
                                 { data: 'Kategori' },
                                 {
                                     data: 'EticaretteGoruntulensin',
                                     
                                 }
                             ]
                         });
                     
                     },
                     error: function (xhr, status, error) {
                         console.error(error);
                     }
                 });
             }

             $(document).ready(function () {
                 getDepoListesi();
             });
         </script>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <asp:Button ID="logout" runat="server" OnClick="logout_Click"  Text="Çıkış yap" CssClass="logout"  />
</asp:Content>
