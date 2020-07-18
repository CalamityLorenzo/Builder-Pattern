namespace command{
    using System;
    
    public class ProductCommands : ICommand
    {
        private ProductManager _productManager;
        private ProductCommandList _cmd;
        private double _amt;

        public ProductCommands(ProductManager productManager, ProductCommandList cmd, double amt)
        {
            _productManager = productManager;
            _cmd = cmd;
            _amt = amt;
        }

        public void ExecuteAction()
        {
            if(_cmd == ProductCommandList.Increase)
                _productManager.IncreaseCostPerunit(_amt);
            else
                _productManager.DecreasedCostPerunit(_amt);
        }
    }
}