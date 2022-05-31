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

        private List<PdfFile> pdfFiles = new List<PdfFile>();


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
                pdfFiles.Add(new PdfFile(stringFileName));

            }

        }
    }
}
