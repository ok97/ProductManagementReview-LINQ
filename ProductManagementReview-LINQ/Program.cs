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



            //IterateProductReview(productReviewlist); //UC1
            //Retrievetop3records(productReviewlist); //UC2
            // RetrieveRecordsWithGreaterThanThreeRating(productReviewlist); //UC3
            //RetrieveCountOfReviewForEachProductId(productReviewlist); //UC4
            // RetrieveProductIDAndReviewOfAllRecords(productReviewlist); //UC5
            //SkipTopFiveRecords(productReviewlist); //UC6
            //RetrieveProductIDAndReviewUsingLambdaSyntax(productReviewlist); //UC7
            //CreateDataTable(); //UC8
           // RetrieveRecordWithTrueIsLike(); //UC9
            FindAverageRatingOfTheEachProductId();




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
            catch (Exception ex)
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
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        /* UC6:- Product Review Management.
                 - Skip top 5 records from the list using LINQ and display other Records.
        */
        public static void SkipTopFiveRecords(List<ProductReview> productReviewlist)
        {
            try
            {       //Query syntax for LINQ 
                var RecordedData = (from products in productReviewlist
                                    select products).Skip(5);
                Console.WriteLine("\n Skiping the Top five records and Display others ");
                foreach (var productReview in RecordedData) //traversing each items
                {
                    Console.WriteLine($"ProductId:- {productReview.ProductId}\tUserId:- {productReview.UserId}\tRating:- {productReview.Rating}\t  Review:- {productReview.Review}  \t    isLike:- {productReview.isLike}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /*UC7:- Product Review Management.
                - Retrieve only productId and review from the list for all records using LINQ select operator.
         */
        public static void RetrieveProductIDAndReviewUsingLambdaSyntax(List<ProductReview> productReviewlist)
        {
            try
            {                // Query syntax for LINQ 
                var RecordedData = productReviewlist.Select(reviews => new { ProductId = reviews.ProductId, Review = reviews.Review });
                Console.WriteLine("\nRetrieving Product and Review from list");
                foreach (var productReview in RecordedData) //traversing each items
                {
                    Console.WriteLine($"ProductId:- {productReview.ProductId}\tReview:- {productReview.Review}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /*UC8:- Product Review Management. 
               - Create DataTable using C# and Add ProductID, UserID, Rating, Review and isLike fields in that.
               - Add 25 default values in datatable list which we have UC 8 created Class Program.
      */
        public static DataTable table = new DataTable();
        public static void CreateDataTable()
        {
            try
            {
                table.Columns.Add("ProductId", typeof(Int32)); // add Columns in table
                table.Columns.Add("UserId", typeof(Int32)); // add Columns in table
                table.Columns.Add("Rating", typeof(double)); // add Columns in table
                table.Columns.Add("Review", typeof(string)); // add Columns in table
                table.Columns.Add("isLike", typeof(bool)); // add Columns in table


                table.Rows.Add(1, 1, 4, "Average", true); //Adding Data
                table.Rows.Add(1, 2, 2, "Bad", false); //Adding Data
                table.Rows.Add(3, 3, 4, "Nice", true); //Adding Data
                table.Rows.Add(4, 4, 5, "Good", false); //Adding Data
                table.Rows.Add(5, 5, 6, "Excelent", false); //Adding Data
                table.Rows.Add(6, 10, 4, "Nice", true); //Adding Data
                table.Rows.Add(7, 6, 3, "Average", true); //Adding Data
                table.Rows.Add(8, 5, 2, "Bad", true); //Adding Data
                table.Rows.Add(9, 10, 5, "Good", true); //Adding Data
                table.Rows.Add(10, 41, 6, "Excelent", false); //Adding Data
                table.Rows.Add(11, 5, 4, "Nice", false); //Adding Data
                table.Rows.Add(12, 4, 1, "Very Bad", true); //Adding Data
                table.Rows.Add(13, 48, 0, "Excelent", false); //Adding Data
                table.Rows.Add(14, 41, 3, "Average", true); //Adding Data
                table.Rows.Add(15, 51, 4, "Nice", true); //Adding Data
                table.Rows.Add(16, 8, 1, "Very Bad", false); //Adding Data
                table.Rows.Add(17, 18, 6, "Excelent", true); //Adding Data
                table.Rows.Add(18, 9, 5, "Good", true); //Adding Data
                table.Rows.Add(19, 10, 4, "Nice", false); //Adding Data
                table.Rows.Add(20, 7, 3, "Average", true); //Adding Data
                table.Rows.Add(21, 6, 2, "Bad", true); //Adding Data
                table.Rows.Add(22, 5, 1, "Very Bad", false); //Adding Data
                table.Rows.Add(23, 10, 5, "Good", false); //Adding Data
                table.Rows.Add(24, 8, 2, "Bad", true); //Adding Date
                table.Rows.Add(22, 12, 3, "Average", false); //Adding Data
                                                             //Printing data
                Console.WriteLine("DataTable Records");
                foreach (var list in table.AsEnumerable())
                {
                    Console.WriteLine($"ProductId:- { list.Field<int>("ProductId")}    UserId:- {list.Field<int>("UserId")}\tRating:- {list.Field<double>("Rating")}\tReview:- { list.Field<string>("Review")} \tisLike:- {list.Field<bool>("isLike")}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        /* UC9:- Product Review Management.
                - Retrieve all the records from the datatable variable who’s isLike value is true using LINQ
        */
        public static void RetrieveRecordWithTrueIsLike()
        {
            try
            {
             
                CreateDataTable(); //UC8 call CreateDataTable method 
                                   // Query syntax for LINQ 
                var retrieveData = from records in table.AsEnumerable()
                                   where (records.Field<bool>("isLike") == true)
                                   select records;

                Console.WriteLine("\nRecords in table whose IsLike value is true");
                foreach (var list in retrieveData)  //Printing data
                {
                    Console.WriteLine("ProductId:-" + list.Field<int>("ProductId") + "\t" + "UserID :" + list.Field<int>("UserId") + "\t" + "Rating ;" + list.Field<double>("Rating") + "\t" + "Review :" + list.Field<string>("Review") + "\t" + "isLike :" + list.Field<bool>("isLike"));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /*UC10:- Product Review Management.
                 • Find average rating of the each productId using LINQ
        */

        public static void FindAverageRatingOfTheEachProductId()
        {
            try
            {
                CreateDataTable(); //UC8 call CreateDataTable method 
                                   // Query syntax for LINQ 
                var records = table.AsEnumerable().GroupBy(r => r.Field<int>("ProductId")).Select(r => new { ProductId = r.Key, Average = r.Average(z => (z.Field<double>("Rating"))) });
                Console.WriteLine("\nProductId and its average rating");
                foreach (var v in records)
                {
                    Console.WriteLine($"ProductID:{v.ProductId}\tAverageRating:{v.Average}");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


    }

}
