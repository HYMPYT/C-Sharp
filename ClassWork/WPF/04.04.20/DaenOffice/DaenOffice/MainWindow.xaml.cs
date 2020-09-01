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
using DaenOffice.DataModels;

namespace DaenOffice
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        FacultiesViewModel fvm = new FacultiesViewModel();
        GroupsViewModel gvm = new GroupsViewModel();
        StudentsViewModel svm = new StudentsViewModel();

        public MainWindow()
        {
            InitializeComponent();
            LoadFaculties();
        }

        public void LoadFaculties()
        {
            fvm.LoadData();
            if (fvm.Faculties.Count > 0)
            {
                FList.ItemsSource = fvm.Faculties;
                FList.DisplayMemberPath = "Name";
                FList.SelectedValuePath = "Id";
                FList.SelectedIndex = 0;
            }
        }

        public void LoadGroups(int fid)
        {
            gvm.LoadData(fid);
            if(gvm.Groups.Count > 0)
            {
                GList.ItemsSource = gvm.Groups;
                GList.DisplayMemberPath = "Name";
                GList.SelectedValuePath = "Id";
            }
        }

        public void LoadStudents(int gid)
        {
            svm.LoadData(gid);
            if(svm.Students.Count > 0)
            {
                SList.ItemsSource = svm.Students;
                SList.DisplayMemberPath = "Name";
                SList.SelectedValuePath = "Id";
            }
        }

        private void FAddBtn_Click(object sender, RoutedEventArgs e)
        {
            string name = FName.Text;
            if (String.IsNullOrEmpty(name))
            {
                MessageBox.Show("Вы не ввели название факультета!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                Faculty faculty = new Faculty() { Name = name };
                fvm.AddFaculty(faculty);
                MessageBox.Show($"Факультет {name} успешно добавлен.", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                FName.Clear();
                LoadFaculties();
            }
        }

        private void FDelBtn_Click(object sender, RoutedEventArgs e)
        {
            int k = FList.SelectedIndex;
            if(k > -1)
            {
                int fid = (int)FList.SelectedValue;
                string name = (FList.SelectedItem as Faculty).Name;
                MessageBoxResult res = MessageBox.Show($"Вы подтверждаете удаление факультета:\n{name}?", "Подтверждение операции", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if(res == MessageBoxResult.Yes)
                {
                    fvm.DelFaculty(fid);
                    MessageBox.Show($"Факультет {name} успешно удален.", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                    LoadFaculties();
                }
            }
        }

        private void FList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int fid = (int)FList.SelectedValue;
            LoadGroups(fid);
        }

        private void GList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int gid = (int)GList.SelectedValue;
            LoadStudents(gid);
        }

        private void SList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Student student = SList.SelectedItem as Student;
            SName.Text = student.Name;
            SAddr.Text = student.Address;
            SPhone.Text = student.Phone;
            SContact.Text = student.Contacts;
            SGrades.Text = student.Grades;
            SInfo.Text = student.Info;
        }
    }
}
