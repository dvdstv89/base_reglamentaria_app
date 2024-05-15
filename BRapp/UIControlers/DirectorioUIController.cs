using BRapp.Data;
using BRapp.Enums.EnumFiltroBusqueda;
using BRapp.Model;
using BRapp.Services.Interfaces;
using BRapp.Services.Services;
using BRapp.UI;
using BRapp.UI.Cards;
using BRapp.UIControlers.CardUCController;
using BRapp.Utiles;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BRapp.UIControlers
{
    internal class DirectorioUIController : BaseUIController<DirectorioUI>, IForm
    {
        private static DirectorioUIController instance;
        private readonly IDirectorioService iDirectorioService;
        List<ICard> contactos = new List<ICard>();
        ButtonSeleccionado botonActivo = null;
        TipoContactoBusqueda tipoContactoBusqueda;
        FiltroPaginaContactos filtroPaginaContactos;
        private readonly Dictionary<RadioButton, TipoContactoBusqueda> radioButtonMappings = new Dictionary<RadioButton, TipoContactoBusqueda>();
        private readonly Dictionary<ToolStripMenuItem, FiltroPaginaContactos> menuItemMappings = new Dictionary<ToolStripMenuItem, FiltroPaginaContactos>();

        private DirectorioUIController() : base(new DirectorioUI(), true)
        {
            iDirectorioService = DirectorioService.Instance;
            radioButtonMappings.Add(forma.radioButtonTodos, TipoContactoBusqueda.TODOS);
            radioButtonMappings.Add(forma.radioButtonInterno, TipoContactoBusqueda.INTERNO);
            radioButtonMappings.Add(forma.radioButtonExterno, TipoContactoBusqueda.EXTERNO);
            menuItemMappings.Add(forma.todosToolStripMenuItem, FiltroPaginaContactos.TODOS);
            menuItemMappings.Add(forma.favoritosToolStripMenuItem, FiltroPaginaContactos.FAVORITOS);
            menuItemMappings.Add(forma.aToolStripMenuItem, FiltroPaginaContactos.A);
            menuItemMappings.Add(forma.bToolStripMenuItem, FiltroPaginaContactos.B);
            menuItemMappings.Add(forma.cToolStripMenuItem, FiltroPaginaContactos.C);
            menuItemMappings.Add(forma.dToolStripMenuItem, FiltroPaginaContactos.D);
            menuItemMappings.Add(forma.eToolStripMenuItem, FiltroPaginaContactos.E);
            menuItemMappings.Add(forma.fToolStripMenuItem, FiltroPaginaContactos.F);
            menuItemMappings.Add(forma.gToolStripMenuItem, FiltroPaginaContactos.G);
            menuItemMappings.Add(forma.hToolStripMenuItem, FiltroPaginaContactos.H);
            menuItemMappings.Add(forma.iToolStripMenuItem, FiltroPaginaContactos.I);
            menuItemMappings.Add(forma.jToolStripMenuItem, FiltroPaginaContactos.J);
            menuItemMappings.Add(forma.kToolStripMenuItem, FiltroPaginaContactos.K);
            menuItemMappings.Add(forma.lToolStripMenuItem, FiltroPaginaContactos.L);
            menuItemMappings.Add(forma.mToolStripMenuItem, FiltroPaginaContactos.M);
            menuItemMappings.Add(forma.nToolStripMenuItem, FiltroPaginaContactos.N);
            menuItemMappings.Add(forma.nnToolStripMenuItem, FiltroPaginaContactos.NN);
            menuItemMappings.Add(forma.oToolStripMenuItem, FiltroPaginaContactos.O);
            menuItemMappings.Add(forma.pToolStripMenuItem, FiltroPaginaContactos.P);
            menuItemMappings.Add(forma.qToolStripMenuItem, FiltroPaginaContactos.Q);
            menuItemMappings.Add(forma.rToolStripMenuItem, FiltroPaginaContactos.R);
            menuItemMappings.Add(forma.sToolStripMenuItem, FiltroPaginaContactos.S);
            menuItemMappings.Add(forma.tToolStripMenuItem, FiltroPaginaContactos.T);
            menuItemMappings.Add(forma.uToolStripMenuItem, FiltroPaginaContactos.U);
            menuItemMappings.Add(forma.vToolStripMenuItem, FiltroPaginaContactos.V);
            menuItemMappings.Add(forma.wToolStripMenuItem, FiltroPaginaContactos.W);
            menuItemMappings.Add(forma.xToolStripMenuItem, FiltroPaginaContactos.X);
            menuItemMappings.Add(forma.yToolStripMenuItem, FiltroPaginaContactos.Y);
            menuItemMappings.Add(forma.zToolStripMenuItem, FiltroPaginaContactos.Z);
        }

        protected override void forma_Load(object sender, EventArgs e)
        {
            forma.menuStrip1.Layout += centrarMenu;
            foreach (var radioButton in radioButtonMappings.Keys)
            {
                radioButton.CheckedChanged += RadioButton_CheckedChanged;
            }

            foreach (var menuItem in menuItemMappings.Keys)
            {
                menuItem.Click += ButtonToolStripMenuItem_Click;
            }

            tipoContactoBusqueda = TipoContactoBusqueda.TODOS;
            filtrarContacto(forma.todosToolStripMenuItem);           
            base.forma_Load(sender, e);
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton radioButton && radioButtonMappings.ContainsKey(radioButton) && (sender as RadioButton).Checked)
            {
                tipoContactoBusqueda = radioButtonMappings[radioButton];
                LLenarListaContactos();
            }
        }

        private void ButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem menuItem && menuItemMappings.ContainsKey(menuItem))
            {
                filtrarContacto(menuItem);
            }
        }   
        
        private void filtrarContacto(ToolStripMenuItem toolStripMenuItem)
        {
            filtroPaginaContactos = menuItemMappings[toolStripMenuItem];
            cambiarBotonActivo(new ButtonSeleccionado(toolStripMenuItem));
            LLenarListaContactos();
        }
     
        private void LLenarListaContactos()
        {
            List<Persona> contactosAux = iDirectorioService.filtrarContactos(tipoContactoBusqueda, filtroPaginaContactos);
            forma.flowLayoutContactos.Controls.Clear();
            foreach (Persona contact in contactosAux)
            {
                ICard card = getICardContacto(contact);
                card.setInfo();
                renderICard(card);            
                contactos.Add(card);
            }
            for (int i = 0; i < 3; i++)
            {
                ExtraSpaceCard card = new ExtraSpaceCard();
                forma.flowLayoutContactos.Controls.Add(card);
            }
        }
        private ICard getICardContacto(Persona contact)
        {
            return (contact is PersonaNatural) ? (ICard) new PersonaNaturalUCController(contact as PersonaNatural)
                                               : (ICard) new PersonaJuridicaUCController(contact as PersonaJuridica);
        }
        private void renderICard(ICard iCard)
        {
            if(iCard is PersonaNaturalUCController)
                forma.flowLayoutContactos.Controls.Add(iCard.get() as PersonaNaturalCard);
            else
                forma.flowLayoutContactos.Controls.Add(iCard.get() as PersonaJuridicaCard);
        }
        private void cambiarBotonActivo(ButtonSeleccionado button)
        {
            if (botonActivo != null)
            {
                botonActivo.desmarcarBoton();
                botonActivo.getButton().ForeColor = Color.Black;
            }
            botonActivo = button;
            if (botonActivo != null)
            {
                botonActivo.marcarBoton();
            }
        }

        protected void centrarMenu(object sender, LayoutEventArgs e)
        {
            int totalWidth = 0;
            foreach (ToolStripItem item in forma.menuStrip1.Items)
            {
                totalWidth += item.Width;
            }

            int espacioWidth = (forma.menuStrip1.Width - totalWidth) / 2;

            forma.menuStrip1.Padding = new Padding(espacioWidth, 0, espacioWidth, 0);
        }
        public static DirectorioUIController Instance
        {
            get
            {
                instance = (instance == null) ? new DirectorioUIController() : instance;      
                return instance;
            }
        }       
    }
}
