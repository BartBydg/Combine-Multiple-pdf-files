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
    class PdfSupport
    {
        private List<String> _pdffiles = new List<String>();

        public List<String> pdfFiles {
            get {return _pdffiles;}
            set {_pdffiles = value;}
        }
    }



}
