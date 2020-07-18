namespace v2
{
    public abstract class ProductBuilder{
        protected Product _product;
        public ProductBuilder()=>_product = new Product();
        public Product Build()=>_product;
    }
}