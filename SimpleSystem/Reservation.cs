using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSystem
{
    class Reservation
    {
        private int PricePerNight = 60;
        public int ReservationId { get; private set; } = 0;
        public string Name { get; set; }
        public string Surname { get; set; }
        public int GuestNumber { get; set; }
        //Treba dodati dodatne usluge
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }

        public double Days
        {
            get { return Math.Round((DateTo - DateFrom).TotalDays); }
        }

        public double Price
        {
            get { return Math.Round(PricePerNight * Days * GuestNumber); }
        }
        //Treba dodati nacin placanja
        public char ParkingSpot { get; set; }

        public Reservation()
        {
            ReservationId++;
        }

        public override string ToString()
        {
            return $"REZ ID: {ReservationId}, IME: {Name}, PREZIME: {Surname}, \n " +
                   $"Broj Gostiju: {GuestNumber}, Od: {DateFrom}, DO: {DateTo}, \n" +
                   $"Broj Dana: {Days}, Cijena: {Price}, Parkiranje: {ParkingSpot}";
        }
    }
}
