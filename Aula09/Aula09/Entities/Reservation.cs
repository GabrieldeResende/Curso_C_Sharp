using System;
using Aula09.Entities.Exceptions;

namespace Aula09.Entities {
    internal class Reservation {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation() { 
        }

        public Reservation (int roomNumber, DateTime checkIn, DateTime checkOut) {

            if (checkOut <= checkIn) {
                throw new DomainException("Check-Out dates must be before check-in dates!!!");
            }

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration() {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates (DateTime checkIn, DateTime checkOut) {
            DateTime now = DateTime.Now;

            if (checkIn < now || checkOut < now) {
                throw new DomainException("Reservation Dates for updates must be future dates!!!");
            }

            if (checkOut < now || checkIn < now) {
                throw new DomainException("Check-Out dates must be before check-in dates!!!");
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString() {
            return "Room: " + RoomNumber + "Check-In: " + CheckIn.ToString("dd/MM/yyyy") + "Check-Out: " + CheckOut.ToString("dd/MM/yyyy") + ", " + Duration() + "nights"; 
        }
    }

}

