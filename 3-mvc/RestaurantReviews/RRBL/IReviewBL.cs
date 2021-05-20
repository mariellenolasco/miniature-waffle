using RRModels;
using System;
using System.Collections.Generic;
namespace RRBL
{
    public interface IReviewBL
    {
        Review AddReview(Restaurant restaurant, Review review);
        Tuple<List<Review>, int> GetReviews(Restaurant restaurant);
    }
}