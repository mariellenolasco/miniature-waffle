using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RRBL;
using RRModels;
using RRWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RRWebUI.Controllers
{
    public class ReviewController : Controller
    {
        private IRestaurantBL _restaurantBL;
        private IReviewBL _reviewBL;
        public ReviewController(IRestaurantBL restaurantBL, IReviewBL reviewBL)
        {
            _restaurantBL = restaurantBL;
            _reviewBL = reviewBL;
        }
        // GET: ReviewController
        public ActionResult Index(int id)
        {
            Tuple<List<Review>, int> result = _reviewBL.GetReviews(_restaurantBL.GetRestaurantById(id));
            ViewBag.Restaurant = _restaurantBL.GetRestaurantById(id);
            if (result.Item1.Count > 0)
            {
                ViewData.Add("OverallRating", result.Item2);
                return View(result.Item1);
            }
            else
            {
                ViewData.Add("OverallRating", "No reviews yet");
                return View(new List<Review>());
            }

        }
        // GET: ReviewController/Create
        public ActionResult Create(int id)
        {
            return View(new ReviewVM(id));
        }

        // POST: ReviewController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ReviewVM review)
        {
            try
            {
                _reviewBL.AddReview(_restaurantBL.GetRestaurantById(review.RestaurantId), new Review { Rating = review.Rating, Description = review.Description});
                return RedirectToAction(nameof(Index), new { id = review.RestaurantId});
            }
            catch
            {
                return View();
            }
        }

    }
}
