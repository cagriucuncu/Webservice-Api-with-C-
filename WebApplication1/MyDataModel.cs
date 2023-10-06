using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Barkodlar
    {
        public string Barkodu { get; set; }
        public string Birim { get; set; }
        public double Fiyat { get; set; }
    }
    public class MyDataModel
    {
        public int ID { get; set; }
        public string UrunKodu { get; set; }
        public string UrunAdi { get; set; }
        public double KDVOrani { get; set; }
        public double IndirimliTutar { get; set; }
        public double Tutar { get; set; }
        public double Envanter { get; set; }
        public string UreticiFirmaAdi { get; set; }
        public double n11 { get; set; }
        public double ggidiyor { get; set; }
        public double getir { get; set; }
        public double trendyol_marketplace { get; set; }
        public double hepsiburada { get; set; }
        public double trendyol { get; set; }
        public double amazon { get; set; }
        public double eptt { get; set; }
        public DateTime GuncellemeTarihi { get; set; }
        public string UrunAciklamasi { get; set; }
        public List<string> Resimler { get; set; }
        public List<Barkodlar> Barkodlar { get; set; }
        public List<object> Gruplar { get; set; }
        public string Kategori { get; set; }
        public bool EticaretteGoruntulensin { get; set; }
    }



    
}