using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BRapp.UI.Component
{
    public partial class ProgressBarUI : Form
    {
        public ProgressBarUI()
        {
            InitializeComponent();
        }      

        public void SetMessage(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(SetMessage), message);
            }
            else
            {
                labelMensaje.Text = message;
            }
        }
    }
}
