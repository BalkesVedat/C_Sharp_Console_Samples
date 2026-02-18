using OOP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Classes
{
    internal class Ordek : Kuslar, IUcabilir, IYuzebilir
    {
        public string Uc()
        {
            return "Ördek Uçtu";
        }

      //  abstract, virtual, override

        public string Yuz()
        {
            return "Ördek Yüzdü";
        }
        public new string Beslen()
        {
            return "Ördek Beslendi";
        }
    }
}
