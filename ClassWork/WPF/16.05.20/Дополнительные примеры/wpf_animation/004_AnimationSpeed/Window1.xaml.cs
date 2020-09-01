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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AnimationSpeed
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation WinAni = new DoubleAnimation();
            WinAni.To = 900;
            WinAni.Duration =new Duration( new TimeSpan(0, 0, 0, 1));
            this.BeginAnimation(Window.WidthProperty, WinAni);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation WinAni = new DoubleAnimation();
            WinAni.To = 900;
            WinAni.Duration = new Duration(new TimeSpan(0, 0, 0, 1));

            WinAni.AccelerationRatio = 0.4; // До когда ускорять
            WinAni.DecelerationRatio = 0.5; // Когда начинать замедление.
            WinAni.SpeedRatio = 4; // Скорость значение 1 нормальная скорость.
            this.BeginAnimation(Window.WidthProperty, WinAni);
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation WinAni = new DoubleAnimation();
            WinAni.To = 286;
            WinAni.Duration = new Duration(new TimeSpan(0, 0, 0, 0,100));
            this.BeginAnimation(Window.WidthProperty, WinAni);
        }
    }
}
