namespace _20180403_Task2_InternetShop
{
    internal class Customer
    {
        public static int vipCount = 0;        // VIP customer's order counter
        public static int ordinaryCount = 0;   // Ordinary customer's order counter

        public bool vip;

        public Customer(bool type)
        {
            vip = type;
        }
    }   
}