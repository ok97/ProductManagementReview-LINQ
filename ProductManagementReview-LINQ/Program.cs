using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementReview_LINQ
{
    class Program
    {/* UC1:- Product Review Management
              - Create Product review class with ProductID, UserID, Rating, Review and isLike fields.
              - Create variable for List of Product Review class in Main method
              - Add 25 default values in list which we have created.
        */
        static void Main(string[] args) //Main Method
        {

            List<ProductReview> productReviewlist = new List<ProductReview>()
            {
               new ProductReview() { ProductId = 1, UserId = 1, Rating = 3, Review = "Average", isLike = true }, //Adding Data
               new ProductReview() { ProductId = 2, UserId = 2, Rating = 2, Review = "Bad", isLike = false }, //Adding Data
               new ProductReview() { ProductId = 3, UserId = 3, Rating = 4, Review = "Nice", isLike = true }, //Adding Data
               new ProductReview() { ProductId = 4, UserId = 4, Rating = 5, Review = "Good", isLike = false }, //Adding Data
               new ProductReview() { ProductId = 5, UserId = 5, Rating = 6, Review = "Excelent", isLike = false }, //Adding Data
               new ProductReview() { ProductId = 6, UserId = 10, Rating = 4, Review = "Nice", isLike = true }, //Adding Data
               new ProductReview() { ProductId = 7, UserId = 6, Rating = 3, Review = "Average", isLike = true }, //Adding Data
               new ProductReview() { ProductId = 8, UserId = 5, Rating = 2, Review = "Bad", isLike = true }, //Adding Data
               new ProductReview() { ProductId = 9, UserId = 10, Rating = 5, Review = "Good", isLike = true }, //Adding Data
               new ProductReview() { ProductId = 10, UserId = 41, Rating = 6, Review = "Excelent", isLike = false }, //Adding Data
               new ProductReview() { ProductId = 11, UserId = 5, Rating = 4, Review = "Nice", isLike = false }, //Adding Data
               new ProductReview() { ProductId = 12, UserId = 4, Rating = 1, Review = "Very Bad", isLike = true }, //Adding Data
               new ProductReview() { ProductId = 13, UserId = 48, Rating = 0, Review = "Excelent", isLike = false }, //Adding Data
               new ProductReview() { ProductId = 14, UserId =41, Rating = 3, Review = "Average", isLike = true }, //Adding Data
               new ProductReview() { ProductId = 15, UserId = 51, Rating = 4, Review = "Nice", isLike = true }, //Adding Data
               new ProductReview() { ProductId = 16, UserId = 8, Rating = 1, Review = "Very Bad", isLike = false }, //Adding Data
               new ProductReview() { ProductId = 17, UserId = 18, Rating = 6, Review = "Excelent", isLike = true }, //Adding Data
               new ProductReview() { ProductId = 18, UserId = 9, Rating = 5, Review = "Good", isLike = true }, //Adding Data
               new ProductReview() { ProductId = 19, UserId = 10, Rating = 4, Review = "Nice", isLike = false }, //Adding Data
               new ProductReview() { ProductId = 20, UserId = 7, Rating = 3, Review = "Average", isLike = true }, //Adding Data
               new ProductReview() { ProductId = 21, UserId = 6, Rating = 2, Review = "Bad", isLike = true }, //Adding Data
               new ProductReview() { ProductId = 22, UserId = 5, Rating = 1, Review = "Very Bad", isLike = false }, //Adding Data
               new ProductReview() { ProductId = 23, UserId = 10, Rating = 5, Review = "Good", isLike = false }, //Adding Data
               new ProductReview() { ProductId = 24, UserId = 8, Rating = 2, Review = "Bad", isLike = true }, //Adding Date
               new ProductReview() { ProductId = 25, UserId = 12, Rating = 3, Review = "Average", isLike = false }, //Adding Data
              
            };
            foreach (var list in productReviewlist)
            {
                Console.WriteLine($"ProductId:- {list.ProductId}   || UserId:- {list.UserId}   || Rating:- {list.Rating}   || Review:- {list.Review }   ||   IsLike:- {list.isLike }"); //Print data
            }
            // CreateDataTable();
            Console.ReadLine();
        }
        public static void CreateDataTable() //create method
        {   DataTable table = new DataTable(); //create table and create object
            table.Columns.Add("ProductId");     // add Columns in table
            table.Columns.Add("ProductName"); // add Columns in table

            table.Rows.Add("1","Laptop"); //add rows on table
            table.Rows.Add("2","Mobile");
            table.Rows.Add("3","Tablet");
            table.Rows.Add("4","Desktop");
            table.Rows.Add("5","Watch");
            DisplayTableProduct(table); 

        }
        public static void DisplayTableProduct(DataTable table) //Create DisplayTableProduct method
        {
            var Productname = from product in table.AsEnumerable() select product.Field<string>("ProductName"); //Fetch Product of the table
            foreach (var item in Productname) //iiterate 
            {
                Console.WriteLine($"ProductName:- {item}"); //print 
            }
        }
    }
}
