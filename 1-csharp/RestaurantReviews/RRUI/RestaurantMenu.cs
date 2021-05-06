using System;
using RRModels;
using RRBL;
using System.Collections.Generic;
namespace RRUI
{
    public class RestaurantMenu : IMenu
    {
        private IRestaurantBL _restaurantBL;
        private IValidationService _validation;
        public RestaurantMenu(IRestaurantBL restaurantBL, IValidationService validation)
        {
            _restaurantBL = restaurantBL;
            _validation = validation;
        }
        public void Start()
        {
            bool repeat = true;
            do
            {
                Console.WriteLine("Welcome to my Restaurant Menu!");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("[0] View restaurants");
                Console.WriteLine("[1] Add a restaurant");
                Console.WriteLine("[2] Go back");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "0":
                        ViewRestaurants();
                        break;
                    case "1":
                        AddRestaurant();
                        break;
                    case "2":
                        repeat = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            } while (repeat);
        }
        private void ViewRestaurants()
        {
            //TODO: Remove the hardcoded restaurant and refer to a stored restaurant that exists
            List<Restaurant> restaurants = _restaurantBL.GetAllRestaurants();
            if (restaurants.Count == 0) Console.WriteLine("No restaurants :<");
            else
            {
                foreach (Restaurant restaurant in restaurants)
                {
                    Console.WriteLine(restaurant.ToString());
                }
            }
        }
        private void AddRestaurant()
        {
            Console.WriteLine("Please enter the restaurant details of the restaurant you want to add");
            string name = _validation.ValidString("Name: ");
            string city = _validation.ValidString("City: ");
            string state = _validation.ValidString("State: ");
            try
            {
                Restaurant newRestaurant = _restaurantBL.AddRestaurant(new Restaurant(name, city, state));
                Console.WriteLine("Restaurant added!");
                Console.WriteLine(newRestaurant.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                AddRestaurant();
            }
        }
    }
}