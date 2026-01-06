using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Operatörler kodlama esnasında kullandığımız özel işaretlerdir. işlem yaparken kullanılırlar.
            //Operatör türleri:
            // 1.Aritmetik Operatörler: "+,-,*,/"
            // 2.Karşılaştırma Operatörleri: "==,===,<,<=,>,>=,!="
            /*
                "==" eşitlik kotrol eder. her 2 tarafına yazılan ifade birbirine eşitse "true", değilse "false" sonucunu üretir.  (sayi == 0)
                "!=" 2 tarafına yazılan ifadeleri karşılaştırır ve bu ifadeler birbirine eşit değilse "true" döndürür. yani "==" in tersidir. (sayi != 0) 
             "<,<=,>,>=" işaretleri 2 taraflarına yazılan değerlerin birbirinden küçük yada büyük olup olmadıklarını karşılaştırır ve sonuca göre "true" ya da "false" döner. (sayi <= 0)
             "===" 2 değerin birbirine hem değer olarak hem de tip olarak eşit olup olmadığını denetler. (sayi === 0)
                int sayi1 = 0;
                double sayi2 = 0;
                if( sayi1 == sayi2 ) -->  true
                if( sayi1 === sayi2 ) --> false
             */
            // 3. Atama operatörü:     "="  
            //   Sağına yazılan değeri, soluna yazılan nesneye aktarır. (sayi1 = 0)
            //  4. İşlem kısaltma operatörleri (Birleşik işlem operatörleri) :  "+=,-=,*=,/=,++,--,**,%"
            /*
                 "+=" : sağına yazılan değeri, soldaki nesnenin değerine ekler. (sayi1+=50) sayi1 'in değerini 50 arttır. (sayi1 = sayi1 + 50)
                  "-=" : değer eksiltir.
                  "*=" : çarparak arttır. (sayi1*=3)
                  "/=" : değeri bölerek aktar. (sayi1/=3)-->(sayi1 = sayi1/3)
            "++" : soldaki nesnenin değerini 1 arttırır.
            "--" : soldaki nesnenin değerini 1 eksiltir.
            "**" : soldaki nesnenin değerini kendisi ile çarpar.
            "%"  : mod alma işlemi yapar. (soldaki değerin, sağdaki değere bölümünden kalan değeri verir) (5 % 2 = 1)
             */

            int sayi1 = 5;
            int sayi2 = 10;

            double dblSonuc;
            bool boolSonuc;

            boolSonuc = sayi1 == sayi2;

            Console.WriteLine(boolSonuc);
            Console.WriteLine(sayi1 == sayi2);

            sayi2 *= sayi1;

            Console.WriteLine(sayi2);

            sayi1++;

            sayi1 += sayi1;
            Console.WriteLine(sayi1);

            Console.WriteLine(sayi2%sayi1);


        }
    }
}
