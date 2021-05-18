using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementReview_LINQ
{/* UC1:- Product Review Management
              - Create Product review class with ProductID, UserID, Rating, Review and isLike fields.
              - Create variable for List of Product Review class in Main method
              - Add 25 default values in list which we have created.
        */
    public class ProductReview
    {
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public double Rating { get; set; }
        public string Review { get; set; }
        public bool isLike { get; set; }
    }
}
