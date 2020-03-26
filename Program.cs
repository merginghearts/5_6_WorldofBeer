using System;
using System.Collections;
using System.Collections.Generic;


namespace _5_6_WorldofBeer
{
    class Program

    {
     public struct Customer
        {
            public string first_name;
            public string last_name;
            public int age;
            public bool hasMembership;
        }
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            Customer customer2 = new Customer();
            Customer customer3 = new Customer();

            customer1.first_name = "John";
            customer1.last_name = "Taylor";
            customer1.age = 18;
            customer1.hasMembership = false;

            customer2.first_name = "Simon";
            customer2.last_name = "LeBon";
            customer2.age = 25;
            customer2.hasMembership = false;

            customer3.first_name = "Nick";
            customer3.last_name = "Rhodes";
            customer3.age = 30;
            customer3.hasMembership = true;

            Customer[] allCustomers = { customer1, customer2, customer3 };
            for (int i = 0; i < allCustomers.Length; i++)
            {
                if (allCustomers[i].age < 21)
                {
                    Console.WriteLine(allCustomers[i].first_name + " " + allCustomers[i].last_name + "may not place an order!");

                }
                else
                {
                    Console.WriteLine(allCustomers[i].first_name + " " + allCustomers[i].last_name + "may place an order!");

                }
                if (allCustomers[i].hasMembership == true)
                {
                    Console.WriteLine(allCustomers[i].first_name + " " + allCustomers[i].last_name + "is a premium member!");

                }
                else
                {
                    Console.WriteLine(allCustomers[i].first_name + " " + allCustomers[i].last_name + "is a standard member!");

                }


            }


        }
    }
}
