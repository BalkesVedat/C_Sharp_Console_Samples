using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism.Models
{
    internal class WordDocument:Document
    {
        public new void Print()
        {
            Console.WriteLine("{0} - Word document has been printed.", FileName);
        }

        public new void Open()
        {
            Console.WriteLine("Word document has been opened.");
        }
    }
}
