using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace ConsoleApp2
{
    class DataManager
    {
        BinaryFormatter bf = new BinaryFormatter();
        public University Data { get; set; } = new University();
        string path = @"..\..\university.dat";
        public void InitData()
        {
            Student st1 = new Student { Name = "Василий Пупкин", Age = 21 };
            Student st2 = new Student { Name = "Лиза Пупкина", Age = 27 };
            Group group = new Group { Name = "КВ-83" };
            group.AddStudent(st1);
            group.AddStudent(st2);
            Faculty faculty = new Faculty { Name = "Факультет прикладной математики" };
            faculty.AddGroup(group);
            Data.AddFaculty(faculty);
            Data.Name = "Киевский политехнический институт";
        }
        public void SaveData()
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                bf.Serialize(fs, Data);
            }
        }
        public void LoadData()
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
            {
                Data = (University)bf.Deserialize(fs);
            }
        }
    }
}
