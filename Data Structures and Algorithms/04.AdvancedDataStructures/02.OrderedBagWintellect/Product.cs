using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Product : IComparable<Product>
{
    public string Name { get; set; }
    public int Price{ get; set; }

    public Product(string name, int price)
    {
        this.Name = name;
        this.Price = price;
    }

    public int CompareTo(Product obj)
    {
        return this.Price.CompareTo(obj.Price);
    }
}