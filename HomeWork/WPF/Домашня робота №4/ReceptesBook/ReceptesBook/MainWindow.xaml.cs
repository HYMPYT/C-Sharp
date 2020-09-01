using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Markup;
using System.Xml;

namespace ReceptesBook
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
            Binding b = new Binding()
            {
                Source = provider,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
            };
            BindingOperations.SetBinding(Context, TreeView.ItemsSourceProperty, b);
        }

        private void UkrainianCuisine_Click(object sender, RoutedEventArgs e)
        {
            SwitchProvider("Provider1");
        }

        private void RussianCuisine_Click(object sender, RoutedEventArgs e)
        {
            SwitchProvider("Provider2");
        }

        private void Context_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            try
            {
                var tree = sender as TreeView;
                var item = tree.SelectedItem as XmlElement;
                string name = item.Attributes["name"].Value;
                string path = @"..\..\Pages\" + name + ".xaml";

                if (File.Exists(path))
                {
                    using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                    {
                        Reader.Document = XamlReader.Load(fs) as FlowDocument;
                    }
                }
                else
                {
                    MessageBox.Show("Файл не найден!", "Предупреждение", MessageBoxButton.OK,
                        MessageBoxImage.Warning);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.StackTrace, "Ошибка выполнения", MessageBoxButton.OK,
                        MessageBoxImage.Error);
            }
        }
    }
}
