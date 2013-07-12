using System;
using System.Text;

namespace Bank
{
    public class Loan : Account, IDepositable
    {
        /// <summary>
        /// Get new customer a loan. Enter customer name, loan sum and interest rate.
        /// </summary>
        /// <param name="customer"></param>
        /// <param name="startBalance"></param>
        /// <param name="interestRate"></param>
        public Loan(Customer customer, decimal loanSum, double interestRate, byte months)
            : base(customer, loanSum, interestRate, months, DateTime.Now)
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
                else if (base.Customer.GetType().Name == "CompanyCustomer" && monthsFromBeginning.Days <= 60)
                {
                    return 0;
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
