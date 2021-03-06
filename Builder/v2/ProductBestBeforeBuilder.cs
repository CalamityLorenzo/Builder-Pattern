namespace v2
{
    using System;
    public class ProductBestBeforeBuilder<T> : ProductDescriptionBuilder<T>  where T : ProductBestBeforeBuilder<T>
    {
        public T SetBestBefore(DateTime bbf)
        {
            this._product.BestBefore = bbf;
            return (T)this;
        }
    }

}