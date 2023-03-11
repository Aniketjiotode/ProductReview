using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
                Console.WriteLine($"ProductId: {Pr.ProductId} UserId: {Pr.UserId} Rating: {Pr.Rating} Review: {Pr.Review} isLike: {Pr.isLike}");
            }
        }
        public void FilterRecord(List<ProductReview> listproductReviews)
        {
            var recordedData = from ProductReviews in listproductReviews where (ProductReviews.ProductId == 1 || ProductReviews.ProductId == 4 || ProductReviews.ProductId == 9) && ProductReviews.Rating > 3 select ProductReviews;
            foreach (var Pr in recordedData)
            {
                Console.WriteLine($"ProductId: {Pr.ProductId} UserId: {Pr.UserId} Rating: {Pr.Rating} Review: {Pr.Review} isLike: {Pr.isLike}");
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

        public void RetriveSkipRecords(List<ProductReview> listproductReviews)
        {
            var recordedData = listproductReviews.Skip(5);
            foreach (var Pr in recordedData)
            {
                Console.WriteLine($"ProductId: {Pr.ProductId} UserId: {Pr.UserId} Rating: {Pr.Rating} Review: {Pr.Review} isLike: {Pr.isLike}");
            }
        }

        public void RetriveisLikeRecords()
        {
            Datatable table = new Datatable();
            var dataRow = table.dataTable.AsEnumerable().Where(x=>x.Field<string>("isLike")=="True");
            foreach (DataRow row in dataRow)
            {            
                Console.WriteLine($"ProductId: {row[0]} UserId: {row[1]} Rating: {row[2]} Review: {row[3]} isLike: {row[4]}");
            }
        }
        public void RetriveAverageRatingRecords(List<ProductReview> listproductReviews)
        {
            for(int i = 1; i < listproductReviews.Count; i++)
            {
                foreach (var ProductReview in listproductReviews)
                {
                    if (ProductReview.ProductId == i)
                    {
                        var recordedData = listproductReviews.Where(x => x.ProductId == i).Average(x => x.Rating);
                        Console.WriteLine($"ProductId: {i} AverageRating: {recordedData}");
                    }
                }
               
            }
        }
        public void RetriveReviewContainsNiceRecords(List<ProductReview> listproductReviews)
        {
            var recordedData = listproductReviews.Where(x => x.Review.Contains("nice"));
            foreach (var Pr in recordedData)
            {
                Console.WriteLine($"ProductId: {Pr.ProductId} UserId: {Pr.UserId} Rating: {Pr.Rating} Review: {Pr.Review} isLike: {Pr.isLike}");
            }
        }
        public void RetriveUseridRecords(List<ProductReview> listproductReviews,int id)
        {
            var recordedData = listproductReviews.OrderBy(x => x.Rating).Where(x => x.UserId == id);
            foreach (var Pr in recordedData)
            {
                Console.WriteLine($"ProductId: {Pr.ProductId} UserId: {Pr.UserId} Rating: {Pr.Rating} Review: {Pr.Review} isLike: {Pr.isLike}");
            }
        }
    }
}
