namespace command
{
    using System;
    /// This class is the Reciever
    /// It makes changes tothe product 
    /// The methids in this class are what we changing to the command pattern
    public class ProductManager
    {
        private readonly Product _product;
        public ProductManager(Product product) => this._product = product;
        public void IncreaseCostPerunit(double amount)
        {
            this._product.CostPerUnit += amount;
            Console.WriteLine($"Cost perunit: Increased {amount} : {this._product.CostPerUnit}");
        }
        public void DecreasedCostPerunit(double amount)
        {
            this._product.CostPerUnit -= amount;
            Console.WriteLine($"Cost perunit: Decreased {amount} : {this._product.CostPerUnit}");
        }
    }
}