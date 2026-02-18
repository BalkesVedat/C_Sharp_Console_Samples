using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism.Models
{
    internal class PowerPointDocument :Document
    {
        public new void Print()
        {
            Console.WriteLine("{0} - Powerpoint document has been printed.", FileName);
        }

        public new void Open()
        {
            Console.WriteLine("Powerpoint document has been opened.");
        }

    }
}
