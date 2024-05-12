using System;
using System.Drawing;

namespace BRapp
{
    internal static class ColorUtil
    {       
        public static Color TranslateColor(String color)
        {
            return ColorTranslator.FromHtml(color);
        }
    }
}
