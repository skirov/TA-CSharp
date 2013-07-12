using System;
using System.Text;


public class Product : IComparable<Product>
{
    public string Name { get; set; }
    public string Producer { get; set; }
    public decimal Price { get; set; }

    public Product(string name, string producer, decimal price)
    {
        this.Name = name;
        this.Producer = producer;
        this.Price = price;
    }

    public string GetKey()
    {
        return this.Name + ";" + this.Producer;
    }

    public int CompareTo(Product other)
    {
        int resultOfCompare = this.Name.CompareTo(other.Name);
        if (resultOfCompare == 0)
        {
            resultOfCompare = this.Producer.CompareTo(other.Producer);
        }
        if (resultOfCompare == 0)
        {
            resultOfCompare = this.Price.CompareTo(other.Price);
        }
        return resultOfCompare;
    }

    public override string ToString()
    {

        StringBuilder result = new StringBuilder();
        result.Append("{");
        result.AppendFormat("{0};", this.Name);
        result.AppendFormat("{0};", this.Producer);
        result.AppendFormat("{0:0.00}", this.Price);
        result.Append("}");

        return result.ToString();
    }
}

