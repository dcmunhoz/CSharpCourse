using System;
using Delegates.Services;

namespace Delegates
{
    class Program
    {

        //delegate double BinaryNumericOperation(double n1, double n2);
        delegate void BinaryNumericOperation(double n1, double n2);

        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;
            /*
            BinaryNumericOperation op = CalculationService.Sum;

            double result = op(a, b);
            Console.WriteLine(result);
            */

            BinaryNumericOperation op = CalculationService.ShowSum;
            op += CalculationService.ShowMax;

            op.Invoke(a,b);

        }
    }
}
