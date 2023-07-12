using System;
using Aula09.Entities;
using Aula09.Entities.Exceptions;

namespace Course {
    class Program {
        static void Main(string[] args) {


            try {
                Console.Write("Room Number: ");
                int number = int.Parse(Console.ReadLine());

                Console.WriteLine("Check-in Date: (DD/MM/YYYY)");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Check-Out Date: (DD/MM/YYYY)");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Enter data to update: ");
                Console.Write("Check-In Data: (DD/MM/YYYY)");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("check-Out Data: (DD/MM/YYYY)");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);


            }
            catch(DomainException e) {
                Console.WriteLine("Error in reservation: " + e.Message);
            }

            catch (FormatException e) {
                Console.WriteLine("Format error!!" + e.Message);
            }
            catch (Exception e) {
                Console.WriteLine("Unexpected Error!!" + e.Message);
            }
        }
    }
}