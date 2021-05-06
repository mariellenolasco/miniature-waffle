using System.Collections.Generic;
using RRModels;
using System.IO;
using System.Text.Json;
using System;
using System.Linq;
namespace RRDL
{
    public class RepoFile : IRepository
    {
        private string jsonString;
        private const string filepath = "../RRDL/Restaurants.json";

        public List<Restaurant> GetAllRestaurants()
        {
            try
            {
                jsonString = File.ReadAllText(filepath);
            }
            catch (Exception)
            {
                return new List<Restaurant>();
            }
            return JsonSerializer.Deserialize<List<Restaurant>>(jsonString);
        }

        public Restaurant AddARestaurant(Restaurant restaurant)
        {
            List<Restaurant> restaurantsFromFile = GetAllRestaurants();
            restaurantsFromFile.Add(restaurant);
            jsonString = JsonSerializer.Serialize(restaurantsFromFile);
            File.WriteAllText(filepath, jsonString);
            return restaurant;
        }

        public Restaurant GetRestaurant(Restaurant restaurant)
        {
            return GetAllRestaurants().FirstOrDefault(r => r.Equals(restaurant));
        }
    }
}