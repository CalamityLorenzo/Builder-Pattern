using System;

public class Product
{
    public string Name{get;set;}
    public string Description{get;set;}
    public string Weight{get;set;}
    public int WeightUnit{get;set;}
    public DateTime? BestBefore{get;set;}

    public override string ToString()=>
        $"{Name} {Description} {Weight} {BestBefore}";
}