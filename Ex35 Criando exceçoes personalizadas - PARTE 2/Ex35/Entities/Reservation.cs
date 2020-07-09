using System;

namespace Ex35.Entities
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

        public string UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;

            if (checkIn < now || checkOut < now)
            {
                return "Reservatiom dates for update must be future dates";
            }
            if (checkOut <= checkIn)
            {
                return "Reservatiom dates for update must be future dates";
            }
            CheckIn = checkIn;
            CheckOut = checkOut;

            return null; //importante para string

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
