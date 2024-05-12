using System.Windows.Forms;

namespace BRapp.Utiles
{
    internal static class DialogUtil
    {
        public static void EXCEPTION(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
