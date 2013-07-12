using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wintellect.PowerCollections;

public class ShoppingCenter
{
    private MultiDictionary<string, Product> allProductsByName;
    private OrderedMultiDictionary<decimal, Product> allProductsByPrice;
    private MultiDictionary<string, Product> allProductsByProducer;
    private MultiDictionary<string, Product> allProductsByNameAndProducer;

    public ShoppingCenter()
    {
        allProductsByName = new MultiDictionary<string, Product>(true);
        allProductsByPrice = new OrderedMultiDictionary<decimal, Product>(true);
        allProductsByProducer = new MultiDictionary<string, Product>(true);
        allProductsByNameAndProducer = new MultiDictionary<string, Product>(true);
    }

    public string AddProducts(string name, decimal price, string producer)
    {
        Product newProduct = new Product(name, producer, price);

        allProductsByName.Add(name, newProduct);
        allProductsByPrice.Add(price, newProduct);
        allProductsByProducer.Add(producer, newProduct);
        allProductsByNameAndProducer.Add(newProduct.GetKey(), newProduct);

        return "Product added";
    }

    public string DeleteProducts(string name, string producer)
    {
        int counter = 0;
        string key = name + ";" + producer;
        if (allProductsByNameAndProducer.ContainsKey(key))
        {
            foreach (var item in allProductsByNameAndProducer[key])
            {
                counter++;
                allProductsByName.Remove(item.Name, item);
                allProductsByProducer.Remove(item.Producer, item);
                allProductsByPrice.Remove(item.Price, item);
            }
            allProductsByNameAndProducer.Remove(key);
            return counter + " products deleted";
        }
        else
        {
            return "No products found";
        }
    }

    public string DeleteProducts(string producer)
    {
        int counter = 0;
        if (allProductsByProducer.ContainsKey(producer))
        {
            foreach (var item in allProductsByProducer[producer])
            {
                counter++;
                allProductsByName.Remove(item.Name, item);
                allProductsByNameAndProducer.Remove(item.Name + ";" + item.Producer);
                allProductsByPrice.Remove(item.Price, item);
            }
            allProductsByProducer.Remove(producer);
            return counter + " products deleted";
        }
        else
        {
            return "No products found";
        }
    }

    public string FindProductsByName(string name)
    {
        StringBuilder result = new StringBuilder();
        if (allProductsByName.ContainsKey(name))
        {
            List<Product> asd = new List<Product>(allProductsByName[name]);
            asd.Sort();
            for (int i = 0; i < asd.Count; i++)
            {
                result.AppendLine(asd[i].ToString());
            }
        }
        else
        {
            result.AppendLine("No products found");
        }

        result.Length -= 2;

        return result.ToString();
    }

    public string FindProductsByProducer(string producer)
    {
        StringBuilder result = new StringBuilder();
        if (allProductsByProducer.ContainsKey(producer))
        {
            List<Product> asd = new List<Product>(allProductsByProducer[producer]);
            asd.Sort();
            for (int i = 0; i < asd.Count; i++)
            {
                result.AppendLine(asd[i].ToString());
            }
        }
        else
        {
            result.AppendLine("No products found");
        }

        result.Length -= 2;

        return result.ToString();
    }

    public string FindProductsByPriceRange(decimal fromPrice, decimal toPrice)
    {
        StringBuilder result = new StringBuilder();
        var searchResult = allProductsByPrice.Range(fromPrice, true, toPrice, true);
        List<Product> asd = new List<Product>(searchResult.Values);
        asd.Sort();
        if (searchResult.Count > 0)
        {
            for (int i = 0; i < asd.Count; i++)
            {
                result.AppendLine(asd[i].ToString());
            }
        }
        else
        {
            result.AppendLine("No products found");
        }

        result.Length -= 2;

        return result.ToString();
    }

    public string ParseCommands(string command)
    {
        StringBuilder result = new StringBuilder();
        string[] commandType = command.Split(' ');

        int commandTypeEnd = command.IndexOf(' ');

        string[] commandParams = command.Substring(commandTypeEnd).Trim().Split(';');

        switch (commandType[0])
        {
            case "AddProduct":
                result.AppendLine(AddProducts(commandParams[0], decimal.Parse(commandParams[1]), commandParams[2]));
                break;
            case "DeleteProducts":
                if (commandParams.Length == 2)
                {
                    result.AppendLine(DeleteProducts(commandParams[0], commandParams[1]));
                }
                else
                {
                    result.AppendLine(DeleteProducts(commandParams[0]));
                }
                break;
            case "FindProductsByName":
                result.AppendLine(FindProductsByName(commandParams[0]));
                break;
            case "FindProductsByPriceRange":
                result.AppendLine(FindProductsByPriceRange(decimal.Parse(commandParams[0]), decimal.Parse(commandParams[1])));
                break;
            case "FindProductsByProducer":
                result.AppendLine(FindProductsByProducer(commandParams[0]));
                break;
            default:
                break;
        }

        result.Length -= 2;

        return result.ToString();
    }
}
