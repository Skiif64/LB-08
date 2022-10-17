using System;

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
            Console.WriteLine("Цена и вес предметов: ");
            Console.WriteLine(string.Join<Item>("\n", items));
            var size = 13;
            Console.WriteLine($"Размер рюкзака: {size}");
            var rucksack = new Rucksack();
            var result = rucksack.GetMaximumValue(items, size);
            Console.WriteLine($"Наивысший показатель полезности: {result}");
            Console.ReadLine();
        }
    }
}
