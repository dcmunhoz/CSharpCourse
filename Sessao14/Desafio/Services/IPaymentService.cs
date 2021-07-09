namespace Desafio.Services
{
    interface IPaymentService
    {
        public double Calculate(double installmentValue, int installmentNumber);
    }
}
