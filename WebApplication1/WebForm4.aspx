<%@ Page Language="C#"  AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="WebApplication1.WebForm4" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
      <meta charset="UTF-8">

    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.5.2/css/bootstrap.min.css">
    <link rel="stylesheet" href="https://cdn.datatables.net/1.13.5/css/dataTables.bootstrap4.min.css">
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
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
                        
                         var jsonString = $(response).find("string").text();
                         var jsonData = JSON.parse(jsonString);

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
                                        
                                                 barkodHtml = '<p>Barkodu: ' + data.Barkodu + ', Birim: ' + data.Birim + ', Fiyat: ' + data.Fiyat + '</p>';
                                             
                                         
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
        <asp:Button ID="logout" runat="server" OnClick="logout_Click" Text="Button" />
    </form>
</body>
</html>

