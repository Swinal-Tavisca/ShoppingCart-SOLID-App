using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_SOLID
{
    public class Cart :ICart
    {
        List<Items> cart = new List<Items>();
       
        public void addItems(Items product,int id)
        {
            cart.Add(product);
            
            Console.WriteLine("ITEM ADDED TO CART !");
            //Console.WriteLine(cart[0].ItemId);
        }
        public void removeItems(Items product,int id)
        {
            cart.Remove(product);
            
            Console.WriteLine("ITEM REMOVED FROM CART !");

        }
        public void totalItemsCost(Items product)
        {
            int total = 0;
            for(int i=0;i<cart.Count;i++)
            {
                total = total + cart[i].ItemPrice;
            }
            Console.WriteLine("TOTAL COST  :" + total);
        }
        public void retriveItem(Items product, int id)
        {
            Console.WriteLine(cart[id].ItemId);
            Console.WriteLine(cart[id].ItemName);
            Console.WriteLine(cart[id].ItemPrice);
        }
        public void displayCart()
        {
            for(int i=0;i<cart.Count;i++)
            {
                Console.WriteLine(cart[i].ItemId);
                Console.WriteLine(cart[i].ItemName);
                Console.WriteLine(cart[i].ItemPrice);
                Console.WriteLine();
            }
        }

    }
}
