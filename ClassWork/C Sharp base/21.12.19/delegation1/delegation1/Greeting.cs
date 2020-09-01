﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegation1
{
    delegate string GreetingDelegate();
    class Greeting
    {
        GreetingDelegate[] gd;
        public GreetingDelegate this[int index]
        {
            get => gd[index];
        }
        public Greeting()
        {
            gd = new GreetingDelegate[]
            {
                GoodMorning, GoodAfternoon, GoodEvening, GoodNight
            };
        }
        public string GoodMorning()
        {
            return "Доброе утро!";
        }
        public string GoodAfternoon()
        {
            return "Добрый день!";
        }
        public string GoodEvening()
        {
            return "Добрый вечер!";
        }
        public string GoodNight()
        {
            return "Доброй ночи!";
        }
    }
}
