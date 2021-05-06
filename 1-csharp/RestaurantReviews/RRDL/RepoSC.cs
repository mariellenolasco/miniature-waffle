using System.Collections.Generic;
using RRModels;
using System.Linq;
namespace RRDL
{
    //Implementation of the IRepository that stores data in a static collection
    public class RepoSC : IRepository
    {
        public Restaurant AddARestaurant(Restaurant restaurant)
        {
            RRSCStorage.Restaurants.Add(restaurant);
            return restaurant;
        }

        public List<Restaurant> GetAllRestaurants()
        {
            return RRSCStorage.Restaurants;
        }

        public Restaurant GetRestaurant(Restaurant restaurant)
        {
            return RRSCStorage.Restaurants.FirstOrDefault(r => r.Equals(restaurant));
        }
    }
}