namespace v1
{


    using System;

    // SImple but not extenisble.
    public class ProuductBuilder : IProductBuilder
    {
        private Product _builderProduct = new Product();

        public IProductBuilder SetDescription(string description)
        {
            _builderProduct.Description = description;
            return this;
        }

        public IProductBuilder SetName(string name)
        {
            _builderProduct.Name = name;
            return this;
        }

        public IProductBuilder SetWeight(string weight, WeightUnits unit)
        {
            _builderProduct.Weight = weight;
            _builderProduct.WeightUnit = (int)unit;
            return this;
        }

        public IProductBuilder SetBestBefore(DateTime dte)
        {
            _builderProduct.BestBefore = dte;
            return this;
        }

        public Product Build()
        {
            var newItem = _builderProduct;
            _builderProduct = null;
            return newItem;
        }
    }
}