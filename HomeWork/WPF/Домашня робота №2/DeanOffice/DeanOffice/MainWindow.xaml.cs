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
using DeanOffice.ViewModels;
using DeanOffice.DataModels;

namespace DeanOffice
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        FacultiesViewModel vm = new FacultiesViewModel();
        GroupsViewModel gvm = new GroupsViewModel();
        StudentsViewModel svm = new StudentsViewModel();

        public MainWindow()
        {
            InitializeComponent();
            LoadFaculties();
        }

        public void LoadFaculties()
        {
            vm.LoadData();
            if (vm.Faculties.Count > 0)
            {
                fList.ItemsSource = vm.Faculties;
                fList.DisplayMemberPath = "Name";
                fList.SelectedValuePath = "Id";
                fList.SelectedIndex = 0;
            }
        }

        public void LoadGroups(int fid)
        {
            gvm.LoadData(fid);
            if (gvm.Groups.Count > 0)
            {
                gList.ItemsSource = gvm.Groups;
                gList.DisplayMemberPath = "Name";
                gList.SelectedValuePath = "Id";
            }
        }

        public void LoadStudents(int gid)
        {
            svm.LoadData(gid);
            if (svm.Students.Count > 0)
            {
                sList.ItemsSource = svm.Students;
                sList.DisplayMemberPath = "Name";
                sList.SelectedValuePath = "Id";
            }
        }

        private void FAdd_Click(object sender, RoutedEventArgs e)
        {
            string name = fName.Text;
            if (String.IsNullOrEmpty(name))
            {
                MessageBox.Show("Вы не ввели название факультета!",
                    "Предупреждение!", MessageBoxButton.OK,
                    MessageBoxImage.Warning);
            }
            else
            {
                Faculty faculty = new Faculty() { Name = name };
                vm.AddFaculty(faculty);
                MessageBox.Show($"Факультет {name} - успешно добавлен!",
                    "Сообщение!", MessageBoxButton.OK,
                    MessageBoxImage.Information);
                fName.Clear();
                LoadFaculties();
            }
        }

        private void FDel_Click(object sender, RoutedEventArgs e)
        {
            int k = fList.SelectedIndex;
            if (k > -1)
            {
                int fid = (int)fList.SelectedValue;
                string name = (fList.SelectedItem as Faculty).Name;
                MessageBoxResult res =
                    MessageBox.Show($"Вы подтверждаете удаление факультета:\n{name}?",
                        "Подтверждение операции", MessageBoxButton.YesNo,
                        MessageBoxImage.Question);
                if (res == MessageBoxResult.Yes)
                {
                    vm.DelFaculty(fid);
                    MessageBox.Show($"Факультет {name}\nуспешно удален!",
                        "Сообщение", MessageBoxButton.OK,
                        MessageBoxImage.Question);
                    LoadFaculties();
                }
            }
        }

        private void FList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (fList.SelectedIndex > -1)
            {
                int fid = (int)fList.SelectedValue;
                LoadGroups(fid);
            }
        }

        private void GList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (gList.SelectedIndex > -1)
            {
                int gid = (int)gList.SelectedValue;
                LoadStudents(gid);
            }
        }

        private void SList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sList.SelectedIndex > -1)
            {
                Student student = sList.SelectedItem as Student;
                sName.Text = student.Name;
                sAddr.Text = student.Address;
                sPhone.Text = student.Phone;
                sContacts.Text = student.Contacts;
                sGrades.Text = student.Grades;
                sInfo.Text = student.Info;
            }
        }

        private void GAdd_Click(object sender, RoutedEventArgs e)
        {
            if (fList.SelectedIndex > -1)
            {
                int fid = (int)fList.SelectedValue;
                string name = gName.Text;
                if (String.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Вы не ввели название группы!",
                        "Предупреждение!", MessageBoxButton.OK,
                        MessageBoxImage.Warning);
                }
                else
                {
                    Group group = new Group() { Name = name, FacultyId = fid};
                    gvm.AddGroup(group);
                    MessageBox.Show($"Группа {name} - успешно добавлена!",
                        "Сообщение!", MessageBoxButton.OK,
                        MessageBoxImage.Information);
                    gName.Clear();
                    LoadGroups(fid);
                }
            }
        }

        private void GDel_Click(object sender, RoutedEventArgs e)
        {
            int k = gList.SelectedIndex;
            if (k > -1)
            {
                int gid = (int)gList.SelectedValue;
                string name = (gList.SelectedItem as Group).Name;
                MessageBoxResult res =
                    MessageBox.Show($"Вы подтверждаете удаление группы:\n{name}?",
                        "Подтверждение операции", MessageBoxButton.YesNo,
                        MessageBoxImage.Question);
                if (res == MessageBoxResult.Yes)
                {
                    gvm.DelGroup(gid);
                    MessageBox.Show($"Группа {name}\nуспешно удалена!",
                        "Сообщение", MessageBoxButton.OK,
                        MessageBoxImage.Question);
                    LoadFaculties();
                }
            }
        }

        private void SAdd_Click(object sender, RoutedEventArgs e)
        {
            if(gList.SelectedIndex > -1)
            {
                int gid = (int)gList.SelectedValue;
                string name = sName.Text, address = sAddr.Text, phone = sPhone.Text, contacts = sContacts.Text, grades = sGrades.Text, info = sInfo.Text;
                if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(address) || String.IsNullOrEmpty(phone) || String.IsNullOrEmpty(contacts) || String.IsNullOrEmpty(grades) || String.IsNullOrEmpty(info))
                {
                    MessageBox.Show("Вы не заполнили одно или несколько обязательных полей для информации про студента!",
                        "Предупреждение!", MessageBoxButton.OK,
                        MessageBoxImage.Warning);
                }
                else
                {

                    Student student = new Student() { Name = name, Address = address, Phone = phone, Contacts = contacts, Grades = grades, Info = info, GroupId = gid };
                    svm.AddStudent(student);
                    MessageBox.Show($"Студент {name} - успешно добавлен!",
                        "Сообщение!", MessageBoxButton.OK,
                        MessageBoxImage.Information);
                    ClearFieldsOfStudentsInfo();
                    LoadStudents(gid);
                }
            }
        }

        private void SDel_Click(object sender, RoutedEventArgs e)
        {
            int k = sList.SelectedIndex, g = gList.SelectedIndex;
            if (k > -1 && g > -1)
            {
                int sid = (int)sList.SelectedValue;
                int gid = (int)gList.SelectedValue;
                string name = (sList.SelectedItem as Student).Name;
                MessageBoxResult res =
                    MessageBox.Show($"Вы подтверждаете удаление студента:\n{name}?",
                        "Подтверждение операции", MessageBoxButton.YesNo,
                        MessageBoxImage.Question);
                if (res == MessageBoxResult.Yes)
                {
                    svm.DelStudent(sid);
                    MessageBox.Show($"Студент {name}\nуспешно удален!",
                        "Сообщение", MessageBoxButton.OK,
                        MessageBoxImage.Question);
                    ClearFieldsOfStudentsInfo();
                    LoadStudents(gid);
                }
            }
        }

        private void SEdit_Click(object sender, RoutedEventArgs e)
        {
            int k = sList.SelectedIndex, g = gList.SelectedIndex;
            if (k > -1 && g > -1)
            {
                int sid = (int)sList.SelectedValue;
                int gid = (int)gList.SelectedValue;
                Student student = sList.SelectedItem as Student;
                MessageBoxResult res =
                    MessageBox.Show($"Вы подтверждаете редактирование данных студента:\n{student.Name}?",
                        "Подтверждение операции", MessageBoxButton.YesNo,
                        MessageBoxImage.Question);
                if (res == MessageBoxResult.Yes)
                {
                    string name = sName.Text, address = sAddr.Text, phone = sPhone.Text, contacts = sContacts.Text, grades = sGrades.Text, info = sInfo.Text;
                    if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(address) || String.IsNullOrEmpty(phone) || String.IsNullOrEmpty(contacts) || String.IsNullOrEmpty(grades) || String.IsNullOrEmpty(info))
                    {
                        MessageBox.Show("Вы не заполнили одно или несколько обязательных полей для информации про студента!",
                            "Предупреждение!", MessageBoxButton.OK,
                            MessageBoxImage.Warning);
                    }
                    else
                    {
                        student.Name = name;
                        student.Address = address;
                        student.Phone = phone;
                        student.Contacts = contacts;
                        student.Grades = grades;
                        student.Info = info;
                        svm.EditStudent(student);
                        MessageBox.Show($"Данные студента {student.Name}\nуспешно редактированы!",
                            "Сообщение", MessageBoxButton.OK,
                            MessageBoxImage.Question);
                        ClearFieldsOfStudentsInfo();
                        LoadStudents(gid);
                    }
                }
            }
        }

        private void SReset_Click(object sender, RoutedEventArgs e)
        {
            ClearFieldsOfStudentsInfo();
        }

        private void ClearFieldsOfStudentsInfo()
        {
            sName.Clear();
            sAddr.Clear();
            sPhone.Clear();
            sContacts.Clear();
            sGrades.Clear();
            sInfo.Clear();
        }
    }
}
