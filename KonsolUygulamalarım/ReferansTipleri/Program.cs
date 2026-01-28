using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ReferansTipleri
{
    class Araba
    {
        //fields (alanlar)
        public string marka;
        public string model;
        public string plaka;
        public int fiyat;
        public bool stokta = true;
        private int hiz = 0;
        public int maximumHiz = 190;

        //methods
        public string Calistir()
        {
            return "Araba Çalıştı";
        }

        // SETTER METODLAR
        public void Hizlan(int miktar)
        {
            hiz += miktar;

            if (hiz > maximumHiz)
            {
                hiz = maximumHiz;
            }
        }
        public void Yavasla(int miktar)
        {
            hiz -= miktar;

            if (hiz < 0)
            {
                hiz = 0;
            }
        }

        //GETTER
        public int HizGoster()
        {
            return hiz;
        }

    }

    class Kus
    {
        //fields
        public string cinsi;
        public bool ucabilir = true;
        public bool yüzebilir = false;

        //methods - class içerisinde yapılacak işlemler.
        public string SesCikar()
        {
            return "cik cik";
        }

        public string Beslen()
        {
            return "Kuş Beslendi.";
        }

        public void Yuz()
        {

        }
    }

    class Ogrenci
    {
        private int ogrID;

        public int _ogrID
        {
            get { return ogrID; }
            set { ogrID = value; }
        }

        public string _adSoyad { get; set; }
        public DateTime _dogumTarihi { get; set; }

        public DateTime _kayitTarihi { get; set; }

        private double diplomaNotu;
        public double _diplomaNotu
        {
            get { return diplomaNotu; }
            //set
            //{
            //    if (value < 0)
            //        diplomaNotu = 0;
            //    else
            //        diplomaNotu = value;
            //}
        }




    }

    internal class Program
    {
        static void Main(string[] args)
        {
            /*  
             Değişken Tipleri :
            1. Değer Tipleri : Belleğin "stack" kısmında yaratılan ve bellek alanında doğrudan veriyi tutan değişken tipleridir. Her bir değer tipli değişken ayrı bir veri tutar. Birbirlerinden bağımsız kopyalardır. En çok kullanılan değer tipleri : int, double, byte, decimal, struct, enum, char, bool

             2. Referans Tipleri : Referans Tipleri, kendilerine atanan verileri belleğin "heap" kısmında saklarlar ve "stack" kısmındaki alnlarında ise o verinin "heap" bölgesindeki adresini saklarlar. Yani içlerinde verinin kendisini değil, bellek adresini tutarlar. Bir referans tipi, başka bir referans tipine atandığında verisinin kopyası değil, bellek adresi atanmış olur ve her ikiside aynı veriyi işaret eder. (Pointer) Aynı veri her 2 değişken tarafından da yönetilebilir.
               En çok kullanılan referans tipleri : class, delegate, interface, string(*), array(dizi), object

             string(*) : string referans tipli olmasına rağmen pratikte kullanılırken değer tipli gibi davranır.
             */


            int a = 5;

            int b = 10;

            a = b;

            b = 50;

            Console.WriteLine($"a:{a} - b:{b}");

            string str1, str2;

            str1 = "Merhaba";
            str2 = "Dünya";

            str1 = str2;

            str2 = "Mars";

            Console.WriteLine($"str1:{str1} - str2:{str2}");

            //Referans Tipleri:

            int[] intDizi1 = { 1, 2, 3 };
            int[] intDizi2 = { 4, 5, 6 };

            intDizi1 = intDizi2;

            intDizi1[0] = 100;

            for (int i = 0; i < intDizi2.Length; i++)
            {
                Console.WriteLine(intDizi2[i]);
            }

            //REFERANS TİPLERİ:
            //CLASS (Sınıf):
            //

            Araba araba1 = new Araba();

            araba1.marka = "BMW";
            araba1.model = "E60";
            araba1.fiyat = 1700000;
            araba1.maximumHiz = 240;

            araba1.Hizlan(25);

            araba1.Hizlan(15);

            araba1.Hizlan(25);

            araba1.Yavasla(10);

            Console.WriteLine("araba1 in mevcut hızı:{0}", araba1.HizGoster());


            Araba araba2 = new Araba();

            araba2.marka = "Mercedes";
            araba2.model = "GT43";
            araba2.fiyat = 1500000;

            //  araba1 = araba2; // araba1 de artık araba2 ile aynı hafıza alanını gösteriyor. araba1 in önceden atanan verilerinin bulunduğu alanın bağlantısı koptu. GC tarafından bu veriler yok edilecek. 

            //araba1.fiyat = 3000000;

            //Console.WriteLine(araba2.fiyat);

            Ogrenci ogr1 = new Ogrenci();

            ogr1._adSoyad = "ahmet";
           // ogr1._diplomaNotu = 75;

            Console.WriteLine(ogr1._diplomaNotu);


        }
    }
}
