using System;

namespace Ex34.Entities
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
