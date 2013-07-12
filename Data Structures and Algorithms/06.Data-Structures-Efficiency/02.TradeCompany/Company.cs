using System;
using System.Collections.Generic;
using Wintellect.PowerCollections;

public class Company
{
    public string Name { get; private set; }
    public OrderedMultiDictionary<decimal, Article> allArticles;

    public Company(string name)
    {
        this.Name = name;
        this.allArticles = new OrderedMultiDictionary<decimal, Article>(true);
    }

    public void AddArticle(Article article)
    {
        this.allArticles.Add(article.Price, article);
    }
}