using System;
using static System.Console;
using System.Threading;
using Restaurant.Domain;
using System.Collections.Generic;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            RestaurantX restaurant = new RestaurantX("MaxDonalds");

            bool shouldNotExit = true;

            while (shouldNotExit)
            {
                WriteLine("1. Add order");
                WriteLine("2. List orders");
                WriteLine("3. Exit");

                ConsoleKeyInfo keyPressed = ReadKey(true);

                Clear();

                switch (keyPressed.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:

                        Write("Dish: ");
                        string dish = ReadLine();

                        Write("Table: ");
                        string table = ReadLine();

                        Order order = new Order(dish, table);

                        restaurant.RegisterOrder(order);

                        Clear();

                        WriteLine("Order registered");
                        Thread.Sleep(2000);

                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:



                        

                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:

                        shouldNotExit = false;

                        break;
                }

                Clear();
            }

        }
    }
}
