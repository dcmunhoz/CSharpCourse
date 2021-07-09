using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Services
{
    class PaypalService : IPaymentService
    {
        private double PaymentTax;
        private double Fee;

        public PaypalService()
        {
            PaymentTax = 2.0;
            Fee = 1.0;
        }

        public double Calculate(double installmentValue, int installmentNumber)
        {
            double feeValue = (installmentValue * (Fee / 100)) * installmentNumber;
            installmentValue +=  feeValue;
            double taxValue = installmentValue * (PaymentTax / 100);
            installmentValue += taxValue;

            return installmentValue;
        }
    }
}
