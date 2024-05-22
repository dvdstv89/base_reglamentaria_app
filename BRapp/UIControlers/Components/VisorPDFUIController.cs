using BRapp.Data;
using BRapp.Model;
using BRapp.Services.Interfaces;
using BRapp.UI.Component;
using System;
using System.IO;
using System.Windows.Forms;

namespace BRapp.UIControlers.Components
{

    internal class VisorPDFUIController : BaseUIController<VisorPDFUI>
    {
        private readonly DocumentoPDF documento;     
        private readonly IVisorPDFService visorDocumentosService;
        

        public VisorPDFUIController(DocumentoPDF documento) : base(new VisorPDFUI())
        {
            this.documento = documento;
            this.visorDocumentosService = AplicationConfig.Component.VisorPDFService;
        }        

        public override VisorPDFUI ejecutar()
        {
            forma.Load += new EventHandler(TuFormulario_Load);         
            forma.Text = documento.PDF.Name;
            return forma;
        }
        

        private const string TempPdfFileName = "temp.pdf";

        private async void TuFormulario_Load(object sender, EventArgs e)
        {
            try
            {
                // Inicializa WebView2
                await forma.webView21.EnsureCoreWebView2Async();
                DocumentoPDF documentoPDF = documento.hasDocumento() ? documento : visorDocumentosService.getDocumentoPDFApliado(documento.Id);
                byte[] pdfData = documentoPDF.PDF.Data;

                // Verifica si hay datos PDF para cargar
                if (pdfData != null && pdfData.Length > 0)
                {
                    // Guardar el PDF en un archivo temporal en una ubicación fija
                    string tempFilePath = Path.Combine(Path.GetTempPath(), TempPdfFileName);
                    File.WriteAllBytes(tempFilePath, pdfData);

                    // Crear un URI del archivo temporal
                    string fileUri = new Uri(tempFilePath).AbsoluteUri;

                    // Navegar al URI del archivo
                    forma.webView21.CoreWebView2.Navigate(fileUri);
                }
                else
                {
                    MessageBox.Show("No se han proporcionado datos de PDF para cargar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }  
    }
}

