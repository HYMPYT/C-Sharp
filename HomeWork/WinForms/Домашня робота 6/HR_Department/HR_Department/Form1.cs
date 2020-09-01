using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using HR_Department.DataManagers;
using HR_Department.DataModels;

namespace HR_Department
{
    public partial class Form1 : Form
    {
        DepManager dm = new DepManager();
        EmpManager em = new EmpManager();

        public Form1()
        {
            InitializeComponent();
        }

        private void DisplayDepartments()
        {
            dm.LoadDep();
            DepList.Items.Clear();
            foreach (Department dep in dm.Departments)
            {
                DepList.Items.Add(dep);
            }
            DepList.DisplayMember = "Name";
            if (DepList.Items.Count > 0)
                DepList.SelectedIndex = 0;
        }

        private void DisplayEmployees()
        {
            Department d = (Department)DepList.SelectedItem;
            em.LoadEmp(d.Name);
            foreach (Employee emp in em.Employees)
            {
                EmpList.Items.Add(emp);
            }
            EmpList.DisplayMember = "Name";
            if (EmpList.Items.Count > 0)
                EmpList.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayDepartments();
        }

        private void DepList_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmpList.Items.Clear();
            DisplayEmployees();
        }

        private void EmpList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Employee emp = (Employee)EmpList.SelectedItem;
            NameBox.Text = emp.Name;
            BirthDate.Value = emp.Birthday;
            EmailBox.Text = emp.Email;
            PhoneBox.Text = emp.Phone;
            ViberBox.Text = emp.Viber;
            PositionBox.Text = emp.Position;
            SalaryBox.Maximum = decimal.ToInt32(emp.Salary);
            SalaryBox.Value = decimal.ToInt32(emp.Salary);
            SkillsBox.Text = emp.Skills;
        }

        private void AddDep_Click(object sender, EventArgs e)
        {

        }

        private void DelDep_Click(object sender, EventArgs e)
        {

        }

        private void AddEmp_Click(object sender, EventArgs e)
        {

        }

        private void DelEmp_Click(object sender, EventArgs e)
        {

        }

        private void Reset_Click(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {

        }
    }
}
