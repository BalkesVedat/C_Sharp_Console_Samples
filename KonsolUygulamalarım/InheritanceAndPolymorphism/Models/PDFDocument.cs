using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism.Models
{
    internal class PDFDocument:Document
    {
        public PDFDocument()
        {
            CreateDate = DateTime.Now;
        }

        public PDFDocument(string fileName, string filePath, double fileSize)
        {
            FileName = fileName;
            FilePath = filePath;
            FileSize = fileSize;
            CreateDate = DateTime.Now;
        }

        public new void Print()
        {
            Console.WriteLine("{0} - Pdf document has been printed.", FileName);
        }
        public new void Open()
        {
            Console.WriteLine("Pdf document has been opened.");
        }

    }
}
