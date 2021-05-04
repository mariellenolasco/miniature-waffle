using System;
namespace RRUI
{
    public class MainMenu : IMenu
    {
        public void Start()
        {
            bool repeat = true;
            Console.WriteLine("Welcome to Restuarant Reviews!");
            Console.WriteLine("[0] Add a restaurant");
            Console.WriteLine("[1] Exit");
            string input = Console.ReadLine();
            do
            {
                switch (input)
                {
                    case "0":
                        AddARestaurant();
                        break;
                    case "1":
                        repeat = false;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option!");
                        break;
                }
            } while (repeat);

        }
        public void AddARestaurant()
        {
            Console.WriteLine();
        }
    }
}