using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ProductReviewManagement
{
    public class Datatable
    {
        public DataTable dataTable;
        public Datatable()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("ProductId");
            dataTable.Columns.Add("UserId");
            dataTable.Columns.Add("Rating");
            dataTable.Columns.Add("Review");
            dataTable.Columns.Add("isLike");
            foreach (var productReview in Program.ProductReviewlist)
            {
                dataTable.Rows.Add(productReview.ProductId, productReview.UserId, productReview.Rating, productReview.Review, productReview.isLike);

            }
          
        }
    }
}
