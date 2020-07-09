using Ex36.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ex36.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {
        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if(checkOut <= checkIn)
            {
                throw new DomainException("\nReservatiom dates for update must be future dates");
            }

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            //TimeSpan que é a duração de algo
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;

            if (checkIn < now || checkOut < now)
            {
                // lancando uma nova execao da classe DomainException! 
                throw new DomainException("Reservatiom dates for update must be future dates");
            }
            if (checkOut <= checkIn)
            {
                throw new DomainException("Reservatiom dates for update must be future dates");
            }

            CheckIn = checkIn;
            CheckOut = checkOut;

        }

        public override string ToString()
        {
            return "Room " + RoomNumber +
                ", Check-in: " +
                CheckIn.ToString("dd/MM/yyyy") +
                ", Check-out: " + CheckOut.ToString("dd/MM/yyyy") +
                ", " + Duration() +
                " nights";
        }
    }
}
