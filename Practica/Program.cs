

using Practica;
using Practica.AplicationCountry;

class Program
{
    static void Main(string[] args)
    {

        TaxCaculator caculator = new TaxCaculator(new USATaxStrategy()) ;

        decimal totalIncome = 100000;
        decimal deduction = 15000;
        decimal taxAmount = caculator.Calculate(totalIncome, deduction);

        Console.WriteLine($"el Tax Amount en la USA es de: {taxAmount}");

        Console.WriteLine("\n");

        caculator.SetStrategy(new UkTaxStrategy());
        taxAmount = caculator.Calculate(totalIncome, taxAmount);
        Console.WriteLine($"el monto en Reino unido es de : {taxAmount}");

        Console.WriteLine("\n");

        caculator.SetStrategy(new IndiaTaxStrategy());
        taxAmount = caculator.Calculate(totalIncome, deduction);
        Console.WriteLine($"el monto en India es de : {taxAmount}");

    }


}