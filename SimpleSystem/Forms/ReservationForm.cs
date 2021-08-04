using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleSystem
{
    public partial class ReservationForm : Form
    {
        public ReservationForm()
        {
            InitializeComponent();
        }

        private void CreateReservationButton_Click(object sender, EventArgs e)
        {
            var reservation = new Reservation
            {
                Name = this.NameTextbBox.Text,
                Surname = this.SurnameTextBox.Text,
                GuestNumber = Convert.ToInt16(this.GuestNumberTextBox.Text),
                DateFrom = this.DatePickerFrom.Value,
                DateTo = this.DatePickerTo.Value,
                ParkingSpot = Convert.ToChar(this.ParkingSpotTextBox.Text)
            };
            this.label8.Text = reservation.ToString();
        }
    }
}
