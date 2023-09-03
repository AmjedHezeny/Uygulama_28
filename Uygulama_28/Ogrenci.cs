using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama_28
{
    internal class Ogrenci
    {

        public string Ad { get; set; }
        public string Soyad { get; set; }
        public Not Notlar { get; set; }
        public string TamAd
        {
            get
            {
                return string.Format("{0} {1}", Ad, Soyad);
            }
        }
        internal void Yazdir()
        {
            Console.WriteLine("{0} - Not Ortalaması: {1}", TamAd, Math.Round(Notlar.Ortalama, 2));
        }
    }
    class Not
    {
        public int N1 { get; set; }
        public int N2 { get; set; }
        public int F { get; set; }
        public double Ortalama
        {
            get { return (N1 + N2 + F) / 3.0; }
        }
    }

}
