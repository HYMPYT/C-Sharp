using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DaenOffice.ViewModels;

namespace DaenOffice
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        FacultiesViewModel vm = new FacultiesViewModel();

        public MainWindow()
        {
            InitializeComponent();
            vm.LoadData();
            FList.ItemsSource = vm.Faculties;
            FList.DisplayMemberPath = "Name";
            FList.SelectedValuePath = "Id";
            FList.SelectedIndex = 0;
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
