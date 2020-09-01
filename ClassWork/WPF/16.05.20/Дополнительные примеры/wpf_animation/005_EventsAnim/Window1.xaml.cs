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

namespace EventsAnim
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        int a = 0;
        public Window1()
        {
            InitializeComponent();

            LabLab2_Completed(null, null);
        }

        void LabLab1_Completed(object sender, EventArgs e)
        {
            DoubleAnimation LabLab2 = new DoubleAnimation();
            LabLab2.Duration = new Duration(new TimeSpan(0, 0, 0, 0, 1000));
            LabLab2.To = 1;
            LabLab2.Completed += new EventHandler(LabLab2_Completed);
            if (a == 0)
            {
                label1.Content = "У Вас";
                a = 1;
            }
            else if(a == 1)
            {
                label1.Content = "Не";
                a = 2;
            }
            else if (a == 2)
            {
                label1.Content = "Загеристрированная";
                a = 3;
            }
            else if (a == 3)
            {
                label1.Content = "Копия";
                a = 4;
            }
            else if (a == 4)
            {
                label1.Content = "Программы";
                a = 5;
            }
            else if (a ==5)
            {
                label1.Content = "Вы";
                a = 6;
            }
            else if (a == 6)
            {
                label1.Content = "Редиска";
                a = 0;
            }
            
            label1.BeginAnimation(Label.OpacityProperty, LabLab2);
        }

        void LabLab2_Completed(object sender, EventArgs e)
        {
            DoubleAnimation LabLab1 = new DoubleAnimation();
            LabLab1.To = 0;
            LabLab1.Duration = new Duration(new TimeSpan(0, 0, 0, 0, 1000));
            LabLab1.Completed += new EventHandler(LabLab1_Completed);
            label1.BeginAnimation(Label.OpacityProperty, LabLab1);
        }

    }
}
