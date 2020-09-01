using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Department
{
    [Serializable]
    class Company
    {
        public string Name { get; set; }
        public List<Department> Departments { get; set; } = new List<Department>();

        public void AddDepartment(Department dep)
        {
            Departments.Add(dep);
        }
        public void Display()
        {
            int N = Departments.Count;
            if(N == 0)
            {
                Console.WriteLine("В компании нет отделов");
            }
            else
            {
                Console.WriteLine($"Компания - {Name}");
                Console.WriteLine("---------------------------------------");
                int i = 0;
                foreach (var item in Departments)
                {
                    i++;
                    Console.WriteLine($"{i}. {item.Name}");
                }
            }
        }
    }
}
