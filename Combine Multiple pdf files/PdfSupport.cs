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
        public String[] ArrayOfSourceFiles(String[] stage ,String intput) {
            if (intput.Length > 0) {
            stage.Append(intput);
                }

            return stage;
        }

    }
}
