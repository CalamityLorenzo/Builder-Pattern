namespace v2
{
    public class ProductDescriptionBuilder<T> : ProductWeightBuilder<ProductDescriptionBuilder<T>> where T : ProductDescriptionBuilder<T>
    {
        public T SetProductDescription(string name)
        {
            this._product.Description= name;
            return (T)this;
        }
    }
}