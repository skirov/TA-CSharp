using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Mortgage : Account
    {
        public Mortgage(Customer customer, decimal startBalance, double interestRate, byte months)
            : base(customer, startBalance, interestRate, months, DateTime.Now)
        {
        }

        public override double InterestRate
        {
            get
            {
                TimeSpan monthsFromBeginning = DateTime.Now - base.DateOfCreation;
                if (base.Customer.GetType().Name == "IndividualCustomer" && monthsFromBeginning.Days <= 90)
                {
                    return 0;
                }
                else if (base.Customer.GetType().Name == "CompanyCustomer" && monthsFromBeginning.Days <= 180)
                {
                    return base.InterestRate / 2;
                }
                else
                {
                    return base.InterestRate;
                }
            }
        }

        /// <summary>
        /// Deposit money from customers account
        /// </summary>
        /// <param name="sumToDeposit"></param>
        public void DepositSum(decimal sumToDeposit)
        {
            this.Balance += sumToDeposit;
        }

        public override string ToString()
        {
            StringBuilder toString = new StringBuilder();

            toString.AppendLine("---Customer info---");
            toString.AppendFormat("+ Name: {0}", base.Customer.Name);
            toString.AppendLine();
            toString.AppendLine();
            toString.AppendLine("---Account info---");
            toString.AppendFormat("+ Balance: {0:C}", base.Balance);
            toString.AppendLine();
            toString.AppendFormat("+ Interest rate: {0:P}", this.InterestRate);
            toString.AppendLine();
            toString.AppendFormat("+ Interest amount for this month: {0:C}", CalculateInterestAmount());
            toString.AppendLine();
            toString.AppendFormat("+ Date of creation: {0}", base.DateOfCreation);
            toString.AppendLine();
            toString.AppendFormat("+ Date of expiry: {0}", base.DateOfExpiry);

            return toString.ToString();
        }
    }
}
