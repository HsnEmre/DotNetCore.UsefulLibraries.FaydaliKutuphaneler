using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.App
{



    public class LowSalaryCalculate2
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 2;
        }
    }
    public class MidSalaryCalculate2
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 4;
        }
    }

    public class HighSalaryCalculate2
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 6;
        }
    }
    public class MAnagerSalaryCalculate2
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 7;
        }
    }

    public class SalaryCalculator3
    {
        public decimal Calculate(decimal salary, Func<decimal, decimal> calculateDelege)
        {
            //return salaryCalculate.Calculate(salary);

            return calculateDelege(salary);
        }
    }

    internal class OCGoodWay2
    {
    }
}
