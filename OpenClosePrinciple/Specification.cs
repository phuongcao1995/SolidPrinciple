namespace OpenClosePrinciple
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(T entity);
    }
    public class ColorSpecification : ISpecification<Product>
    {
        private Color _color;
        public ColorSpecification(Color color)
        {
            _color = color;
        }

        public bool IsSatisfied(Product entity)
        {
            return entity.Color == _color;
        }
    }

    public class SizeSpecification : ISpecification<Product>
    {
        private Size _size;
        public SizeSpecification(Size size)
        {
            _size = size;
        }

        public bool IsSatisfied(Product entity)
        {
            return entity.Size == _size;
        }
    }

    public class AndSpecification<T> : ISpecification<T>
    {
        private ISpecification<T> first, second;
        public AndSpecification(ISpecification<T> first, ISpecification<T> second)
        {
            this.first = first;
            this.second = second;
                
        }

        public bool IsSatisfied(T entity)
        {
            return first.IsSatisfied(entity) && first.IsSatisfied(entity);
        }
    }
}
