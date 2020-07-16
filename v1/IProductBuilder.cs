namespace v1
{


    using System;

    public interface IProductBuilder
    {
        IProductBuilder SetName(string name);
        IProductBuilder SetDescription(string description);
        IProductBuilder SetWeight(string weight, WeightUnits unit);
        IProductBuilder SetBestBefore(DateTime dte);
        Product Build();
    }
}