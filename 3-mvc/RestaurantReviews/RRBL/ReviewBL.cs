using System;
using System.Collections.Generic;
using RRDL;
using RRModels;

namespace RRBL
{
    public class ReviewBL : IReviewBL
    {
        private IRepository _repo;
        public ReviewBL(IRepository repo)
        {
            _repo = repo;
        }
        public Review AddReview(Restaurant restaurant, Review review)
        {
            //call repo method to add review;
            _repo.AddReview(restaurant, review);
            return review;
        }

        public Tuple<List<Review>, int> GetReviews(Restaurant restaurant)
        {
            //call get reviews from my repodb.
            List<Review> restaurantReviews = _repo.GetReviews(restaurant);
            if (restaurantReviews.Count > 0)
            {
                int averageRating = 0;
                restaurantReviews.ForEach(review => averageRating += review.Rating);
                averageRating = averageRating / restaurantReviews.Count;
                return new Tuple<List<Review>, int>(restaurantReviews, averageRating);
            }
            return new Tuple<List<Review>, int>(restaurantReviews, 0);
        }
    }
}