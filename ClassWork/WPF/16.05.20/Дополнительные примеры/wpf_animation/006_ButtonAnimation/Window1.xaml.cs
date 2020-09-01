using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Media.Animation;

namespace ButtonAnimation
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, MouseEventArgs e)
        {
            ColorAnimation cAnim = new ColorAnimation();
            cAnim.To = Brushes.Orange.Color;
            cAnim.Duration = new Duration(new TimeSpan(0, 0, 0, 1));
            B1.BeginAnimation(SolidColorBrush.ColorProperty, cAnim);
        }

        private void button1_MouseLeave(object sender, MouseEventArgs e)
        {
            ColorAnimation cAnim = new ColorAnimation();
            cAnim.To = Brushes.Black.Color;
            B1.BeginAnimation(SolidColorBrush.ColorProperty, cAnim);
        }
    }
}
