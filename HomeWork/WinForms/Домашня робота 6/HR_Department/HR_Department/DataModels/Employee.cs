using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Department.DataModels
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Viber { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public string Skills { get; set; }
        public int DepartmentId { get; set; }
    }
}
