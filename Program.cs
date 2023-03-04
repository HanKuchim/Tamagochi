using System;
using System.Collections.Concurrent;

namespace Тамагочи
{
    internal class Program
    {
        static void Main(string[] args) //все написано на английском потому что у меня ноутбук работает на английской винде
        {
            Console.WriteLine("Cat name:");
            string name = Console.ReadLine();
            Console.WriteLine("Cat Healh");
            int healh = int.Parse(Console.ReadLine());
            Cat mycat = new Cat(name, healh);
            while (mycat.IsAlive())
            {
                Console.WriteLine("What do you want to do with cat? \n 1:Feed the cat \n 2: Meow! \n 3:Playing \n 4: Cat info \n");
                ConsoleKey key = Console.ReadKey().Key;
                Console.WriteLine();
                ConsoleKey key1;
                switch (key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine();
                        Console.WriteLine("What do you want to feed the cat?");
                        Console.WriteLine("Enter food name:");
                        string type = Console.ReadLine();
                        Console.WriteLine("How much satiety food got?");
                        int heath = int.Parse(Console.ReadLine());
                        Food newfood = new Food { heath = heath, type = type };
                        DoMeal(mycat, newfood);
                        mycat.Meow();
                        break;
                    case ConsoleKey.D2:
                        mycat.Meow();
                        break;

                    case ConsoleKey.D4:
                        Cat.Info(mycat);
                        break;

                    case ConsoleKey.D3:
                        Console.WriteLine("How do you want to play with your cat?");
                        Console.WriteLine("1: Play with a toy \n 2: Running for a toy mouse \n");
                        key1 = Console.ReadKey().Key;
                        switch (key1)
                        {
                            case ConsoleKey.D1:
                                mycat.Play();
                                break;
                            case ConsoleKey.D2:
                                mycat.Run();
                                break;
                        }

                        break;

                }
            }
            static void DoMeal(Cat c, Food f)
            {
                c.Eat(f); // кошка {имя кошки} съела еду
            }
        }
    }
}