using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

namespace Combine_Multiple_pdf_files
{

    class PdfFile { 
        public String addFile {get;set;}


        public PdfFile(string addFile) {
            this.addFile = addFile;
        }
    }



}
