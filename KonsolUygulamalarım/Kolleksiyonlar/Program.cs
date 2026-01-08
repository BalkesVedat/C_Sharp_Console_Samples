using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics;

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

            Console.WriteLine("---- Array --------");

            Console.WriteLine(adlar[0]);

            Console.WriteLine("------------");

            int[] notlar = { 12321, 356879545, 545, 6565, 212, 1, 5, 45 };

            string[] plakalar = { "34ABC34", "35aaa111", "01ADN01", "10ON10", "16BRS16" };

            Console.WriteLine(plakalar[0]);

            Console.WriteLine("-----------------");

            for (int i = 0; i < plakalar.Length; i++) {
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

            Console.WriteLine("--------------------");
            Console.WriteLine("--- ArrayList ------");

            //ARRAYLIST : İçine object tipinde veri kabul edebilen kolleksiyondur. Tip güvenli değildir.

            ArrayList list = new ArrayList();
            list.Add("Çay");
            list.Add("Kahve");
            list.Add(25);
            list.Add(DateTime.Now);
            list.Add(true);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            if (list.Contains("Kahve"))
                Console.WriteLine("Listede Kahve Mevcut");
            else
                Console.WriteLine("Kahve Maalesef mevcut değil.");

            list.RemoveAt(list.IndexOf(true));

            list.Remove("Çay");

            Console.WriteLine("-----------");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }


            Console.WriteLine("------------------------");
            Console.WriteLine("--- Hashtable-----------");

            Hashtable hashListe = new Hashtable();

            hashListe.Add(100, "armut");
            hashListe.Add(300, "elma");

            Hashtable gunler = new Hashtable();

            gunler.Add("Pzt", "Pazartesi");
            gunler.Add("Sal", "Sali");
            gunler.Add("Car", "Carsamba");
            gunler.Add("Per", "Persembe");
            gunler.Add("Cum", "Cuma");
            gunler.Add("Cmt", "Cumartesi");
            gunler.Add("Paz", "Pazar");

            //  Console.WriteLine(gunler["Sal"]);

            //for (int i = 0; i < gunler.Count; i++)
            //{

            //    gunler[gunler.Keys(i)];
            //}

            foreach (var item in gunler.Keys)
            {
                Console.WriteLine(gunler[item]);
            }

            Console.WriteLine("------------------");
            Console.WriteLine(hashListe[100]);

            Console.Write("Gün kısa adı Giriniz:");
            string aranan = Console.ReadLine();

            if (gunler.Contains(aranan))
                Console.WriteLine(gunler[aranan]);
            else
                Console.WriteLine("Aranan gün bulunamadı.");



            Console.WriteLine("- Dictionary -----------");

            Dictionary<string,string> sozluk = new Dictionary<string,string>();

            sozluk.Add("apple", "elma");
            sozluk.Add("key", "anahtar");
            sozluk.Add("book", "kitap");

            Console.ReadKey();
        }
    }
}
