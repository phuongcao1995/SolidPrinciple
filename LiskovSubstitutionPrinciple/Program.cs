namespace LiskovSubstitutionPrinciple
{
    public class Program
    {
        static void Main(string[] args)
        {
            var rectangle = new Rectangle(2, 3);
            Console.WriteLine(Rectangle.Area(rectangle));

            Rectangle square = new Square();
            square.Width = 4;
            Console.WriteLine(Rectangle.Area(square));

            Console.ReadLine();

        }
    }
}