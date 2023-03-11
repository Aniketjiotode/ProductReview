using System;
using System.Collections.Generic;
using System.Data;

namespace ProductReviewManagement
{
    internal  class Program
    {
        public static List<ProductReview> ProductReviewlist;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Product Review Management");
             Program.ProductReviewlist = new List<ProductReview>()
            {
                new ProductReview() { ProductId = 1, UserId = 1, Rating = 5, Review = "Good", isLike = true},
                new ProductReview() { ProductId = 2, UserId = 2, Rating = 4.5, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 3, UserId = 3, Rating = 4, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 4, UserId = 4, Rating = 3.5, Review = "not Good", isLike = false },
                new ProductReview() { ProductId = 5, UserId = 5, Rating = 4.8, Review = "nice", isLike = true },
                new ProductReview() { ProductId = 2, UserId = 6, Rating = 4.2, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 7, UserId = 7, Rating = 3.6, Review = "not Good", isLike = false },
                new ProductReview() { ProductId = 8, UserId = 8, Rating = 4.9, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 9, UserId = 9, Rating = 3.7, Review = "nice", isLike = true },
                new ProductReview() { ProductId = 10, UserId = 10, Rating = 4.6, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 5, UserId = 10, Rating = 4.6, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 4, UserId = 10, Rating = 4.6, Review = "nice", isLike = true },
                new ProductReview() { ProductId = 8, UserId = 10, Rating = 4.6, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 12, UserId = 10, Rating = 4.6, Review = "nice", isLike = true },
                new ProductReview() { ProductId = 8, UserId = 10, Rating = 4.6, Review = "Good", isLike = true }
            };
            //foreach(ProductReview Pr in ProductReviewlist)
            //{
            //    Console.WriteLine($"ProductId: {Pr.ProductId} UserId: {Pr.ProductId} Rating: {Pr.Rating} Review: {Pr.Review} isLike: {Pr.isLike}");
            //}
            Management manager = new Management();
            //manager.TopRecords(ProductReviewlist);
            //manager.FilterRecord(ProductReviewlist);
            //manager.RetriveCountOfRecords(ProductReviewlist);
            //manager.RetriveIdandReviewRecords(ProductReviewlist);
            //manager.RetriveSkipRecords(ProductReviewlist);
            //manager.CreateTable(ProductReviewlist);
            //Datatable Table= new Datatable();
            //foreach (DataRow row in Table.dataTable.Rows)
            //{
            //    Console.WriteLine($"ProductId: {row[0]} UserId: {row[1]} Rating: {row[2]} Review: {row[3]} isLike: {row[4]}");

            //}
            manager.RetriveisLikeRecords();
        }
    }
}

