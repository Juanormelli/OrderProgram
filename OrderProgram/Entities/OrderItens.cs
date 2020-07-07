using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProgram.Entities
{
    class OrderItens
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }
        

        public OrderItens()
        {

        }

        public OrderItens(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTot()
        {

            return Price * Quantity;
            
        }
        public override string ToString()
        {
            return "Product: "+Product+ "  Quantity: "+Quantity+"  SubTotal: $"+ SubTot();
        }

    }
    

}
