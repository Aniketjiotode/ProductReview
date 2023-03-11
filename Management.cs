using System;
using System.Collections.Generic;
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

        DataTable dataTable = new DataTable();
        public void CreateTable(List<ProductReview> listproductReviews)
        {
            dataTable.Columns.Add("ProductId");
            dataTable.Columns.Add("UserId");
            dataTable.Columns.Add("Rating");
            dataTable.Columns.Add("Review");
            dataTable.Columns.Add("isLike");
            foreach (var productReview in listproductReviews)
            {
                dataTable.Rows.Add(productReview.ProductId, productReview.UserId, productReview.Rating, productReview.Review, productReview.isLike);

            }
            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine($"ProductId: {row[0]} UserId: {row[1]} Rating: {row[2]} Review: {row[3]} isLike: {row[4]}");

            }
        }
        public void RetriveisLikeRecords (List<ProductReview> listproductReviews)
        {

        }
    }
}
