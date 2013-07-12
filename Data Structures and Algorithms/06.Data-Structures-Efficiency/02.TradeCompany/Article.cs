using System;
using System.Text;

public class Article : IComparable
{
    public string Barcode { get; private set; }
    public string Vendor { get; private set; }
    public string Title { get; private set; }
    public decimal Price { get; private set; }

    public Article(string title, decimal price)
    {
        this.Title = title;
        this.Price = price;
    }

    public Article(string title, decimal price, string vendor, string barcode)
        : this(title, price)
    {
        this.Vendor = vendor;
        this.Barcode = barcode;
    }

    public int CompareTo(object obj)
    {
        return this.Price.CompareTo(obj);
    }

    public override string ToString()
    {
        StringBuilder toString = new StringBuilder();

        toString.AppendFormat("Article title - {0}", this.Title);
        toString.AppendLine();
        toString.AppendFormat("Article price - {0}", this.Price);
        toString.AppendLine();
        toString.AppendFormat("Article title - {0}", this.Vendor);
        toString.AppendLine();
        toString.AppendFormat("Article vendor - {0}", this.Barcode);

        return toString.ToString();
    }
}