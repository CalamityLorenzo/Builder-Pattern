using System;

namespace command
{
    class Program
    {
        static void Main(string[] args)
        {
         var pInvoker = new ModifyProductInvoker();
         var prod = new Product
            {
                Name="My Product",
                Description = "My product Description",
                CostPerUnit=0.10,
                WeightUnit = 1,
                Weight ="Heavy"
            };

            var pMan = new ProductManager(prod);

            pInvoker.SetCommand(new ProductCommands(pMan, ProductCommandList.Increase, 0.12));
            pInvoker.Invoke();
            pInvoker.SetCommand(new ProductCommands(pMan, ProductCommandList.Decrease, 5.12));
            pInvoker.Invoke();
            pInvoker.SetCommand(new ProductCommands(pMan, ProductCommandList.Increase, 17.03));
            pInvoker.Invoke();
            Console.WriteLine(prod);

        }

        static void BasicProduct(){
            var prod = new Product
            {
                Name="My Product",
                Description = "My product Description",
                CostPerUnit=0.10,
                WeightUnit = 1,
                Weight ="Heavy"
            };

            var pManager = new ProductManager(prod);

            pManager.IncreaseCostPerunit(43);
            pManager.DecreasedCostPerunit(42);
            // WIll match the changes wrought with the reciever.
            Console.WriteLine(prod);
        }
    }
}
