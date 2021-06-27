using System;
using System.Collections.Generic;
using System.Globalization;


namespace Datas
{
    class Program
    {
        static void Main(string[] args)
        {


            string inicio = "15/03/2021";
            string fim = "27/03/2021";

            DateTime dataInicio = DateTime.Parse(inicio);
            DateTime dataFim = DateTime.Parse(fim);

            TimeSpan dif = dataFim.Subtract(dataInicio);

            Console.WriteLine(dataInicio);
            Console.WriteLine(dataFim);
            Console.WriteLine(dif);


            List<DateTime> horarios = new List<DateTime>();
            for (int i = 0; i <= dif.Days; i++)
            {

                DateTime dia = dataInicio.AddDays(i);
                horarios.Add(dia);
            }

            foreach (DateTime data in horarios)
            {
                Console.WriteLine(data.ToShortDateString());
            }
        }
    }
}
