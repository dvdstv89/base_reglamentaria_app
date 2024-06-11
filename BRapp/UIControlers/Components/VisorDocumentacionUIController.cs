using BRapp.Data;
using BRapp.Model;
using BRapp.Model.Tiendas;
using BRapp.Services.Interfaces;
using BRapp.UI.Cards;
using BRapp.UI.Component;
using BRapp.UIControlers.CardUCController;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BRapp.UIControlers.Components
{

    internal class VisorDocumentacionUIController : BaseUIController<VisorDocumentacionUI>
    {
        private readonly IVisorDocumentacionService visorDocumentosService;
        private readonly IVisorDocumentacion res61;
     

        public VisorDocumentacionUIController(IVisorDocumentacion res61) : base(new VisorDocumentacionUI())
        {
            this.res61 = res61;
            visorDocumentosService = AplicationConfig.Component.VisorDocumentacionService;            
        }

        public bool IsEmptyRtf(string rft)
        {
            return visorDocumentosService.IsEmptyRft(rft) || String.IsNullOrEmpty(rft);
        }

        public override VisorDocumentacionUI ejecutar()
        {                      
            forma.Load += new EventHandler(forma_Load);
            return forma;
        }

        protected override void initDataForm()
        {
            if (res61.GetTipoGrupoDocumentacion().Count == 0)
            {
                llenarListaGrupoTiendas();
            }
            else
            {               
                llenarListaDocumentos();
            }           
        }

        private void llenarListaGrupoTiendas()
        {           
            forma.panelCard.Visible = false;
            forma.panelText.Visible = true;          
            forma.panelText.Dock = DockStyle.Fill;
            forma.richTextBox1.Rtf = res61.GetDescripcionRft();            
        }
        private void llenarListaDocumentos()
        {
            forma.panelText.Visible = false;            
            forma.panelCard.Visible = true;
            forma.panelCard.Dock = DockStyle.Fill;          

            forma.panelDepartamentos.Controls.Clear();
            foreach (TipoGrupoDocumentacion tipo in res61.GetTipoGrupoDocumentacion())
            {              
                Label encabezadoLabel = createLabel(tipo);
                forma.panelDepartamentos.Controls.Add(encabezadoLabel); 
                ProcesarTipoGrupoDocumentacion(tipo);
            }
        }
        private Label createLabel(TipoGrupoDocumentacion tipo)
        {
            Label encabezadoLabel = new Label();
            encabezadoLabel.Text = tipo.Name;
            encabezadoLabel.AutoSize = false;
            encabezadoLabel.Dock = DockStyle.Top;
            encabezadoLabel.TextAlign = ContentAlignment.MiddleLeft;
            encabezadoLabel.BackColor = Color.LightGray;
            encabezadoLabel.Height = 30;
            encabezadoLabel.Width = 590;
            encabezadoLabel.Font = Utiles.Styles.MyFontStyle.MAIN_MENU_FONT_BUTTON_SELECTED;
            return encabezadoLabel;
        }


        private void ProcesarTipoGrupoDocumentacion(TipoGrupoDocumentacion tipo)
        {
            List<GrupoDocumentacion> grupoDocumentacions = visorDocumentosService.GetGrupoDocumentacion(tipo);          
            int order = 0;           
            foreach (GrupoDocumentacion grupo in grupoDocumentacions)
            {
                ICard card = new DocumentacionUCController(grupo, ++order);
                card.setInfo();
                Control control = card.get();
                control.Tag = grupo;
                control.Dock = DockStyle.Top;
                forma.panelDepartamentos.Controls.Add(control);
            }
            ExtraSpaceCard extraCard = new ExtraSpaceCard();
            forma.panelDepartamentos.Controls.Add(extraCard);
        }
    }
}

