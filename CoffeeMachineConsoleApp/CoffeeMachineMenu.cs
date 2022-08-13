using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    public class CoffeeMachineMenu
    {
        CoffeeMachine coffeeMachine = new CoffeeMachine();

        public void Menu()
        {
            string option = "";

            while (option != "1" && option != "2" && option != "3")
            {
                Console.WriteLine("Welcome to the CoffeeMatic! What kind of coffee should we do now?");
                Console.WriteLine("1. Espresso");
                Console.WriteLine("2. Filtered");
                Console.WriteLine("3. Cappuccino");
                option = Console.ReadLine();
                Console.Clear();
            }

            int opt = Convert.ToInt32(option);

            PresentSomeCoffee(MakeSomeCoffee(opt));
        }

        public static void ProgressBar()
        {
            Console.WriteLine();
            for(int i = 0; i < 5; i++)
            {
                Console.Write("[]");
                Thread.Sleep(300);
            }
            Console.Clear();
        }

        private Coffee MakeSomeCoffee(int option)
        {
            CoffeeMachineMenu.ProgressBar();

            if(option == 1)
            {
                return this.coffeeMachine.Brew(coffeeMachine._recipes[RecipeName.Espresso]);
            }

            else if (option == 2)
            {
                return this.coffeeMachine.Brew(coffeeMachine._recipes[RecipeName.Filtered]);
            }

            else
            {
                return this.coffeeMachine.Brew(coffeeMachine._recipes[RecipeName.Cappuccino]);
            }
        }

        private void PresentSomeCoffee(Coffee coffee)
        {
            Console.WriteLine("Your coffee is done!");
            Console.WriteLine("It is:"); 
            Console.WriteLine("              " + "\n" +
                              "    ____      " + "\n" +
                              "   /    \\    " + "\n" +
                              "  |\\____/|   " + "\n" +
                              "  |!!!!!!|=|  " + "\n" +
                              "  |!!!!!!| |  " + "\n" +
                              "  |!!!!!!|=|  " + "\n" +
                              "  \\______/   ");
            Console.WriteLine(coffee.recipe.name + "!");
        }
    }
}
