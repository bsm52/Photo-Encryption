using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.IO;
using Microsoft.Win32;
using System.Windows.Media;

namespace Photo_Encryption
{
   public static class StyleChanger
    {
        public static double LabelSize = 0;
        public static Brush LabelColor = Brushes.Lime;

        public static void ChangeFontColor(Brush color)
        {
            LabelColor = color;

            Style style = new Style { TargetType = typeof(Label) };

            style.Setters.Add(new Setter(Control.FontSizeProperty, LabelSize));
            style.Setters.Add(new Setter(Label.BackgroundProperty, LabelColor));

            Application.Current.Resources["LabelStyle"] = style;
        }

        public static void ChangeLabelSize(double size)
        {
            LabelSize = size;

            Style style = new Style { TargetType = typeof(Label) };

            style.Setters.Add(new Setter(Control.FontSizeProperty, size));
            style.Setters.Add(new Setter(Label.BackgroundProperty, LabelColor));

            Application.Current.Resources["LabelStyle"] = style;
        }
    }
}
