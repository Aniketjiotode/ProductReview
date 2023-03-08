using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ProductReviewManagement
{
    internal class Management
    {
        public void TopRecords(List<ProductReview> listproductReviews)
        {
            var recordedData = (from productReviews in listproductReviews
                                orderby productReviews.Rating descending
                                select productReviews).Take(3);
            foreach (var Pr in recordedData)
            {
                Console.WriteLine($"ProductId: {Pr.ProductId} UserId: {Pr.ProductId} Rating: {Pr.Rating} Review: {Pr.Review} isLike: {Pr.isLike}");
            }
        }
        public void FilterRecord(List<ProductReview> listproductReviews)
        {
            var recordedData = from ProductReviews in listproductReviews where (ProductReviews.ProductId == 1 || ProductReviews.ProductId == 4 || ProductReviews.ProductId == 9) && ProductReviews.Rating > 3 select ProductReviews;
            foreach (var Pr in recordedData)
            {
                Console.WriteLine($"ProductId: {Pr.ProductId} UserId: {Pr.ProductId} Rating: {Pr.Rating} Review: {Pr.Review} isLike: {Pr.isLike}");
            }
        }

        public void RetriveCountOfRecords(List<ProductReview> listproductReviews)
        {
            var recordedData = listproductReviews.GroupBy(x => x.ProductId).Select(x => new { productId = x.Key, count = x.Count() });
            foreach (var Pr in recordedData)
            {
                Console.WriteLine($"ProductId: {Pr.productId}   Count: {Pr.count}");
            }
        }

        public void RetriveIdandReviewRecords (List<ProductReview> listproductReviews)
        {
            var recordedData = listproductReviews.Select(x => new { productId = x.ProductId, review = x.Review });
            foreach (var Pr in recordedData)
            {
                Console.WriteLine($"ProductId: {Pr.productId}   Review: {Pr.review}");
            }
        }
    }
}
