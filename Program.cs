using System;

namespace Lab5_4
{
    class Program
    {
        public struct Customer
        {
            public enum Status
            {
                regular, premium
            }
            public string firstName;
            public string lastName;
            public int currentAge;
            public Status membershipStatus;

        }
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.firstName = "Johnny";
            customer1.lastName = "Storm";
            customer1.currentAge = 19;
            customer1.membershipStatus = Customer.Status.regular;

            Customer customer2 = new Customer();
            customer2.firstName = "Benjamin";
            customer2.lastName = "Grim";
            customer2.currentAge = 38;
            customer2.membershipStatus = Customer.Status.regular;

            Customer customer3 = new Customer();
            customer3.firstName = "Reed";
            customer3.lastName = "Richards";
            customer3.currentAge = 42;
            customer3.membershipStatus = Customer.Status.premium;

            Customer[] allCustomers = { customer1, customer2, customer3 };

            for (int i = 0; i < allCustomers.Length; i++)
            {
                if (allCustomers[i].currentAge < 21)
                {
                    Console.WriteLine(allCustomers[i].firstName + " " + allCustomers[i].lastName + " is underage.");
                }
                else
                {
                    Console.WriteLine(allCustomers[i].firstName + " " + allCustomers[i].lastName + " is a " + allCustomers[i].membershipStatus + " member and can place an order.");
                }

                //if (allCustomers[i].hasMembership == true)
                //{
                //    Console.WriteLine(allCustomers[i].first_name + " " + allCustomers[i].last_name + " is a premium member.");
                //}
                //else
                //{
                //    Console.WriteLine(allCustomers[i].first_name + " " + allCustomers[i].last_name + " is a standard member.");
                //}

            }

        }
    }
}