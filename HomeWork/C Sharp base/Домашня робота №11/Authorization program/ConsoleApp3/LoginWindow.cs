using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class LoginWindow
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public bool Entrance(string login, string password)
        {
            Login = login;
            Password = password;
            if (Login == "" || Password == "")
            {
                Console.WriteLine("Вы не ввели исходные данные!");
                return false;
            }
            else
            {
                return true;
            }
        }
        public void Registration(string login, string password, Application app)
        {
            if (login == "" || password == "")
            {
                Console.WriteLine("Вы не ввели исходные данные!");
            }
            else
            {
                app.Logins.Add(login);
                app.Passwords.Add(password);
                Console.Clear();
                Console.WriteLine("Вы успешно зарегистрированы");
            }
        }
    }
}
