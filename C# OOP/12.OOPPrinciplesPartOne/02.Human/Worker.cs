using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    public class Worker : Human
    {
        private decimal weekSalary;
        private decimal workHoursPerDay;

        public Worker(string firstName, string secondName)
            : base(firstName, secondName)
        {

        }

        #region Properties

        public decimal WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set { this.workHoursPerDay = value; }
        }

        public decimal WeekSalary
        {
            get { return this.weekSalary; }
            set { this.weekSalary = value; }
        }

        #endregion

        public decimal MoneyPerHour()
        {
            return WeekSalary / (workHoursPerDay * 5);
        }

        public override string ToString()
        {
            string firstAndLastName = base.FirstName + " " + base.SecondName;

            return firstAndLastName;
        }
    }
}
