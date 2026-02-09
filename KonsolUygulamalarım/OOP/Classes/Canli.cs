using OOP.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Classes
{
    internal class Canli : ICanli
    {
        public string Name { get ; set ; }
        public Cinsiyet Tur { get ; set; }

        public string Beslen()
        {
            return "Canlı Beslendi";
        }

        public string Dead()
        {
            return "Canlı Öldü";
        }

        public string Ure()
        {
            return "Canlı Üredi.";
        }
    }
}
