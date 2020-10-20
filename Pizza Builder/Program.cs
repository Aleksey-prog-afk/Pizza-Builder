using Pizza_Builder.Builder;
using Pizza_Builder.Pizza;
using System;
using System.Reflection.Metadata.Ecma335;

namespace Pizza_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string number = "";
            IBuilder pizzabuilder = null;
            while (pizzabuilder == null) 
            {
                Console.WriteLine("Choose pizza: \nMargarita (1)\nItalian (2)\nPepperoni (3)\nCarbonara (4)");
                number = Console.ReadLine();
                switch (number)
                {
                    case "1":
                        {
                            pizzabuilder = new MargaritaBuilder();
                            break;
                        }
                    case "2":
                        {
                            pizzabuilder = new ItalianBuilder();
                            break;
                        }
                    case "3":
                        {
                            pizzabuilder = new PepperoniBuilder();
                            break;
                        }
                    case "4":
                        {
                            pizzabuilder = new CarbonaraBuilder();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Write number");
                            break;

                        }
                }
            }

            Console.WriteLine("You choosed {0} pizza with ingridients: ", pizzabuilder.createPizza().GetType().Name);
            foreach(var ingridient in pizzabuilder.createPizza().Ingridients)
            {
                Console.WriteLine("\t {0}", ingridient);
            }
            Console.WriteLine("Would you like to add extra ingridients? (y/n)");
            string answer = "";
            APizza pizza = null;
            while (answer != "y" && answer != "n")
            {
                answer = Console.ReadLine();
                switch (answer)
                {
                    case "y":
                        {
                            pizza = constructPizza(pizzabuilder);
                            break;
                        }
                    case "n":
                        {
                            pizza = pizzabuilder.createPizza();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Type 'n' or 'y'");
                            break;
                        }
                }
            }
            Console.WriteLine("Enjoy your {0} pizza with ingridients: ", pizza.GetType().Name);
            foreach (var ingridient in pizza.Ingridients)
            {
                Console.WriteLine("\t {0}", ingridient);
            }
        }
        static APizza constructPizza(IBuilder pizzabuilder)
        {
            string number = "";
            while (number != "exit")
            {
                Console.WriteLine("Choose ingridients to add: \nCheese(1)\nTomatos(2)\nOlives(3)\nMeat(4)");
                number = Console.ReadLine();
                switch (number)
                {
                    case "1":
                        {
                            pizzabuilder.addCheese();
                            break;
                        }
                    case "2":
                        {
                            pizzabuilder.addTomatos();
                            break;
                        }
                    case "3":
                        {
                            pizzabuilder.addOlives();
                            break;
                        }
                    case "4":
                        {
                            pizzabuilder.addMeat();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Write number or exit");
                            break;

                        }
                    case "exit": break;
                }
            }
            return pizzabuilder.createPizza();
        }
    }
}
