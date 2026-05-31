using System;
using System.Collections.Generic;
using System.Text;

namespace Transformation
{
    internal class ShoppingCartProduct
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public static void TotalPrice(List<ShoppingCartProduct> objList)
        {
            double TotalPrice = 0;
         foreach(var  obj in objList)
            {
                TotalPrice = TotalPrice + (obj.Price * obj.Quantity);
            }
            Console.WriteLine($"Total Price: {TotalPrice}");
        }
            
    }
}
