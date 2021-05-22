using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementReview_LINQ
{
    class Program
    {
        static void Main(string[] args) //Main Method
        {
            Console.WriteLine("Welcome To Product Management Review - LINQ\n");

            /* UC1:- Product Review Management
                     - Create Product review class with ProductID, UserID, Rating, Review and isLike fields.
                     - Create variable for List of Product Review class in Main method
                     - Add 25 default values in list which we have created.
             */
            List<ProductReview> productReviewlist = new List<ProductReview>()
            {
               new ProductReview() { ProductId = 1, UserId = 1, Rating = 4, Review = "Average", isLike = true }, //Adding Data
               new ProductReview() { ProductId = 1, UserId = 2, Rating = 2, Review = "Bad", isLike = false }, //Adding Data
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
               new ProductReview() { ProductId = 22, UserId = 12, Rating = 3, Review = "Average", isLike = false }, //Adding Data
              
            };
            //CreateDataTable(); // Class Program

            //IterateProductReview(productReviewlist); //UC1
            //Retrievetop3records(productReviewlist); //UC2
            // RetrieveRecordsWithGreaterThanThreeRating(productReviewlist); //UC3
            //RetrieveCountOfReviewForEachProductId(productReviewlist); //UC4
            RetrieveProductIDAndReviewOfAllRecords(productReviewlist); //UC5


            Console.ReadLine();
        }

        public static void IterateProductReview(List<ProductReview> productReviewlist)
        {
            foreach (ProductReview list in productReviewlist) //ptint list item
            {
                Console.WriteLine($"ProductId:- {list.ProductId}   || UserId:- {list.UserId}   || Rating:- {list.Rating}   || Review:- {list.Review }   ||   IsLike:- {list.isLike }"); //Print data
            }
        }


        /* UC2:- Product Review Management.
                 - Retrieve top 3 records from the list who’s rating is high using LINQ.
        */
        public static void Retrievetop3records(List<ProductReview> productReviewlist)
        {
            try
            {
                //Query syntax for LINQ     //product veriable  productReviewlist list products.Rating column name
                var result = (from products in productReviewlist
                              orderby products.Rating descending
                              select products).Take(3);
                foreach (var elements in result)
                {
                    Console.WriteLine($"ProductId:- {elements.ProductId} UserId:- {elements.UserId} Rating:- {elements.Rating} Review:- {elements.Review} isLike:- {elements.isLike}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        /*UC3:- Product Review Management.
                - Retrieve all record from the list who’s rating are greater then 3 and 
                productID is 1 or 4 or 9 using LINQ.
        */

        public static void RetrieveRecordsWithGreaterThanThreeRating(List<ProductReview> productReviewlist)
        {
            try
            {   //Query syntax for LINQ 
                var RecordedData = (from productReviews in productReviewlist
                                    where (productReviews.ProductId == 1 || productReviews.ProductId == 4 || productReviews.ProductId == 9)
                                    && productReviews.Rating > 3
                                    select productReviews);
                Console.WriteLine("\nProducts with Rating Greater than 3 and productID = 1 or 4 or 9 are:- ");
                foreach (var List in RecordedData) //traversing each items
                {
                    Console.WriteLine($"ProductId:- {List.ProductId}   || UserId:- {List.UserId}   || Rating:- {List.Rating}   || Review:- {List.Review }   ||   IsLike:- {List.isLike }"); //Print data
                }
              

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }

        /* UC4:- Product Review Management.
                 - Retrieve count of review present for each productID.
                 - Use groupBy LINQ Operator. 
         */

        public static void RetrieveCountOfReviewForEachProductId(List<ProductReview> productReviewlist)
        {
            try 
            { 
            var RecordedData = (productReviewlist.GroupBy(p => p.ProductId).Select(x => new { ProductId = x.Key, Count = x.Count() }));
            Console.WriteLine("\n Count group by ProductId");
            foreach (var List in RecordedData)
            {
                Console.WriteLine($"ProductId:- {List.ProductId}   || Count :- {List.Count}"); //Print data
            }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /* UC5:- Product Review Management.
                 - Retrieve only productId and review from the list for all Records. 
                 - Use select LINQ Operator.
        */
        public static void RetrieveProductIDAndReviewOfAllRecords(List<ProductReview> productReviewlist)
        {
            try
            {
                //Query syntax for LINQ 
                var RecordedData = (from products in productReviewlist
                                    select new { ProductId = products.ProductId, Review = products.Review });
                Console.WriteLine("Retrieving Product and Review from list:-");
                foreach (var productReview in RecordedData) //traversing each items
                {
                    Console.WriteLine($"ProductID:-   {productReview.ProductId}  \t Review:-   { productReview.Review}");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }








        /* Class Program*/
        public static void CreateDataTable() //create method
        {
            try
            {
                DataTable table = new DataTable(); //create table and create object
                table.Columns.Add("ProductId");     // add Columns in table
                table.Columns.Add("ProductName"); // add Columns in table

                table.Rows.Add("1", "Laptop"); //add rows on table
                table.Rows.Add("2", "Mobile");
                table.Rows.Add("3", "Tablet");
                table.Rows.Add("4", "Desktop");
                table.Rows.Add("5", "Watch");
                DisplayTableProduct(table);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public static void DisplayTableProduct(DataTable table) //Create DisplayTableProduct method
        {
            try
            {
                var Productname = from product in table.AsEnumerable() select product.Field<string>("ProductName"); //Fetch Product of the table
                foreach (var item in Productname) //iiterate 
                {
                    Console.WriteLine($"ProductName:- {item}"); //print 
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

}
