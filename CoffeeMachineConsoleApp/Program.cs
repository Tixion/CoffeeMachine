﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffeeMachineMenu CMMenu = new CoffeeMachineMenu();

            CMMenu.Menu();
        }
    }
}