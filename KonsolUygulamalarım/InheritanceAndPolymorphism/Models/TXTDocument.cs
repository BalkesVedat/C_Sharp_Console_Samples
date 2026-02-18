using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism.Models
{
    internal class TXTDocument:Document
    {
        public new void Print()
        {
            Console.WriteLine("{0} - Txt Document has been printed.", FileName);
        }

        public new void Open()
        {
            Console.WriteLine("Txt document has been opened.");
        }

    }
}
