namespace LiskovSubstitutionPrinciple
{
    public class Rectangle
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        public Rectangle()
        {
        }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }
        static public int Area(Rectangle rectangle) => rectangle.Width * rectangle.Height;

        public override string ToString()
        {
            return $"{nameof(Width)} {Width}, {nameof(Height)} {Height}";
        }
    }
}
