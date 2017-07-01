using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    public class Empolyee
    {

        private double baseSalary;
        private double salary;
        private double benefit;

        public double BaseSalary
        {
            get
            {
                return this.baseSalary;
            }
            set
            {
                if (value < 0)
                    this.baseSalary = 0;
                else
                    this.baseSalary = value;
            }
        }

        public double Benefit
        {
            get
            {
                return this.benefit;
            }
        }

        public double Salary
        {
            get
            {
                return this.salary = this.baseSalary + this.benefit;
            }
        }
        public bool Equals(Empolyee other)
        {
            return this.baseSalary == other.baseSalary
                && this.benefit == other.benefit
                && this.salary == other.salary;
        }
    }
}