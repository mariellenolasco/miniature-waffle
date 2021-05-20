using System.Collections.Generic;
using RRModels;
namespace RRBL
{
    public interface IRestaurantBL
    {
        List<Restaurant> GetAllRestaurants();
        Restaurant AddRestaurant(Restaurant restaurant);
        Restaurant GetRestaurant(Restaurant restaurant);
        Restaurant DeleteRestaurant(Restaurant restaurant);
        Restaurant GetRestaurantById(int id);
    }
}