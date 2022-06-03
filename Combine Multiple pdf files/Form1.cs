using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combine_Multiple_pdf_files
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private String[] pdfFiles = new String[0];


        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string stringFileName = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                stringFileName = openFileDialog.FileName;
                textBox2.AppendText("Added file:");
                textBox2.AppendText(Environment.NewLine);
                textBox2.AppendText(stringFileName);
                textBox2.AppendText(Environment.NewLine);
                String correctFileName = stringFileName.Replace("\\","\\\\");


                Array.Resize(ref pdfFiles, pdfFiles.Length + 1);
                pdfFiles[pdfFiles.Length - 1] = correctFileName;

                pdfFiles.Append(correctFileName);

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //// only uniqe vales in result
            //var  pdfFilesStg = pdfFiles.GroupBy(x => x.addFile)
            //    .Where(x => x.Count() == 1)
            //    .Select(x => x.First());

            //// only distinct values in result 
            //var pdfFilesDistinct = pdfFiles.GroupBy(x => x.addFile)
            //    .Select(x => x.Distinct()).ToArray();
            var pdfFilesDistinct = pdfFiles.Distinct().ToArray();
            
            PdfFileWorker.CreateoutputFile(pdfFilesDistinct,textBox1.Text);

        }
    }
}
