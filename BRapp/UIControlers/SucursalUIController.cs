using BRapp.UI;
using System.Collections.Generic;
using BRapp.Services.Interfaces;
using BRapp.Model.Tiendas;
using System.IO;
using System.Drawing;
using BRapp.Model;
using BRapp.UI.Cards;
using BRapp.UIControlers.CardUCController;
using System.Windows.Forms;
using BRapp.Data;
using FontAwesome.Sharp;
using BRapp.Utiles;
using System.Xml.Linq;
using System.ComponentModel;
using System;
using BRapp.UIControlers.Components;

namespace BRapp.UIControlers
{
    internal class SucursalUIController : BaseUIController<SucursalUI>, IForm
    {       
        private static Dictionary<Complejo, SucursalUIController> instances = new Dictionary<Complejo, SucursalUIController>();        
        private readonly ITiendaService tiendaService;
        private readonly IDepartamentoService departamentoService;
        private readonly ISucursalService sucursalService;
        private readonly IVisorDocumentacionService visorDocumentosService;
        private readonly Complejo complejo;
        private List<Tienda> tiendas;
        private ImageList imageList;
        private SucursalUIController(Complejo complejo) : base(new SucursalUI(), true)
        {
            this.complejo = complejo;
            tiendaService = AplicationConfig.Component.TiendaService;
            departamentoService = AplicationConfig.Component.DepartamentoService;
            sucursalService = AplicationConfig.Component.SucursalService;
            visorDocumentosService = AplicationConfig.Component.VisorDocumentacionService;
        }

        public override SucursalUI ejecutar()
        {
            base.ejecutar();
            InitializeImageList();
            forma.treeView1.NodeMouseDoubleClick += new TreeNodeMouseClickEventHandler(Node_DoubleClick);
            forma.treeView1.BeforeCollapse += new TreeViewCancelEventHandler(treeView1_BeforeCollapse);
            forma.treeView1.BeforeExpand += new TreeViewCancelEventHandler(treeView1_BeforeExpand);
            forma.treeView1.ImageList = imageList;
            forma.treeView1.ShowNodeToolTips = true;
            return forma;
        }       

        protected override void aplicarTema()
        {         
            if (complejo.hasImagen())
            {
                forma.iconPictureBox1.Visible= false;
                forma.pictureBoxOrganigramaEmpresa.BackgroundImage = Image.FromStream(new MemoryStream(complejo.Organigrama.Data));
            }           

            if (complejo.TipoComplejo == Enums.TipoComplejo.SUCURSAL)
            {
                forma.panelTiendasHeader.Visible = false;
                App app = app = sucursalService.GetApp();
                forma.richTextBoxMision.Rtf = app.Mision;
                forma.richTextBoxVision.Rtf = app.Vision;
                forma.richTextBoxValoresCompartidos.Rtf = app.ValoresCompartidos;
                forma.richTextBoxObjetoSocialIzquierdo.Rtf = app.ObjetoSocial;
            }
            else
            {
                forma.panelSucursal.Visible = false;              
                tiendas = tiendaService.GetTiendasByComplejo(complejo);               
            }
            LLenarArbolDepartamentos();
        }

        private void LLenarArbolDepartamentos()
        {
            int trucateValue = 38;
            forma.treeView1.Nodes.Clear();
            List<Departamento> departamentos = departamentoService.GetDepartamentosByComplejo(complejo);
            foreach (Departamento departamento in departamentos)
            {
                AddDynamicIconsToImageList(departamento.getIcono());
                string textoCompleto = departamento.ToString();
                string textoTruncado = TruncateString(textoCompleto, trucateValue) + " (" + departamento.CantidadTrabajadores + "T)";
                TreeNode node = new TreeNode
                {
                    Tag = departamento,
                    Text = textoTruncado,
                    ImageKey = departamento.getIcono().ToString(),
                    SelectedImageKey = departamento.getIcono().ToString(),
                    NodeFont = new Font(forma.treeView1.Font.FontFamily, 12)
                };
                if (textoCompleto.Length > trucateValue)
                {
                    node.ToolTipText = textoCompleto;
                }
                if (departamento.DepartamentoTipo == Enums.TipoDepartamento.GRUPO_TIENDA)
                {
                    node.Nodes.AddRange(LLenarArbolTiendas(departamento).ToArray());
                }
                else
                {                  
                    node.Nodes.AddRange(llenarListaGruposDocumentacion(departamento.GetTipoGrupoDocumentacion(), trucateValue).ToArray());
                }
                forma.treeView1.Nodes.Add(node);
            }           
        }

        private List<TreeNode> llenarListaGruposDocumentacion(List<TipoGrupoDocumentacion> tipos, int trucateValue)
        {
            List<TreeNode> treeNodeList = new List<TreeNode>();         

            if (tipos.Count == 1)
            {
                return LlenarDocumentos(tipos[0], trucateValue);
            }

            foreach (TipoGrupoDocumentacion tipo in tipos)
            {
                AddDynamicIconsToImageList(tipo.getIcono());
                TreeNode node = new TreeNode
                {
                    Tag = tipo,
                    Text = tipo.ToString(),
                    ImageKey = tipo.getIcono().ToString(),
                    SelectedImageKey = tipo.getIcono().ToString(),
                    NodeFont = new Font(forma.treeView1.Font.FontFamily, 10)
                };
                node.Nodes.AddRange(LlenarDocumentos(tipo, trucateValue-5).ToArray());
                treeNodeList.Add(node);
            }
            return treeNodeList;
        }

