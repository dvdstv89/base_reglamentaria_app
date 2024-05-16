using System.Windows.Forms;

namespace BRapp.UI
{
    public interface IForm
    { 
        void configurarFormularioComoPanel();
        Form getForm();
        bool viewHasScrolls();
        void hide();       
    }
}
