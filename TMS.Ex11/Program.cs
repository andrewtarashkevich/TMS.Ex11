using System;
using ClassLibrary1;
using System.Collections.Generic;

namespace TMS.Ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            Item item1 = new Item("Nike");
            Item item2 = new Item("Adidas");
            Item item3 = new Item("Puma");
            Item item4 = new Item("Asics");
            CustomList<Item> shop = new CustomList<Item>();            
            shop.Add(item1);
            shop.Add(item2);
            shop.Add(item3);
            shop.Add(item4);
            Console.WriteLine(shop[2].Name);
            shop.RemoveAt(2);
            Console.WriteLine(shop[2].Name);

            Console.WriteLine("-----------------------------------------------------------");
            CustomLinkedList<Item> shop2 = new CustomLinkedList<Item>();
            shop2.AddLast(item1);
            shop2.AddLast(item2);
            shop2.AddLast(item3);
            shop2.AddLast(item4);
            foreach (var item in shop2)
            {
                Console.WriteLine(item.Name);
            }


            //3) Попробовать поработать с этими коллекциями стандартными методами LINQ. Использовать Where, Select, Take, Skip
        }
    }
}
