using System;
class Program
{
    static void Main()
    {
        Company newCompany = new Company("newCo.inc");

        Console.WriteLine("Adding 500 000 articles...");
        for (int i = 0; i < 500000; i++)
        {
            Article newArticle = new Article(i.ToString(), i+i, "Vendor"+i.ToString(), i.ToString());
            newCompany.AddArticle(newArticle);
        }

        var priceRange = newCompany.allArticles.Range(1, true, 10, true);

        Console.WriteLine("Articles from price range 1-10: ");
        foreach (var item in priceRange)
        {
            Console.WriteLine(item.Value);
            Console.WriteLine();
        }
    }
}

