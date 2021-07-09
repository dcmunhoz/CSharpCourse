using System;
using System.Collections.Generic;
using System.Text;
using Desafio.Entities;

namespace Desafio.Services
{
    class Payment
    {
        private IPaymentService _paymentService;

        public Payment(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }


        public void GenerateInstallments(Contract contract, int installmentsNumber)
        {
            double installmentValue = contract.Value / installmentsNumber;

            for (int i = 1; i <= installmentsNumber; i++)
            {
                DateTime nextInstallment = contract.Date.AddMonths(i);

                double value = _paymentService.Calculate(installmentValue, i);

                contract.Installments.Add(new Installment(nextInstallment, value));
            }
        }
    }
}
