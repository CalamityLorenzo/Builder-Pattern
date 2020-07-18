namespace v2
{
    public class ProductNameBuilder<T> : ProductBuilder where T : ProductNameBuilder<T>
    {
        public T SetName(string name)
        {
            this._product.Name= name;
            return (T)this;
        }
    }
}