using BRapp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BRapp.UI.Cards
{
    internal partial class ExtraSpaceCard : UserControl
    {

        public ExtraSpaceCard()
        {
            InitializeComponent();
        }

        public void SetContactInfo()
        {
           
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ExtraSpaceCard
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "ExtraSpaceCard";
            this.Size = new System.Drawing.Size(480, 10);
            this.ResumeLayout(false);

        }
    }
}
