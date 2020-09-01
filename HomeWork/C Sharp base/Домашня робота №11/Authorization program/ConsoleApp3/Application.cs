using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Application
    {
        public List<string> Logins { get; set; } = new List<string>();
        public List<string> Passwords { get; set; } = new List<string>();
        public Application()
        {
            Logins.Add("admin");
            Passwords.Add("adminadmin");
        }
        public void AppLoad(string login, string password)
        {
            int login_id = -1, password_id = -1;
            LoginWindow lw = new LoginWindow();
            if (lw.Entrance(login, password))
            {
                for (int i = 0; i < Logins.Count; i++)
                {
                    if (Logins[i] == login)
                    {
                        login_id = i;
                        break;
                    }
                }
                for (int i = 0; i < Passwords.Count; i++)
                {
                    if (Passwords[i] == password)
                    {
                        password_id = i;
                        break;
                    }
                }
                if (login_id == password_id && login_id != -1 && password_id != -1)
                {
                    Console.Clear();
                    Console.WriteLine("Вы успешно авторизованы! Добро пожаловать!");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("В доступе отказано!");
                }
            }
        }
        public void PrintLogin()
        {
            foreach(var l in Logins)
            {
                Console.WriteLine(l);
            }
        }
        public void PrintPassword()
        {
            foreach (var p in Passwords)
            {
                Console.WriteLine(p);
            }
            {

            }
        }
    }
}
