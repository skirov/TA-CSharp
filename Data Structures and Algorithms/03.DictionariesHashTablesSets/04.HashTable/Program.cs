using System;
class Program
{
    static void Main()
    {
        HashTable<string, int> table = new HashTable<string, int>();

        table.Add("Pesho", 5);
        table.Add("Gosho", 6);
        table.Add("Misho", 4);
        table.Add("Ceca", 3);
        table.Remove("Pesho");
        table["Misho"] = 5;

        foreach (var item in table)
        {
            Console.WriteLine("{0} -> {1}", item.Key, item.Value);
        }
    }
}

