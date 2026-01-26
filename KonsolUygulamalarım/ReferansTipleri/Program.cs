using System;
using System.Collections.Generic;
using System.Linq;
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



            




        }
    }
}
