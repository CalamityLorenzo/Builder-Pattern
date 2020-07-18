namespace v2
{
    public class ProductWeightBuilder<T> : ProductNameBuilder<ProductWeightBuilder<T>> where T : ProductWeightBuilder<T>
    {
        public T SetWeight(string weight, WeightUnits units)
        {
            this._product.Weight = weight;
            this._product.WeightUnit = (int)units;
            return (T)this;
        }   
    }
}