using System;
using System.Windows.Forms;

namespace BRapp.UIControlers.CardUCController
{
    internal interface ICard
    {       
        Object getObject();
        bool isSelected();      
        void setInfo();
        UserControl get();
    }
}
