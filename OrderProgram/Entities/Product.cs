using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProgram.Entities
{
    class Product
    {
        public string NameofProduct { get; set; }
        public double PriceofProduct { get; set; }

        public Product()
        {

        }

        public Product(string nameofProduct, double priceofProduct)
        {
            NameofProduct = nameofProduct;
            PriceofProduct = priceofProduct;
        }
        public override string ToString()
        {
            return NameofProduct + " " ;
        }
    }
}
