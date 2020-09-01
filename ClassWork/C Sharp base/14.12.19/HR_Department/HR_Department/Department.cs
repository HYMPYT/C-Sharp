using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Department
{
    [Serializable]
    class Department
    {
        public string Name { get; set; }
        public List<Employe> Employes { get; set; } = new List<Employe>();

        public void AddEmploye(Employe emp)
        {
            Employes.Add(emp);
        }
        public void DelEmploye(string name)
        {
            foreach(Employe emp in Employes)
            {
                if(emp.Name == name)
                {
                    Employes.Remove(emp);
                    break;
                }
            }
        }
        public void Display()
        {
            int N = Employes.Count;
            if(N == 0)
            {
                Console.WriteLine("В отделе нет сотрудников");
            }
            else
            {
                Console.WriteLine($"Отдел - {Name}");
                Console.WriteLine("---------------------------------------");
                int i = 0;
                foreach (var item in Employes)
                {
                    i++;
                    Console.WriteLine($"{i}. {item}");
                }

            }
        }
    }
}
