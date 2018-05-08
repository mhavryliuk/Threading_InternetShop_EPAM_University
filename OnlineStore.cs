using System;
using System.Collections.Generic;
using System.Threading;

namespace _20180403_Task2_InternetShop
{
    internal class OnlineStore
    {
        private static readonly Random random = new Random();

        public static int numberOfOrders;   // Total number of store orders

        protected readonly List<Customer> customers = new List<Customer>();
        
        /// <summary>
        /// A method that randomly creating customers of both types within 10 seconds.
        /// </summary>
        public void Generate()
        {
            for (; ; )
            {
                // 1 - vip customer, 2 - ordinary custome
                var customerType = random.Next(1, 3) % 2 != 0;
                customers.Add(new Customer(customerType));
                Thread.Sleep(50);
            }
        }

        /// <summary>
        /// A method that creating independent thread for each customer depending on his type.
        /// </summary>
        public void QueueForOrder()
        {
            for (int i = 0; i < customers.Count; i++)
            {
                try
                {
                    Thread thread = new Thread(new ThreadStart(CustomerService));

                    if (customers[i].vip)
                    {
                        thread.Start();
                        Console.WriteLine("Start of VIP-customer service");
                        Interlocked.Increment(ref Customer.vipCount);
                        thread.Priority = ThreadPriority.Highest;
                        Console.WriteLine("End of VIP-customer service");
                        thread.Join();
                    }
                    else
                    {
                        thread.Start();
                        Console.WriteLine("\tStart of ordinary-customer service");
                        Interlocked.Increment(ref Customer.ordinaryCount);
                        thread.Priority = ThreadPriority.Lowest;
                        Console.WriteLine("\tEnd of ordinary-customer service");
                        thread.Join();
                    }
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Between clients there was a conflict because of a service priority.");
                    Console.WriteLine(ex.Message);
                    Console.ResetColor();
                }
            }
        }

        /// <summary>
        /// A method that counts the total number of orders
        /// </summary>
        public void CustomerService()
        {
            Interlocked.Increment(ref numberOfOrders);
        }
    }
}