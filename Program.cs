using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //10 different variables
            string productName = "Steering Wheel";
            int productNumber = 16;
            float productPrice = 10.2F;
            char productSymbol = 'A';
            bool isAvailable = true;
            long qtySold = 123245556;
            double productSize = 123.45;
            bool isproductSoldOut = false;
            var productRemark = "Excellent";
            dynamic productRatings = 5.0;
            

            Console.WriteLine(productName);
            Console.WriteLine(productNumber);
            Console.WriteLine(productPrice);
            Console.WriteLine(productSymbol);
            Console.WriteLine(isAvailable);
            Console.WriteLine(qtySold);
            Console.WriteLine(productSize);
            Console.WriteLine(isproductSoldOut);
            Console.WriteLine(productRemark);
            Console.WriteLine(productRatings);



            //implicit conversions
            int myInt = 9;
            double myDouble = myInt;       

            Console.WriteLine(myInt);      
            Console.WriteLine(myDouble);


            //explixit conversion
            double pDouble = 12.34;
            int pnumber = (int) pDouble; 

            Console.WriteLine(pDouble);   
            Console.WriteLine(pnumber);
        }
    }
}
