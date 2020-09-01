﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace События
{
    //public delegate void NotificationType(string msg);
    class MyEventArgs : EventArgs
    {
        public string Message { get; set; }
    }

    class News
    {
        public event EventHandler<MyEventArgs> Notification;
        //public event NotificationType Notification;
        /*public void Notify(string msg)
        {
            Notification?.Invoke(msg);
        }*/
        public void Notify(string msg)
        {
            Notification?.Invoke(this, new MyEventArgs { Message = msg });
        }
    }
    class Subscriber
    {
        public string Name { get; set; }
        //public void GetNotification(string msg)
        //{
        //    Console.WriteLine($"{Name} has got notification. \n Message: {msg}\n");
        //}
        public void GetNotification(object s, MyEventArgs e)
        {
            Console.WriteLine($"{Name} has got notification.\nMessage: {e.Message}\n");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            News obj = new News();
            Subscriber a = new Subscriber { Name = "Ivan" };
            Subscriber b = new Subscriber { Name = "Masha" };
            Subscriber c = new Subscriber { Name = "Petya" };
            obj.Notification += a.GetNotification;
            obj.Notification += b.GetNotification;
            obj.Notification += c.GetNotification;
            obj.Notification += b.GetNotification;
            obj.Notification += (s, e) => { Console.WriteLine($"Someone has got a message {e.Message}\n"); };
            obj.Notify("3.5 weeks to New Year");
        }
    }
}
