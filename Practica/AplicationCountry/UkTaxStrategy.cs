using Practica.Interface;


namespace Practica.AplicationCountry
{
    public class UkTaxStrategy : ITaxStrategy
    {
        public decimal CalculateTax(decimal taxableIncome)
        {
            decimal taxAmount = 0.0m;

            if (taxableIncome <= 12500)
            {
                taxAmount = 0.0m;
            }
            else if (taxableIncome <= 50000)
            {
                taxAmount = (taxableIncome - 12500) * 0.20m;
            }
            else if (taxableIncome <= 150000)
            {
                taxAmount = 7500.00m + (taxableIncome - 50000) * 0.40m;
            }
            else
            {
                taxAmount = 47500.00m + (taxableIncome - 150000) * 0.45m;
            }
            // mas impuestos de ser necesario abajo

            return taxAmount;
        }
    }
}
