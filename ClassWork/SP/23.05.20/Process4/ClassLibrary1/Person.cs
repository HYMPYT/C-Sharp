using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public enum FamilyStatus { Married, Single };
    [Serializable]
    public class Person
    {
        string name;
        string lastName;
        int age;
        FamilyStatus status;
        public Person(string name, string lastName, int age)
        {
            this.name = name;
            this.lastName = lastName;
            this.age = age;
            status = FamilyStatus.Single;
        }

        public virtual void Display()
        {
            Console.WriteLine($"Person: {name} {lastName}\nAge: {age} years");
        }
    }
}
