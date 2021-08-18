using System;

namespace HandsOnClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //object creation
            Customer customer = new Customer();
            customer.CustomerId = 123;
            customer.CustomerName = "Manas";
            customer.City = "Bangalore";
            Console.WriteLine("Customer Id : " + customer.CustomerId);
            Console.WriteLine("Customer Name : " + customer.CustomerName);
            Console.WriteLine("Customer City : " + customer.City);

            Customer customer1 = new Customer(); // class variables are having default values
            Console.WriteLine("Customer Id : " + customer1.CustomerId);
            Console.WriteLine("Customer Name : " + customer1.CustomerName);
            Console.WriteLine("Customer City : " + customer1.City);


        }
    }
}
