using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleSystem
{
    class Reservation
    {
        #region Sql Part
        private readonly SqlConnection con =
            new SqlConnection(@"Data Source=DESKTOP-O3O7OSS;Initial Catalog=SimpleAppDataBase;Integrated Security=True;");

        private SqlCommand cmd;

        public void InsertDataToDatabase()
        {
            con.Open();
            cmd = new SqlCommand(
                "insert into Reservation values('" + @Name + "','" + @Surname + "', '" +
                @GuestNumber + "', '" + @DateFrom + "', '" + @DateTo + "', '" +
                @Days + "', '" + @Price + "', '" + @ParkingSpot + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Succfully inserted");
            con.Close();
        }
        /// <summary>
        /// Default update database requiring only Reservation Id
        /// </summary>
        /// <param name="reservationId"></param>
        public void UpdateDataBase(int reservationId)
        {
            con.Open();
            string query = "UPDATE Reservation SET Name = '" + @Name + "', Surname =  '" + @Surname +
                           "', GuestNumber = '" + @GuestNumber + "', DateFrom = '" + @DateFrom + "', DateTo = '" +
                           @DateTo + "', CountDays = '" + @Days + "', Price = '" + @Price + "', ParkingSpot = '" +
                           @ParkingSpot + "' WHERE ReservationId = '"+reservationId+"'";
            cmd = new SqlCommand(query, con);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Succfully updated");
            con.Close();
        }

        public void DeleteQueryFromDataBase(int reservationId)
        {
            con.Open();
            string query = "DELETE FROM Reservation WHERE ReservationId = '"+reservationId+"'";
            cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Succefuly deleted");
            con.Close();
        }

        public int GetAllReservation()
        {
            string query = "SELECT COUNT(*) FROM Reservation";
            int count = 0;
            con.Open();
            cmd = new SqlCommand(query, con);

            count = (int) cmd.ExecuteScalar();
            con.Close();

            return count;
        }
        #endregion

        private int PricePerNight = 60;
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

        public override string ToString()
        {
            return $"REZ ID:  IME: {Name}, PREZIME: {Surname}, \n " +
                   $"Broj Gostiju: {GuestNumber}, Od: {DateFrom}, DO: {DateTo}, \n" +
                   $"Broj Dana: {Days}, Cijena: {Price}, Parkiranje: {ParkingSpot}";
        }
    }
}
