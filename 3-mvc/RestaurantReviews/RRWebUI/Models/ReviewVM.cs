using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RRWebUI.Models
{
    public class ReviewVM
    {
        public ReviewVM()
        {

        }
        public ReviewVM(int restaurantId)
        {
            RestaurantId = restaurantId;
        }
        public int RestaurantId { get; set; }
        public int Rating { get; set; }
        public string Description { get; set; }
    }
}
