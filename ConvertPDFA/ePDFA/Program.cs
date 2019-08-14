using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SautinSoft.Document;

namespace ePDFA
{
    class Program
    {
        static void Main(string[] args)
        {
            LoadAndSaveAsPDFA();
        }

        public static void LoadAndSaveAsPDFA()
        {            
            string loadPath = @"C:\Users\wanderson\Desktop\Laura\teste.pdf";            
            DocumentCore document = DocumentCore.Load(loadPath);
            PdfSaveOptions options = new PdfSaveOptions()
            {                
                Compliance = PdfCompliance.PDF_A
            };
            string savePath = Path.ChangeExtension(loadPath, ".pdf");
            document.Save(savePath, options);            
            System.Diagnostics.Process.Start(savePath);
        }
    }
}
