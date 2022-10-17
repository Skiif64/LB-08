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
            Console.WriteLine("Ценность и вес предметов: ");
            Console.WriteLine(string.Join<Item>("\n", items));
            var capacity = 13;
            Console.WriteLine($"Размер рюкзака: {capacity}");
            var rucksack = new Rucksack();
            var result = rucksack.GetMaximumValue(items, capacity);
            Console.WriteLine($"Наивысший показатель полезности: {result}");
            Console.ReadLine();
        }
    }
}
