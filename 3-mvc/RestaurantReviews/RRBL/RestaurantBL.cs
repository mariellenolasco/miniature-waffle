using System.Collections.Generic;
using RRModels;
using RRDL;
using System;

namespace RRBL
{
    /// <summary>
    /// Business logic class for the restaurant model
    /// </summary>
    public class RestaurantBL : IRestaurantBL
    {
        // Some things to note:
        // BL classes are in charge of processing/ sanitizing/ further validating data
        // As the name suggests its in charge of processing logic. For example, how does the ordering process
        // work in a store app. 
        // Any logic that is related to accessing the data stored somewhere, should be relegated to the DL 
        private IRepository _repo;
        public RestaurantBL(IRepository repo)
        {
            _repo = repo;
        }

        public Restaurant AddRestaurant(Restaurant restaurant)
        {
            // Todo: call a repo method that adds a restaurant
            if (_repo.GetRestaurant(restaurant) != null)
            {
                throw new Exception("Restaurant already exists :<");
            }
            return _repo.AddRestaurant(restaurant);
        }

        public Restaurant DeleteRestaurant(Restaurant restaurant)
        {
            Restaurant toBeDeleted = _repo.GetRestaurant(restaurant);
            if (toBeDeleted != null) return _repo.DeleteRestaurant(toBeDeleted);
            else throw new Exception("Restaurant does not exist. Must've been deleted already :>");
        }

        public List<Restaurant> GetAllRestaurants()
        {
            //Note that this method isn't really dependent on any inputs/parameters, I can just directly call the 
            // DL method in charge of getting all restaurants
            return _repo.GetAllRestaurants();
        }

        public Restaurant GetRestaurant(Restaurant restaurant)
        {
            return _repo.GetRestaurant(restaurant);
        }

        public Restaurant GetRestaurantById(int id)
        {
            return _repo.GetRestaurantById(id);
        }
    }
}