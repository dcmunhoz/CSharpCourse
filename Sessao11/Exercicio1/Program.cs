using System;
using Exercicio1.Entities;
using Exercicio1.Entities.Exceptions;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room Number >: ");
                int room = int.Parse(Console.ReadLine());
                Console.Write("Check-in Date (DD/MM/YYYY) >: ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out Date (DD/MM/YYYY) >: ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(room, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation.ToString());

                Console.WriteLine();
                Console.WriteLine("Enter data to update reservation");
                Console.Write("Check-in Date (DD/MM/YYYY) >: ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out Date (DD/MM/YYYY) >: ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation.ToString());
            }
            catch (DomainException de)
            {
                Console.WriteLine("Error in reservation: " + de.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Other Excepiton: " + ex.Message);
            }

        }

    }
}

