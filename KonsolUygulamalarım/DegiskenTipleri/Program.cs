using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegiskenTipleri
{
    struct Urun
    {
        public int urunKodu;
        public string urunAd;
        public double fiyat;
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Değişkenler");
            Console.WriteLine("------------------");

            /* Değer Tipli Değişken tipleri:
             1. Metinsel veri tutarn değişkenler:
             char, string
            char  : tek karakter tutan değişken
            string: karakter dizesi. birden fazla karakter içeren metin tutan değişken
            2. Sayısal Veri tutan Değişkenler:
              a. Tam sayı değişkenler :
                    byte, short, int, long
             byte: 1 byte lık değişken tipidir. 0-255 arası sayıları tutabilir.
             short : 2 byte, -32.768 - +32.767 arası tam sayılar
             int   : 4 byte, -2 milyar- + 2 milyar arası tam sayılar.
             long  : 8 byte,  -9,E+18 - +9,E+18 arası tam sayılar
             F1 ile learn.microsoft.com dan yardım alınabilir.
                
                b. Ondalıklı Sayı tutan değişken tipleri
                float, double, decimal    

            3. bool (Boolean-Mantıksal veri):
                true, false tutabilen değişken tipleri
            */

            byte vizeNotu = 50;

            int maas = 75000;

            double fiyat = 150.25;

            string userName;

            userName = "ahmet@xxx.com";

            int sayi1, sayi2, sonuc;

            sayi1 = 0; sayi2 = 5; sonuc = sayi1 + sayi2;

            double _fiyat, kdvOrani2025, kdvDahilFiyat;

            _fiyat = 158.75;
            kdvOrani2025 = 0.2;
            kdvDahilFiyat = _fiyat * (1 + kdvOrani2025);

            char cevap = 'y';

            bool devamEdilsinMi;


            if (cevap=='y')
            {
                devamEdilsinMi = true;
            }
            else
            {
                devamEdilsinMi = false;
            }

            int s1 = int.MaxValue;



            double dblFiyat = 0;


            Urun araba1 = new Urun();

            araba1.urunKodu = 13213;
            araba1.urunAd = "orıjoojert oje rojtoej";
            araba1.fiyat = 1222;

            Urun araba2 = new Urun();

            araba2.urunKodu = 11111;
            araba2.urunAd = "merkebes";
            araba2.fiyat = 5000;

            araba1 = araba2;

            araba1.fiyat = 2000;

            Console.WriteLine("araba2 fiyatı :" + araba2.fiyat);
            Console.WriteLine("araba2 fiyatı :{0}", araba2.fiyat);
            Console.WriteLine($"araba2 fiyatı :{araba2.fiyat}");




        }
    }
}
