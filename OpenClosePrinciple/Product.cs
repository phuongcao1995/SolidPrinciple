namespace OpenClosePrinciple
{
    public class Product
    {
        public string Name { get; set; }
        public Color Color { get; set; }
        public Size Size { get; set; }

        public Product(string name, Color color, Size size)
        {
            Name = name;
            Color = color;
            Size = size;
        }
    }

    //public static class ProductFilter
    //{
    //    public static IEnumerable<Product> FilterBySize(this IEnumerable<Product> products , Size size)
    //    {
    //        foreach (var item in products)
    //        {
    //            if(item.Size == size)
    //            {
    //               yield return item;
    //            }
    //        }
    //    }
    //}
}
