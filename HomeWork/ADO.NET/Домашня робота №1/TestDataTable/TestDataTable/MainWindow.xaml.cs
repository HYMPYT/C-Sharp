using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Если сформулировать задание коротко, то оно будет звучать так.
/// При вводе в командное текстовое поле трех разных запросов select, приложение должно создать три вкладки.
/// На каждой вкладке создать элемент ListView и отобразить в этом элементе результаты выполнения одного из введенных запросов.
/// </summary>
namespace TestDataTable
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CustomView _cv = new CustomView();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void CreateCustomListViewInNewTab(string cmd = null)
        {
            try
            {
                DataTable curDt;
                if (cmd == null)
                    curDt = _cv.ExecuteQuery(tbCommand.Text);
                else
                    curDt = _cv.ExecuteQuery(cmd);

                ListView lv = new ListView();
                lv.SetBinding(ListView.ItemsSourceProperty, new Binding() { Source = curDt });
                GridView gv = new GridView();

                foreach (var col in curDt.Columns)
                {
                    gv.Columns.Add(new GridViewColumn
                    {
                        Header = col.ToString(),
                        DisplayMemberBinding = new Binding(col.ToString())
                    });
                }

                lv.View = gv;
                TabItem ti = new TabItem();
                ti.Header = $"Tab-{tcQueries.Items.Count}";
                ti.Content = lv;
                ti.ToolTip = new ToolTip().Content = "Press Delete to close selected tab.";
                tcQueries.Items.Add(ti);
                if (!string.IsNullOrEmpty(tbCommand.Text.Trim(' ')) && cmd == null)
                {
                    MenuItem mi = new MenuItem();
                    mi.Header = tbCommand.Text;
                    mi.Click += new System.Windows.RoutedEventHandler(this._cmMenuItemClicked);
                    _cm.Items.Add(mi);
                }
            }
            catch (SqlException sex)
            {
                MessageBox.Show(sex.Message, "Warning!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnExec_Click(object sender, RoutedEventArgs e)
        {
            CreateCustomListViewInNewTab();
        }

        private void tbCommand_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                CreateCustomListViewInNewTab();
        }

        private void _cmMenuItemClicked(object sender, RoutedEventArgs e)
        {
            CreateCustomListViewInNewTab(((MenuItem)sender).Header.ToString());
        }

        private void tcQueries_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Delete)
                foreach (TabItem item in tcQueries.Items)
                    if (item.IsSelected)
                    {
                        tcQueries.Items.Remove(item);
                        break;
                    }
        }
    }
}