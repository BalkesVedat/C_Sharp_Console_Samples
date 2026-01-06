using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Kolleksiyonlar:
            İçerisinde birden fazla değer taşıyabilen değişken tiplerine kolleksiyon denir. Bazı kolleksiyonlar tek tip veriler taşıyabiliyorken, bazı kolleksiyonlar ise farklı tiplerden verileri içinde taşıyabilir. İçinde tek tip veri tutanlara tip güvenli (type safe) kolleksiyon denir. Farklı tiplerde veri tutabilenler ise tip güvenli değildir.
             
            Bazı kolleksiyon tipleri:
            Array, ArrayList, Dictionary, List
             
             */

            //ARRAY:
            // İçinde aynı tipten veriler tutar. 
            string ad = "Vedat";
            ad = "Ali";

            string[] adlar = new string[6];
            adlar[0] = "Ali";
            adlar[1] = "Berrin";
            adlar[2] = "Murat";
            adlar[5] = "Cemile";

            Console.WriteLine(adlar[0]);

            Console.WriteLine("-----------------");

            int[] notlar = {12321,65454,545,6565,212,1,5,45};

            string[] plakalar = {"34ABC34","35aaa111","01ADN01","10ON10","16BRS16"};

            Console.WriteLine(plakalar[0]);

            Console.WriteLine("-----------------");

            for (int i=0;i<plakalar.Length ;i++) {
                Console.WriteLine(plakalar[i]);
            }

            Console.WriteLine("-----------------");

            foreach (string item in plakalar)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------");

            foreach (string item in adlar)
            {
                Console.WriteLine(item);
            }

            string[] newAdlar = new string[10];

            adlar.CopyTo(newAdlar, 0);

           // Array.Copy(adlar, newAdlar, adlar.Length);

            //Array.Clear(adlar,0,adlar.Length);

            //adlar = null;

            newAdlar[7] = "Ali Kemal";
            newAdlar[9] = "Narin";

            Array.Sort(newAdlar);

            Array.Reverse(newAdlar);

            Console.WriteLine("-------------------------");

            foreach (string item in newAdlar) {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
