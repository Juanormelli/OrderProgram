using OrderProgram.Entities;
using OrderProgram.Entities.Enum;
using System;

namespace OrderProgram
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter Client Data");
            Console.Write("Name: ");
            string Name = Console.ReadLine();
            Console.Write("Born Date: ");
            DateTime Birth = DateTime.Parse(Console.ReadLine());
            Console.Write("Email: ");
            string Email = Console.ReadLine();
            
            Order order = new Order();
            order.Client = new Client(Name, Email, Birth);

            Console.WriteLine("Enter Order Data: ");
            order.Status = Enum.Parse<OrderStatus>("Processing");
            order.Moment = DateTime.Now;
            Console.Write("How Many items to this order: ");
            int NumberOfProducts = int.Parse(Console.ReadLine());

            for (int i = 1; i <= NumberOfProducts; i++)
            {
                Console.Write("Name of product: ");
                string NameOfProduct = Console.ReadLine();
                Console.Write("Price of pruduct: ");
                double PriceOfProduct = double.Parse(Console.ReadLine());
                Product product = new Product(NameOfProduct, PriceOfProduct);

                Console.Write("Quantity: ");
                int Quantity = int.Parse(Console.ReadLine());
                OrderItens orderItens = new OrderItens(Quantity, PriceOfProduct, product);

                order.AddItens(orderItens);


            }
            Console.WriteLine(order);



        }
    }
}