        private List<TreeNode> LLenarArbolTiendas(Departamento departamento)
        {
            List<TreeNode> treeNodeList = new List<TreeNode>();
            foreach (Tienda tienda in tiendas)
            {
                if (tienda.Departamento != null && tienda.Departamento.Id == departamento.Id)
                {
                    AddDynamicIconsToImageList(tienda.getIcono());
                    TreeNode node = new TreeNode
                    {
                        Tag = tienda,
                        Text = tienda.ToString(),
                        ImageKey = tienda.getIcono().ToString(),
                        SelectedImageKey = tienda.getIcono().ToString(),
                        NodeFont = new Font(forma.treeView1.Font.FontFamily, 10)
                    };
                    node.Nodes.AddRange(llenarListaGruposDocumentacion(tienda.GetTipoGrupoDocumentacion(), 50).ToArray());
                    treeNodeList.Add(node);
                }
            }
            return treeNodeList;
        }

        private List<TreeNode> LlenarDocumentos(TipoGrupoDocumentacion tipo, int trucateValue)
        {
            List<TreeNode> treeNodeList = new List<TreeNode>();
            List<GrupoDocumentacion> grupoDocumentacions = visorDocumentosService.GetGrupoDocumentacion(tipo);
            tipo.TieneDocumentos = grupoDocumentacions.Count > 0;
            foreach (GrupoDocumentacion grupo in grupoDocumentacions)
            {
                AddDynamicIconsToImageList(grupo.getIcono());
                string textoCompleto = grupo.ToString();
                string textoTruncado = TruncateString(textoCompleto, trucateValue);

                TreeNode node = new TreeNode
                {
                    Tag = grupo,
                    Text = textoTruncado,
                    ImageKey = grupo.getIcono().ToString(),
                    SelectedImageKey = grupo.getIcono().ToString(),
                    NodeFont = new Font(forma.treeView1.Font.FontFamily, 10)
                };
                if (textoCompleto.Length > trucateValue)
                {
                    node.ToolTipText = textoCompleto;
                }
                treeNodeList.Add(node);
            }
            return treeNodeList;
        }

        private void Node_DoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {           
            TreeNode selectedNode = e.Node;
            if (selectedNode != null && selectedNode.Tag is GrupoDocumentacion)
            {
                GrupoDocumentacion grupo = (GrupoDocumentacion)selectedNode.Tag;
                DocumentoUCController documentoUCController = new DocumentoUCController(grupo.Documento);
                documentoUCController.setInfo();
                var CardDialogUIController = new CardDialogUIController(documentoUCController);
                CardDialogUIController.showDialog();
            }
            else if(selectedNode != null && selectedNode.Tag is Departamento)
            {
                Departamento departamento = (Departamento)selectedNode.Tag;
                if (departamento.GetTipoGrupoDocumentacion().Count == 0 && departamento.DepartamentoTipo != Enums.TipoDepartamento.GRUPO_TIENDA)
                {
                    var visorDocumentacionUIController = new VisorDocumentacionUIController(departamento);
                    if(!visorDocumentacionUIController.IsEmptyRtf(departamento.GetDescripcionRft()))
                         visorDocumentacionUIController.showDialog();
                }
            }
            else if (selectedNode != null && selectedNode.Tag is TipoGrupoDocumentacion)
            {
                TipoGrupoDocumentacion grupo = (TipoGrupoDocumentacion)selectedNode.Tag;
                if (!grupo.TieneDocumentos)
                {
                    var visorDocumentacionUIController = new VisorDocumentacionUIController(grupo);
                    if (!visorDocumentacionUIController.IsEmptyRtf(grupo.GetDescripcionRft()))
                        visorDocumentacionUIController.showDialog();
                }
            } else if (selectedNode != null && selectedNode.Tag is Tienda)
            {
                Tienda tienda = (Tienda)selectedNode.Tag;
                TiendaUCController tiendaUCController = new TiendaUCController(tienda);
                tiendaUCController.setInfo();
                var CardDialogUIController = new CardDialogUIController(tiendaUCController);
                CardDialogUIController.showDialog();
            }
        }  

        private void AddDynamicIconsToImageList(IconChar iconChar)
        {           
            imageList.Images.Add(iconChar.ToString(), ImageManager.GetFontAwesomeIconImage(iconChar, 32, Color.Black));
        }

        private void InitializeImageList()
        {
            imageList = new ImageList
            {
                ImageSize = new Size(32, 32), // Tamaño de imagen más grande
                ColorDepth = ColorDepth.Depth32Bit // Mejor calidad de colo
            };
        }

        private string TruncateString(string value, int maxLength)
        {
            if (value.Length > maxLength)
            {
                return value.Substring(0, maxLength) + "..."; // Truncar el texto y agregar puntos suspensivos               
            }
            else
            {
                return value;
            }
        }

        private void treeView1_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            if (!IsClickOnPlusMinus(e.Node))
            {
                e.Cancel = true;
            }
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (!IsClickOnPlusMinus(e.Node))
            {
                e.Cancel = true;
            }
        }
        private bool IsClickOnPlusMinus(TreeNode node)
        {
            // Obtener la posición actual del ratón
            Point pt = forma.treeView1.PointToClient(Control.MousePosition);
            TreeViewHitTestInfo info = forma.treeView1.HitTest(pt);

            // Verificar si la posición del ratón está en el icono de expansión (+/-)
            return info.Location == TreeViewHitTestLocations.PlusMinus;
        }

        public static SucursalUIController GetInstance(Complejo complejo)
        {          
            return new SucursalUIController(complejo);
        }       
    }
}
