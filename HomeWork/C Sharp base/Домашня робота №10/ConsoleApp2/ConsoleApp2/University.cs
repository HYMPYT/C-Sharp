using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    [Serializable]
    class University
    {
        public string Name { get; set; }
        public List<Faculty> Faculties { get; set; } = new List<Faculty>();
        public int FindFaculty(string name)
        {
            int pos = 0;
            foreach (Faculty item in Faculties)
            {
                if(item.Name == name)
                {
                    return pos;
                }
                pos++;
            }
            return -1;
        }
        public void AddFaculty(Faculty faculty)
        {
            Faculties.Add(faculty);
        }
        public void DelFaculty(string name)
        {
            foreach (Faculty item in Faculties)
            {
                if(item.Name == name)
                {
                    Faculties.Remove(item);
                    break;
                }
            }
        }
        public void Display()
        {
            int N = Faculties.Count();
            if (N == 0)
            {
                Console.WriteLine("В университете нет факультетов.");
            }
            else
            {
                Console.WriteLine($"Унверситет - {Name}");
                Console.WriteLine("---------------------------------------");
                int i = 0;
                foreach (Faculty faculty in Faculties)
                {
                    Console.WriteLine($"{++i}. {faculty.Name}");
                }
            }
        }
    }
}
