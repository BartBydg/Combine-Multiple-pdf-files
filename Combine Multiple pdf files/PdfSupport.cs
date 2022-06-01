using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System.Diagnostics;

namespace Combine_Multiple_pdf_files
{

    class PdfFile { 
        public String addFile {get;set;}


        public PdfFile(string addFile) {
            this.addFile = addFile;
        }
    }

    class PdfFileWorker {

        internal static void CreateoutputFile(String[] pdfFilesDistinct)
        {
            PdfDocument outPdfDocument = new PdfDocument();

            for (int x = 0; x< pdfFilesDistinct.Length; x++)
            {
                PdfDocument inputDocument = PdfReader.Open(pdfFilesDistinct[x], PdfDocumentOpenMode.Import);
                Debug.WriteLine("TEST: "+ pdfFilesDistinct[x]);
                for (int i = 0; i<inputDocument.PageCount; i++)
                {

                    outPdfDocument.AddPage(inputDocument.Pages[i]);
                }
            }

            outPdfDocument.Save("C:\\Tools\\testxxx.pdf");

        }
    }

}
