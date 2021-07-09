using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Services
{
    class BrazilTaxService: ITaxService
    {

        public double Tax(double amount)
        {
            return (amount <= 100.0) ? amount * 0.2 : amount * 0.15;
        }

    }
}
