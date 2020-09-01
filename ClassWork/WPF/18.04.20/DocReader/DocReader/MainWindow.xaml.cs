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
using System.Xml;
using System.IO;
using System.Windows.Markup;

namespace DocReader
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SwitchProvider(string key)
        {
            XmlDataProvider provider = FindResource(key) as XmlDataProvider;
            Binding b = new Binding() { Source = provider };
            BindingOperations.SetBinding(Context, TreeView.ItemsSourceProperty, b);
        }

        private void UserGuide_Click(object sender, RoutedEventArgs e)
        {
            SwitchProvider("Provider1");
        }

        private void AdminGuide_Click(object sender, RoutedEventArgs e)
        {
            SwitchProvider("Provider2");
        }

        private void DevGuide_Click(object sender, RoutedEventArgs e)
        {
            SwitchProvider("Provider3");
        }

        private void Context_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            var tree = sender as TreeView;
            var item = tree.SelectedItem as XmlElement;
            string name = item.Attributes["name"].Value;
            string path = $@"..\..\Pages\{name}.xaml";

            if(File.Exists(path))
            {
                using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    Reader.Document = XamlReader.Load(fs) as FlowDocument;
                }
            }
            else
            {
                MessageBox.Show("Файл не найден!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
