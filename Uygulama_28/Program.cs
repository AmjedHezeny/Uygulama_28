using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uygulama_28;

namespace Uygulama_28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Ogrenci> ogrenciler = new List<Ogrenci>()
            {
                new Ogrenci()
                {
                    Ad = "Mustafa", Soyad = "Yüksel",
                    Notlar = new Not(){N1= 50, N2 = 60, F= 75}
                },
                new Ogrenci()
                {
                    Ad = "Ahmet Taha", Soyad = "Paçal",
                    Notlar = new Not(){N1= 40, N2 = 20, F= 55}
                },
                new Ogrenci()
                {
                    Ad = "Yiğithan", Soyad = "Çarkçı",
                    Notlar = new Not(){N1= 60, N2 = 55, F= 75}
                },
                new Ogrenci()
                {
                    Ad = "Selim", Soyad = "Ergin",
                    Notlar = new Not(){N1= 38, N2 = 72, F= 64}
                },
                new Ogrenci()
                {
                    Ad = "Umut", Soyad = "Karadaş",
                    Notlar = new Not(){N1= 35, N2 = 15,  F= 57}
                },
                new Ogrenci()
                {
                    Ad = "Ömer Rasim", Soyad = "Kınacı",
                    Notlar = new Not(){N1= 58, N2 = 65, F= 45}
                },
                new Ogrenci()
                {
                    Ad = "Oğuzhan", Soyad = "Öksüz",
                    Notlar = new Not(){N1= 35, N2 = 15, F= 57}
                },
                new Ogrenci()
                {
                    Ad = "Özge", Soyad = "Namlı",
                    Notlar = new Not(){N1= 58, N2 = 65, F= 79}
                },
                new Ogrenci()
                {
                    Ad = "Aybüke", Soyad = "Yıldız",
                    Notlar = new Not(){N1= 82, N2 = 57, F= 65}
                },

            };



            var gecenOgrenciler = ogrenciler.Where(o => o.Notlar.Ortalama >= 50).ToList();
            Console.WriteLine("*********************************************");
            Console.WriteLine("Soru 1: Geçme Notu 50 Olan Öğrenciler:");
            Console.WriteLine("---------------------------------------------");
            foreach (var ogrenci in gecenOgrenciler)
            {
                Console.WriteLine($"{ogrenci.TamAd} - Not Ortalaması: {Math.Round(ogrenci.Notlar.Ortalama, 2)}");
            }
            Console.WriteLine("*********************************************");
            Console.WriteLine();
            Console.WriteLine();





            Console.WriteLine("*********************************************");
            Console.WriteLine("Soru 2: Tüm Öğrenciler:");
            Console.WriteLine("---------------------------------------------");
            foreach (var ogrenci in ogrenciler)
            {
                ogrenci.Yazdir();
            }
            Console.WriteLine("*********************************************");
            Console.WriteLine();
            Console.WriteLine();




            var siniftaKalanlar = ogrenciler.Where(o => o.Notlar.Ortalama < 50).ToList();
            int siniftaKalanSayisi = siniftaKalanlar.Count;
            Console.WriteLine("*********************************************");
            Console.WriteLine($"Soru 3: Sınıfta Kalan Toplam Öğrenci Sayısı: {siniftaKalanSayisi}");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Sınıfta kalan öğrenciler:");
            foreach (var ogrenci in siniftaKalanlar)
            {
                ogrenci.Yazdir();
            }
            Console.WriteLine("*********************************************");
            Console.WriteLine();
            Console.WriteLine();




            var sinifiGecenler = ogrenciler.Where(o => o.Notlar.Ortalama >= 50).ToList();
            int sinifiGecenSayisi = sinifiGecenler.Count;
            Console.WriteLine("*********************************************");
            Console.WriteLine($"Soru 4: Sınıfı Geçen Toplam Öğrenci Sayısı: {sinifiGecenSayisi}");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Sınıfı Geçen Öğrenciler:");
            foreach (var ogrenci in sinifiGecenler)
            {
                ogrenci.Yazdir();
            }
            Console.WriteLine("*********************************************");
            Console.WriteLine();
            Console.WriteLine();





            var siraliOgrenciler = ogrenciler.OrderBy(o => o.Ad).ToList();
            Console.WriteLine("*********************************************");
            Console.WriteLine("Soru 5: İsimlere Göre Sıralanmış Öğrenciler:");
            Console.WriteLine("---------------------------------------------");
            foreach (var ogrenci in siraliOgrenciler)
            {
                ogrenci.Yazdir();
            }
            Console.WriteLine("*********************************************");
            Console.WriteLine();
            Console.WriteLine();






            var enYuksekNotAlanlar = ogrenciler.OrderByDescending(o => o.Notlar.Ortalama).Take(3).ToList();
            Console.WriteLine("*********************************************");
            Console.WriteLine("Soru 6: Not Ortalamasına Göre En Yüksek Not\r\nAlan İlk 3 Öğrenci:");
            Console.WriteLine("---------------------------------------------");
            foreach (var ogrenci in enYuksekNotAlanlar)
            {
                ogrenci.Yazdir();
            }
            Console.WriteLine("*********************************************");
            Console.WriteLine();
            Console.WriteLine();





            var sinifiGecenlerSirali = sinifiGecenler.OrderBy(o => o.Notlar.Ortalama).Take(3).ToList();
            Console.WriteLine("*********************************************");
            Console.WriteLine("Soru 7: Not Ortalamasına Göre Sınıfı Geçenler\r\nArasında En Düşük Not Alan İlk 3 Öğrenci:");
            Console.WriteLine("---------------------------------------------");
            foreach (var ogrenci in sinifiGecenlerSirali)
            {
                ogrenci.Yazdir();
            }
            Console.WriteLine("*********************************************");
            Console.WriteLine();
            Console.WriteLine();



            Console.ReadKey();
        }
    }
}




