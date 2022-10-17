namespace LB_08
{
    public class Item
    {
        public int Price { get; }
        public int Weight { get; }        

        public Item(int price, int weight)
        {
            Price = price;
            Weight = weight;
        }

        public override string ToString()
        {
            return $"Цена - {Price, 3}; Вес - {Weight, 3};";
        }
    }
}
