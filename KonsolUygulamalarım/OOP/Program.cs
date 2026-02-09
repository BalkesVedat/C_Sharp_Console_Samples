using OOP.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bitki gül = new Bitki();

            gül.Tur = Enums.Cinsiyet.Dişi;
            gül.Name = "Pembe Gül";

            Console.WriteLine(gül.Beslen());


            Hayvan inek = new Hayvan();

            inek.Tur = Enums.Cinsiyet.Dişi;
            inek.Name = "Holstein";

            Console.WriteLine(inek.Beslen());

            Console.ReadKey();

        }
    }
}
