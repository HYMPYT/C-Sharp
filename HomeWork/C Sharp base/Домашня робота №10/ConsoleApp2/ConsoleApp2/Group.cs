using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    [Serializable]
    class Group
    {
        public string Name { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
        public void AddStudent(Student st)
        {
            Students.Add(st);
        }
        public void DelStudent(string name)
        {
            foreach (Student st in Students)
            {
                if (st.Name == name)
                {
                    Students.Remove(st);
                    break;
                }
            }
        }
        public void Display()
        {
            int N = Students.Count();
            if (N == 0)
            {
                Console.WriteLine("В группе нет студентов.");
            }
            else
            {
                Console.WriteLine($"Группа - {Name}");
                Console.WriteLine("---------------------------------------");
                int i = 0;
                foreach(Student st in Students)
                {
                    Console.WriteLine($"{++i}. {st}");
                }
            }
        }
    }
}
