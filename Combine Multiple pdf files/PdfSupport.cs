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
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Combine_Multiple_pdf_files
{

    class PdfFile { 
        public String addFile {get;set;}


        public PdfFile(string addFile) {
            this.addFile = addFile;
        }
    }

    class PdfFileWorker {

        internal static void CreateoutputFile(String[] pdfFilesDistinct, String outputFileName)
        {
            PdfDocument outPdfDocument = new PdfDocument();

            for (int x = 0; x< pdfFilesDistinct.Length; x++)
            {
                PdfDocument inputDocument = PdfReader.Open(pdfFilesDistinct[x], PdfDocumentOpenMode.Import);
                for (int i = 0; i<inputDocument.PageCount; i++)
                {

                    outPdfDocument.AddPage(inputDocument.Pages[i]);
                }
            }
            String outputFolder = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            //String output = outputFolder.Replace("\\", "\\\\");
            String output;
            if (outputFileName.Length < 1) {

                outputFileName = "\\\\newPdfFile"+ DateTime.Now.ToString("YYYYMMddHHmmss") + ".pdf";
            }
            string illegalChars = @"^(?!^(PRN|AUX|CLOCK\$|NUL|CON|COM\d|LPT\d|\..*)(\..+)?$)[^\x00-\x1f\\?*:\"";|/]+$";
            bool isValidName = Regex.IsMatch(outputFileName, illegalChars, RegexOptions.CultureInvariant);
            if (isValidName == true)
            {
                output = outputFolder.Replace("\\", "\\\\") + "\\\\" + outputFileName;
            }
            else {
                output = outputFolder.Replace("\\", "\\\\") + "\\\\newPdfFile.pdf";
            }
            outPdfDocument.Save(output);

        }
    }

}
