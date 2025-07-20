using TryCatchExerciceResolvido.Entities.Exceptions;

namespace TryCatchExerciceResolvido.Entities
{
    internal class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation() { }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainException("Check-out date must be after check-in date");
            }

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan durantion = CheckOut.Subtract(CheckIn);
            return (int) durantion.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkOut < now || checkIn < now)
            {
                throw new DomainException("Reservation dates for update must be future dates");
            }
            else if (checkOut <= checkIn)
            {
               throw new DomainException("Check-out date must be after check-in date");
            }
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            return $"Reservation: Room {RoomNumber}, " +
                $"Check-in: {CheckIn.ToString("dd/MM/yyyy")}, " +
                $"Check-out: {CheckOut.ToString("dd/MM/yyyy")}, " +
                $"{Duration()} nights.";
        }
    }
}
