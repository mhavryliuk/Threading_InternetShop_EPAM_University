using System;
using System.Threading;

/**<remark>
 * You are manager of internet shop. There is a counter of orders. 
 * It increases when client perform an order. You have two categories of clients (VIP and ordinary ones).
 * When VIP or ordinary client performs the order the counter or orders is increased.
 * 
 * Write the next program: 
 * client class has an event increase the order number. Also client has a property is he VIP or no.
 * There is common counter of orders in internet shop.
 * You have 10 seconds to calculate number of orders. During this 10 seconds you randomly create clients of both types. 
 * Every client works in own independent thread. (The tip VIP clients are executed in thread with high priorities.) 
 * Each client makes an order when he creates an order the counter of orders is increased.
 * When 10 seconds will pass, represent number of orders and number of VIP clients and ordinary ones.
 </remark> */

namespace _20180403_Task2_InternetShop
{
    internal class Program
    {
        private static void Main()
        {
            OnlineStore store = new OnlineStore();

            // A thread that randomly creates customers of both types within 10 seconds
            Thread customerGeneration = new Thread(store.Generate);
            customerGeneration.Start();
            customerGeneration.Join(TimeSpan.FromSeconds(10));

            // Start of service of turn of earlier created customers
            store.QueueForOrder();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nResult of work of online store");
            Console.ResetColor();
            Console.WriteLine("VIP customer served: {0}", Customer.vipCount);
            Console.WriteLine("Ordinary customer served: {0}", Customer.ordinaryCount);
            Console.WriteLine("Total number of orders: {0}", OnlineStore.numberOfOrders);

            Console.ReadKey();
        }
    }
}