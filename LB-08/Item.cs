namespace LB_08
{
    public class Item
    {
        public int Value { get; }
        public int Weight { get; }        

        public Item(int price, int weight)
        {
            Value = price;
            Weight = weight;
        }

        public override string ToString()
        {
            return $"Цена - {Value, 3}; Вес - {Weight, 3};";
        }
    }
}
