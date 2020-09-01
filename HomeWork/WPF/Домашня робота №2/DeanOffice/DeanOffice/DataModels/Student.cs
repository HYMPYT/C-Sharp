using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DeanOffice.DataModels
{
    public class Student : INotifyPropertyChanged
    {
        private int id;
        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged("Id");
            }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        private string address;
        public string Address
        {
            get { return address; }
            set
            {
                address = value;
                OnPropertyChanged("Address");
            }
        }

        private string phone;
        public string Phone
        {
            get { return phone; }
            set
            {
                phone = value;
                OnPropertyChanged("Phone");
            }
        }

        private string contacts;
        public string Contacts
        {
            get { return contacts; }
            set
            {
                contacts = value;
                OnPropertyChanged("Contacts");
            }
        }

        private int groupId;
        public int GroupId
        {
            get { return groupId; }
            set
            {
                groupId = value;
                OnPropertyChanged("GroupId");
            }
        }

        private string grades;
        public string Grades
        {
            get { return grades; }
            set
            {
                grades = value;
                OnPropertyChanged("Grades");
            }
        }

        private string info;
        public string Info
        {
            get { return info; }
            set
            {
                info = value;
                OnPropertyChanged("Info");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
