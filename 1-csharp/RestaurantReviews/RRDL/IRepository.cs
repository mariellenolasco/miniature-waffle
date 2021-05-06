using System.Collections.Generic;
using RRModels;
namespace RRDL
{
    public interface IRepository
    {
        List<Restaurant> GetAllRestaurants();
        Restaurant AddARestaurant(Restaurant restaurant);

        Restaurant GetRestaurant(Restaurant restaurant);
    }
}