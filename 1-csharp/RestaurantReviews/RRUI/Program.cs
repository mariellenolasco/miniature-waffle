using System;
using RRModels;
using System.Collections.Generic;
namespace RRUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Restaurant goodTaste = new Restaurant
            {
                Name = "Good Taste",
                City = "Baguio",
                State = "Benguet",
                Cuisine = Cuisine.Filipino,
                Reviews = new List<Review>(){
                    new Review {
                        Rating = 5,
                        Description = "Cheap! Very good!"
                    },
                    new Review{
                        Rating = 4,
                        Description = "Too crowded but good food"
                    }
                }
            };
            Console.WriteLine(goodTaste.ToString());
            foreach (Review review in goodTaste.Reviews)
            {
                Console.WriteLine(review.ToString());
            }
        }
    }
}
