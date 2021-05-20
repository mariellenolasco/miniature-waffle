using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RRBL;
using RRModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RRWebUI.Controllers
{
    public class RestaurantController : Controller
    {
        private IRestaurantBL _restaurantBL;
        public RestaurantController(IRestaurantBL restaurantBL)
        {
            _restaurantBL = restaurantBL;
        }
        // GET: RestaurantController
        public ActionResult Index()
        {
            return View(_restaurantBL.GetAllRestaurants());
        }


        // GET: RestaurantController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RestaurantController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Restaurant newRestaurant)
        {
            try
            {
                _restaurantBL.AddRestaurant(newRestaurant);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RestaurantController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }


        // GET: RestaurantController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_restaurantBL.GetRestaurantById(id));
        }

        // POST: RestaurantController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteRestaurant(int id)
        {
            try
            {
                _restaurantBL.DeleteRestaurant(_restaurantBL.GetRestaurantById(id));
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
