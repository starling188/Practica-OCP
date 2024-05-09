using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Interface
{
    public interface ITaxStrategy
    {
        decimal CalculateTax(decimal taxableIncome);
    }
}
