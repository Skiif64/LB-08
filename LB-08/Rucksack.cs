namespace LB_08
{
    public class Rucksack
    {
        public int GetMaximumValue(Item[] items, int capacity)
        {
            int k = items.Length;
            int[,] a = new int[k + 1, capacity + 1];
            for (int s = 1; s <= k; s++)
            {
                // s - максимальный номер предмета, который можно использовать
                for (int n = 1; n <= capacity; n++)
                {// n - вместимости рюкзака
                    a[s, n] = a[s - 1, n];
                    if (n >= items[s - 1].Weight && (a[s - 1, n - items[s - 1].Weight] + items[s - 1].Value >
                    a[s, n])) a[s, n] = a[s - 1, n - items[s - 1].Weight] + items[s - 1].Value;
                }
            }


            return a[k, capacity];
        }
    }
}