namespace LB_08
{
    public class Item
    {
        public int Price { get; set; }
        public int Weight { get; set; }

        public Item()
        {

        }

        public Item(int price, int weight)
        {
            Price = price;
            Weight = weight;
        }
    }
}
