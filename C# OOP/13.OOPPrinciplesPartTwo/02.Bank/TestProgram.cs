using System;

namespace Bank
{
    public class TestProgram
    {
        static void Main()
        {
            CompanyCustomer company = new CompanyCustomer("X OOD");
            IndividualCustomer individual = new IndividualCustomer("Ivan Petrov", 21);
            IndividualCustomer individual2 = new IndividualCustomer("Ivan Petrov", 16);

            Account[] accounts = 
            {
                new Deposit(individual, 1500, 5, 12),
                new Loan(company, 50000, 5, 6),
                new Mortgage(individual2, 75000, 10, 24),
            };

            foreach (var account in accounts)
            {
                Console.WriteLine(account);
                Console.WriteLine();
                Console.WriteLine("{0}", new string('-', 40));
                Console.WriteLine();
            }
        }
    }
}
