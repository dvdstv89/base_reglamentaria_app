using BRapp.Model;
using BRapp.Model.Tiendas;
using BRapp.Services.Interfaces;
using BRapp.Services.Services;
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
        private readonly IRes61 res61;
        private readonly Resolucion resolucion61;

        public VisorDocumentacionUIController(IRes61 res61) : base(new VisorDocumentacionUI())
        {
            this.res61 = res61;
            visorDocumentosService = VisorDocumentacionService.Instance;
            resolucion61 = visorDocumentosService.getRes61();
        }

        public override VisorDocumentacionUI ejecutar()
        {           
            forma.btnResolucion61.Click += new EventHandler(btnResolucion61_Click);
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
                forma.panelHeader.Visible = res61.GetTipoGrupoDocumentacion()[0].TipoIndicacion == Enums.TipoIndicacion.RESOLUCION61;
                llenarListaDocumentos();
            }           
        }

        private void llenarListaGrupoTiendas()
        {
            forma.panelHeader.Visible = false;
            forma.panelCard.Visible = false;
            forma.panelText.Visible = true;          
            forma.panelText.Dock = DockStyle.Fill;
            forma.richTextBox1.Rtf = res61.GetDescripcionRft();            
        }

        private void llenarListaDocumentos()
        {
            forma.panelText.Visible = false;
            forma.panelHeader.Visible = true;
            forma.panelCard.Visible = true;
            forma.panelCard.Dock = DockStyle.Fill;

            forma.lbResolucion61.Text = resolucion61.ToString();
            forma.btnResolucion61.IconChar = resolucion61.getIcono();
          

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
            List<GrupoDocumentacion> grupoDocumentacions = visorDocumentosService.getGrupoDocumentacion(tipo);          
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



        private void btnResolucion61_Click(object sender, EventArgs e)
        {
            ResolucionUCController resolucionUCController = new ResolucionUCController(resolucion61);
            resolucionUCController.setInfo();
            var CardDialogUIController = new CardDialogUIController(resolucionUCController);
            CardDialogUIController.showDialog();
        }
    }
}

