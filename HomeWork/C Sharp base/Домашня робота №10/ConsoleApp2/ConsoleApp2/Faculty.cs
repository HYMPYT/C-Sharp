using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    [Serializable]
    class Faculty
    {
        public string Name { get; set; }
        public List<Group> Groups { get; set; } = new List<Group>();
        public int FindGroup(string name)
        {
            int pos = 0;
            foreach (Group item in Groups)
            {
                if (item.Name == name)
                    return pos;
                pos++;
            }
            return -1;
        }
        public void AddGroup(Group gr)
        {
            Groups.Add(gr);
        }
        public void DelGroup(string name)
        {
            foreach (Group gr in Groups)
            {
                if(gr.Name == name)
                {
                    Groups.Remove(gr);
                    break;
                }
            }
        }
        public void Display()
        {
            int N = Groups.Count();
            if(N == 0)
            {
                Console.WriteLine("На факультете нету групп.");
            }
            else
            {
                Console.WriteLine($"{Name}");
                Console.WriteLine("---------------------------------------");
                int i = 0;
                foreach (Group gr in Groups)
                {
                    Console.WriteLine($"{++i}. {gr.Name}");
                }
            }
        }
    }
}
