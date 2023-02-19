namespace OpenClosePrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var apple = new Product("apple", Color.Green, Size.Small);
            var tree = new Product("tree", Color.Green, Size.Large);
            var house = new Product("house", Color.Blue, Size.Large);

            var products = new List<Product> { apple, tree, house };
            // var productFilter = products.FilterBySize(Size.Large);

            var filter = new Filters();
            var colorSpecification = new ColorSpecification(Color.Blue);
            var productsBlue = filter.Filter(products, colorSpecification);
            foreach (var item in productsBlue)
            {
                Console.WriteLine(item.Name);
            }

            var sizeSpecification = new SizeSpecification(Size.Large);
            var productsLarge = filter.Filter(products, sizeSpecification);
            foreach (var item in productsLarge)
            {
                Console.WriteLine(item.Name);
            }
            var andSpecification = new AndSpecification<Product>(colorSpecification, sizeSpecification);
            var productBluenAndLarge = filter.Filter(products, andSpecification);

            foreach (var item in productBluenAndLarge)
            {
                Console.WriteLine(item.Name);
            }

            Console.ReadLine();
        }
    }
}