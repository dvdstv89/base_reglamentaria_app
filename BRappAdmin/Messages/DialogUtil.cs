using System.Windows.Forms;

namespace BRappAdmin.Messages
{
    internal static class DialogUtil
    {
        public static void EXCEPTION(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void INFORMATION(string message)
        {
            MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
