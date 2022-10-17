using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_08
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            var items = new Item[]
            {
                new Item(79, 1),
                new Item(27, 6),
                new Item(68, 5),
                new Item(52, 2),
                new Item(20, 3),
                new Item(52, 10),
                new Item(55, 1),
                new Item(87, 2),
                new Item(15, 2),
                new Item(48, 5)
            };
            var size = 13;
            var result = Execute(items, size);

            Console.ReadLine();
        }

        static int Execute(Item[] items, int capacity)
        {            
            int k = items.Length;
            int[,] a = new int[k + 1, capacity + 1];
            for (int s = 1; s <= k; s++)
            {
                // s - максимальный номер предмета, который можно использовать
                for (int n = 1; n <= capacity; n++)
                {// n - вместимости рюкзака
                    a[s, n] = a[s - 1, n];
                    if (n >= items[s - 1].Weight && (a[s - 1, n - items[s - 1].Weight] + items[s - 1].Price >
                    a[s, n])) a[s, n] = a[s - 1, n - items[s - 1].Weight] + items[s - 1].Price;
                }
            }


            return a[k, capacity];
        }
    }
}
