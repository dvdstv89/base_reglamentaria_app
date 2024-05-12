using BRapp.Model;
using BRapp.Services.Interfaces;
using BRapp.Services.Services;
using BRapp.UI.Component;
using System;
using System.Windows.Forms;

namespace BRapp.UIControlers.Components
{

    internal class VisorDocumentosUIController : BaseUIController<VisorDocumentosUI>
    {
        private readonly DocumentoPDF DocumentoPDF;     
        private readonly IVisorDocumentoService visorDocumentosService;     

        public VisorDocumentosUIController(DocumentoPDF DocumentoPDF) : base(new VisorDocumentosUI())
        {
            this.DocumentoPDF = DocumentoPDF;
            visorDocumentosService = VisorDocumentosService.Instance;           
        }

        public override VisorDocumentosUI ejecutar()
        {            
            forma.Load += Form_Load;
            forma.imprimirToolStripMenuItem.Click += new EventHandler(imprimirToolStripMenuItem_Click);
            forma.descargarToolStripMenuItem.Click += new EventHandler(descargarToolStripMenuItem_Click);
            return forma;
        }      


        private void Form_Load(object sender, EventArgs e)
        {           
            forma.Text = DocumentoPDF.PDF.Name;           
            forma.pdfViewer1.LoadDocument(DocumentoPDF.PDF.Data);
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (forma != null && forma.pdfViewer1 != null && forma.pdfViewer1.Document != null)
            {               
                using (PrintDialog printDialog = new PrintDialog())
                {                   
                    if (printDialog.ShowDialog() == DialogResult.OK)
                    {
                        forma.pdfPrintDocument1.PrinterSettings = printDialog.PrinterSettings;
                        forma.pdfPrintDocument1.Document = forma.pdfViewer1.Document;                      
                        forma.pdfPrintDocument1.Print();
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay documento PDF para imprimir.");
            }
        }

        private void descargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (forma != null && forma.pdfViewer1 != null && forma.pdfViewer1.Document != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName= DocumentoPDF.PDF.Name;
                saveFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    forma.pdfViewer1.Document.Save(filePath, Patagames.Pdf.Enums.SaveFlags.NoIncremental);
                    MessageBox.Show("Documento PDF guardado correctamente.");
                }
            }
            else
            {
                MessageBox.Show("No hay documento PDF para descargar.");
            }
        }

        public bool hasPdf()
        {
            return this.DocumentoPDF != null && DocumentoPDF.PDF != null && DocumentoPDF.PDF.Data.Length > 0;
        }
    }
}

