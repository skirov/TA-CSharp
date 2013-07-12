using System;

namespace Bank
{
    public class Account : IAccount
    {
        private Customer customer;
        private decimal balance;
        private double interestRate;
        private byte months;
        private DateTime dateOfCreation;
        private DateTime dateOfExiry;

        public Account(Customer customer, decimal startBalance, double interestRate, byte months, DateTime dateOfCreation)
        {
            if (startBalance <= 0)
            {
                throw new ArgumentOutOfRangeException("The start balance must be bigger than 0.");
            }
            else
            {
                this.balance = startBalance;
            }

            this.customer = customer;
            this.interestRate = interestRate / 100;
            this.months = months;
            this.dateOfCreation = dateOfCreation;
        }

        #region Properties

        public Customer Customer
        {
            get { return this.customer; }
        }

        public decimal Balance
        {
            get { return this.balance; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The withdraw sum must be bigger than 0");
                }
                else
                {
                    this.balance = value;
                }
            }
        }

        public virtual double InterestRate
        {
            get { return this.interestRate; }
        }

        public DateTime DateOfExpiry
        {
            get
            {
                return this.dateOfCreation.AddMonths(this.months);
            }
        }

        public DateTime DateOfCreation
        {
            get
            {
                return this.dateOfCreation;
            }
        }

        #endregion

        /// <summary>
        /// Calculate the clients interest amount
        /// </summary>
        /// <param name="months"></param>
        /// <returns></returns>
        public virtual decimal CalculateInterestAmount()
        {
            return (decimal)this.interestRate * balance;
        }

    }
}
