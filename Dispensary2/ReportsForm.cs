using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

namespace Dispensary2
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

        private string path = @"C:\Users\USER\Desktop\Dispensary2\Reports";

        private void button1_Click(object sender, EventArgs e)
        {
            
            FileStream fs = new FileStream(path+$@"\check{GetFilesAmount()}.pdf", FileMode.Create, FileAccess.Write, FileShare.None);
            Document doc = new Document();
            PdfWriter writer = PdfWriter.GetInstance(doc, fs);
            doc.Open();
            PdfPTable table = new PdfPTable(3);
            table.AddCell("Row 1, Col 1");
            table.AddCell("Row 1, Col 2");
            table.AddCell("Row 1, Col 3");

            table.AddCell("Row 2, Col 1");
            table.AddCell("Row 2, Col 2");
            table.AddCell("Row 2, Col 3");

            table.AddCell("Row 3, Col 1");
            table.AddCell("Row 3, Col 2");
            table.AddCell("Row 3, Col 3");
            doc.Add(table);
            doc.Add(new Paragraph("Hello World"));
            doc.Close();
        }

        private string GetFilesAmount()
        {
            //DirectoryInfo directInfo = new DirectoryInfo(@"C:\Users\USER\Desktop\Dispensary2\Reports"); 
            //FileInfo[] Files = directInfo.GetFiles("*.pdf"); 
            return Directory.GetFiles(path).Length.ToString();
        }
    }
}
