namespace  v2
{
    using System;
    public class ProductBuilderComposer : ProductBestBeforeBuilder<ProductBuilderComposer> {
        public static ProductBuilderComposer NewProduct  = new ProductBuilderComposer();
    }
}