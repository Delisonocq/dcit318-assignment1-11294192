using System;

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            double price = (age <= 12 || age >= 65) ? 7.0 : 10.0;

            Console.WriteLine($"Ticket price: GHC{price}");
        }
    }
}
