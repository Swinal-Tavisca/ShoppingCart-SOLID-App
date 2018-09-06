using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_SOLID
{
    class MainAction
    {
        static void Main(string[] args)
        {
            List<Items> items = new List<Items>();
            
            Cart cart = new Cart();
            CahOnDelivery payment = new CahOnDelivery();

            Items itemObject = new Items
            {
                ItemId = 1,
                ItemName ="item1",
                ItemPrice = 200

            };
            items.Add(itemObject);
            itemObject = new Items
            {
                ItemId = 2,
                ItemName = "item2",
                ItemPrice = 200
            };
            items.Add(itemObject);

            Console.WriteLine("1. ACCESS CART");
            Console.WriteLine("2. DISPLAY CART");
            Console.WriteLine("3. EXIT");

            string input = Console.ReadLine();
            if(input=="1")
            {
                int flag = 0;
                do
                {
                    Console.WriteLine("ENTER ITEM ID");
                    int itemID = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("1. ADD ITEMS TO CART");
                    Console.WriteLine("2. REMOVE ITEMS FROM CART");
                    Console.WriteLine("3. RETRIVE ITEMS FROM CART");
                    Console.WriteLine("4. TOTAL ITEM'S COST");
                    Console.WriteLine("5. DO PAYMENT");
                    Console.WriteLine("6. EXIT");
                    int enter = Convert.ToInt32(Console.ReadLine());


                    if (enter == 1)
                    {
                        Items product = items[itemID - 1];
                        cart.addItems(product,(itemID-1));
                    }
                    else if (enter == 2)
                    {
                        Items product = items[itemID - 1];
                        cart.removeItems(product, (itemID - 1));
                    }
                    else if (enter == 3)
                    {
                        Items product = items[itemID - 1];
                        cart.retriveItem(product, (itemID - 1));
                    }
                    else if (enter == 4)
                    {
                        Items product = items[itemID - 1];
                        cart.totalItemsCost(product);
                    }
                    else if (enter == 5)
                    {
                        Console.WriteLine("1. CASH ON DELIVERY");
                        Console.WriteLine("2. OLINE ");
                        int pay = Convert.ToInt32(Console.ReadLine());
                        if (pay == 1)
                        {
                            CahOnDelivery cahOnDelivery = new CahOnDelivery();
                            cahOnDelivery.displayCashOnDelivery();

                        }
                        else if (pay == 2)
                        {
                            Online online = new Online();
                            online.usersOnlineDetails();
                        }
                    }
                    else if(enter==6)
                    {
                        flag = 1;
                    }
                } while (flag == 0);
                
            }
            else if(input=="2")
            {
                cart.displayCart();
            }
            else if(input =="3")
            {
                Environment.Exit(0);
            }
            Console.ReadKey();

        }
    }
}
