using System;
using System.Text;

namespace Bank
{
    public class Deposit : Account, IWithdrawable
    {
        /// <summary>
        /// Make a deposit to a new customer. Enter customer name, starting balance and interest rate.
        /// </summary>
        /// <param name="customer"></param>
        /// <param name="startBalance"></param>
        /// <param name="interestRate"></param>
        public Deposit(Customer customer, decimal startBalance, double interestRate, byte months)
            : base(customer, startBalance, interestRate, months, DateTime.Now)
        {

        }

        public override double InterestRate
        {
            get
            {
                if (base.Balance < 1000)
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
        /// Withdraw money from customers account
        /// </summary>
        /// <param name="sumToWithdraw"></param>
        public void WithdrawSum(decimal sumToWithdraw)
        {
            if (this.Balance < sumToWithdraw)
            {
                throw new ArgumentOutOfRangeException("You do not have enough money on your balance");
            }
            this.Balance -= sumToWithdraw;
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
