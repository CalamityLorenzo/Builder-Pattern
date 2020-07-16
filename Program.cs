using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        private static void ver2()
        {
            var builder = v2.ProductBuilderComposer.NewProduct;
            builder
                    .SetName("This product name")
                    .SetWeight("400", WeightUnits.Kilograms)
                    .SetBestBefore(DateTime.UtcNow)
            //pBuider.SetName("PEgs").SetWeight()
            
        }
        private static void v1()
        {
            var pBuilder = new v1.ProuductBuilder();
            pBuilder.SetDescription("This product is describeed")
                    .SetName("This product name")
                    .SetBestBefore(DateTime.UtcNow);

            var product = pBuilder.Build();
            Console.WriteLine(product);
        }
    }
}
