using System;
using System.Collections.Generic;

namespace ProductReviewManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<ProductReview> ProductReviewlist = new List<ProductReview>()
            {
                new ProductReview() {ProductId=1,UserId=1,Rating=5,Review="Good",isLike=true},
                new ProductReview() { ProductId = 2, UserId = 2, Rating = 4.5, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 3, UserId = 3, Rating = 4, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 4, UserId = 3, Rating = 3.9, Review = "Good", isLike = true }
            };
            foreach(ProductReview Pr in ProductReviewlist)
            {
                Console.WriteLine($"ProductId: {Pr.ProductId} UserId: {Pr.ProductId} Rating: {Pr.Rating} Review: {Pr.Review} isLike: {Pr.isLike}");
            }
        }
    }
}

