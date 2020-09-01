using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace ConsoleApp1
{
    public class Bank
    {
        private readonly object locker = new object();

        private int _money;
        public int Money
        {
            get { return _money; }
            set { UpdateProperty(ref _money, value); }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { UpdateProperty(ref _name, value); }
        }

        private int _percent;
        public int Percent
        {
            get { return _percent; }
            set { UpdateProperty(ref _percent, value); }
        }

        private void UpdateProperty<T>(ref T oldValue, T newValue)
        {
            if (!oldValue?.Equals(newValue) ?? newValue != null)
            {
                oldValue = newValue;
                Thread thread = new Thread(LogData);
                thread.Start();
                thread.Join();
            }
        }

        private void LogData()
        {
            lock (locker)
            {
                string props = $"at {DateTime.Now}(thread-{Thread.CurrentThread.ManagedThreadId}) : {nameof(Money)}={Money} , {nameof(Name)}={Name} , {nameof(Percent)}={Percent}\n";
                using (FileStream fs = new FileStream("../../log.txt", FileMode.OpenOrCreate))
                {
                    fs.Seek(0, SeekOrigin.End);
                    fs.Write(Encoding.UTF8.GetBytes(props), 0, props.Length);
                }
            }


        }
    }
    class Program
    {
        private static void PrintCollection(object obj)
        {
            (obj as List<string>).ForEach(i => Console.WriteLine($"{i} - {Thread.CurrentThread.ManagedThreadId}"));
        }
        private static void Main(string[] args)
        {
            Thread thread = new Thread(new ParameterizedThreadStart((obj) => (obj as List<string>).ForEach(i => Console.WriteLine($"{i} - {Thread.CurrentThread.ManagedThreadId}"))));
            thread.Start(new List<string> { "1", "2", "3", "4", "5", "6", "7" });
            
            Bank bank = new Bank { Name = "", Money = 0, Percent = 0 };
            bank.Percent = 3;
            bank.Name = "Unprivate bank";
            bank.Money = 2000;
            

            Console.ReadKey();
        }
    }
}