using Practica.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class TaxCaculator
    {

        private ITaxStrategy _strategy;

        public TaxCaculator( ITaxStrategy tax)
        {
            _strategy = tax;
        }


        public void SetStrategy( ITaxStrategy strategy )
        {
            _strategy = strategy;
        }

        public decimal Calculate(decimal totalIncome, decimal deduction)
        {
            decimal taxableIncome = totalIncome - deduction;
            decimal taxAmount = _strategy.CalculateTax(taxableIncome);
            return taxAmount;
        }


    }
}
