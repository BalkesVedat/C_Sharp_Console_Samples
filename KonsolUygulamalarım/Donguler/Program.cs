using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //    /*
            //     Döngü Nedir?
            //    Döngü bir kod parçasının birden fazla kere çalışması gerektiğinde kurulan otomatik program akışı ifadeleridir. Bir kodun kaz kez ya da hangi koşula göre tekrarlanacağı kod yapısında belirtilir.

            //    Kendi döngü yapımızıkurabileceğimiz gibi hazır döngü yapılarını da kullanabiliriz.

            //    En sık kullanılan Döngü yapıları :
            //    1. FOR .. NEXT döngüsü :
            //     For kodlama yapısı:
            //    for (değişken tanımı;koşul;değişken değeri artırımı)
            //    { 
            //        //kodlar
            //    }

            // FOR döngüsü, belli bir sayıda çalışması gereken kodlar olduğunda kullanılmak için idealdir. Çok hızlı çalışır. 

            // Döngünün kaç kez çalışacağını belirtemiyor isek, belli bir koşul sağlandığı müddetçe çalışması gereken bir kod var ise bu durumda FOR döngüsü yerine WHILE ya da DO .. WHILE döngüleri tercih edilebilir.

            // WHILE kullanımı:
            //while (koşul)
            //{ 
            //    işlemler
            //}

            //while döngüsünde ilk önce koşul kontrol edilir, koşul "true" değeri üretiyor ise while bloğundaki kodlar çalıştırılır. Sonra tekrar başa dönerek koşul tekrar kontrol edilir. Koşul "False" ürettiğinde While döngüsü sonlanır.

            // DO..WHILE kullanımı :

            //do
            //{
            //    işlemler
            //} while (koşul);

            //DO..WHILE döngüsünde ilk önce kodlar çalıştırılır, sonra koşul kontrolü yapılır. 

            // FOREACH döngüsü:

            //foreach döngüsü bir kolleksiyon (liste) içerisindeki her bir değer için yapılması gereken bir işlem olduğunda kullanmak için idealdir.

            //kullanımı :
            //foreach (değişken_tipi değişken in kolleksiyon)
            //{ 
            //    işlemler
            //}


            //     */

            //    Console.WriteLine("Kendi döngü yapımız ile yazdırıldı.");
            //    Console.WriteLine("----------------------------------");

            //    int sayac = 0;
            //    int adet = 10;

            //tekrar:
            //    if (sayac < adet)
            //    {
            //        Console.WriteLine(sayac + 1);
            //    }
            //    else
            //    {
            //        goto bitir;
            //    }
            //    //sayac = sayac + 1;

            //    //sayac += 1;

            //    sayac++;

            //    goto tekrar;
            //bitir:

            //    Console.WriteLine("----------------------------------");

            //    Console.WriteLine("FOR DÖNGÜSÜ");

            //    for (int i = 1; i <= adet; i++)
            //    {
            //        Console.WriteLine(i);
            //    }

            //    Console.WriteLine("----------------------------------");

            //    int toplam = 0;
            //    int min = 1;
            //    int max = 100;

            //    for (int i = min; i <= max; i++)
            //    {
            //        //toplam = toplam + i;
            //        toplam += i;
            //    }

            //    Console.WriteLine(min + "-" + max + " arası sayıların toplamı:" + toplam);

            //    Console.WriteLine("{0}-{1} arası sayıların toplamı:{2}", min, max, toplam);

            //    Console.WriteLine("--------------------------------------------------");

            //    toplam = 0;

            //    for (int i = 1; i <= 100; i += 2)
            //    {
            //        toplam = toplam + i;
            //    }
            //    Console.WriteLine("1-100 arası tek sayıların toplamı:{0}", toplam);

            //    toplam = 0;
            //    for (int i = 1; i <= 100; i++)
            //    {
            //        if (i % 2 == 1)
            //        {
            //            toplam += i;
            //        }
            //    }
            //    Console.WriteLine("1-100 arası tek sayıların toplamı:{0}", toplam);

            //    adet = 0;

            //    for (int i = 100; i >= 1; i--)
            //    {
            //        if (i % 2 == 0)
            //        {
            //            adet++;
            //        }
            //    }

            //    Console.WriteLine("100-1 arası çift sayıların adedi:{0}", adet);
            //    Console.WriteLine("----------------------------------");

            //    for (int i = 1; i <= 10; i++)
            //    {
            //        if (i == 5)
            //        {
            //            continue;
            //        }
            //        Console.WriteLine(i);
            //    }

            //    Console.WriteLine("----------------------------------");

            //    for (int i = 1; i <= 10; i++)
            //    {
            //        if (i == 5)
            //        {
            //            break;
            //        }
            //        Console.WriteLine(i);
            //    }
            //    Console.WriteLine("----------------------------------");
            //    Console.WriteLine("----------------------------------");
            //    Console.WriteLine("WHILE Döngüsü");

            //    int sayi = 0;
            //    int sayiToplami = 0;

            //    while (sayi >= 0)
            //    {
            //        Console.WriteLine("Bir sayı giriniz. Çıkmak için negatif bir sayı giriniz.");
            //        try
            //        {
            //            sayi = Convert.ToInt32(Console.ReadLine());
            //        }
            //        catch (Exception)
            //        {
            //            sayi = 0;
            //            Console.WriteLine("Lütfen geçerli bir değer giriniz.");
            //        }

            //        if (sayi > 0)
            //        {
            //            sayiToplami += sayi;
            //        }

            //        Console.WriteLine("Toplam:{0}", sayiToplami);
            //    }
            //    // Console.WriteLine("Toplam:" + sayiToplami);
            //    // Console.WriteLine("Toplam:{0}",sayiToplami);

            //---------------------------------------------

            //string cevap = "";
            //double doubleToplam = 0.0;
            //double doubleGirilen = 0.0;

            //do
            //{
            //yeniden:
            //    Console.Write("Bir sayı giriniz: ");

            //    try
            //    {
            //        doubleGirilen = Convert.ToDouble(Console.ReadLine());
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine("Lütfen geçerli bir sayı giriniz."+ex.Message);
            //        goto yeniden; 
            //    }

            //    doubleToplam += doubleGirilen;
            //tekrar:
            //    Console.Write("Başka bir sayı daha girmek ister misiniz? (E/H)  ");
            //    cevap = Console.ReadLine();

            //    if (cevap != "E" && cevap != "e" && cevap != "H" && cevap != "h")
            //    {
            //        Console.WriteLine("Lütfen geçerli bir cevap yazınız.");
            //        goto tekrar;
            //    }
            //} while (cevap == "E" || cevap == "e");

            ////Console.WriteLine("Girilen Sayıların Toplamı :" + doubleToplam);
            ////Console.WriteLine("Girilen Sayıların Toplamı :{0}", doubleToplam);
            //Console.WriteLine($"Girilen Sayıların Toplamı :{doubleToplam}");


            //--------------------------------------------------------
            // FOR EACH ----------------------------------------------

            string marka = "Mercedes";
            int ogrNot = 75;

            string[] markalar = { "MERCEDES", "BMW", "AUDI", "PORSCHE", "FERRARI", "HONDA" };

            foreach (var eleman in markalar)
            {
                Console.WriteLine(eleman);          
            }

            Console.WriteLine("---------------------");

            for (int i = 0; i < markalar.Length; i++)
            {
                Console.WriteLine(markalar[i]);
            }

            Console.WriteLine("---------------------");

            int ss = 0;
            while (ss<markalar.Length)
            {
                Console.WriteLine(markalar[ss]);
                ss++;
            }

            Console.ReadKey();

        }
    }
}
