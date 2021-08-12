using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

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
            try
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
                reservation.InsertDataToDatabase();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearAllButton_Click(object sender, EventArgs e)
        {
            this.NameTextbBox.Clear();
            this.SurnameTextBox.Clear();
            this.GuestNumberTextBox.Clear();
            this.ParkingSpotTextBox.Clear();
        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {
            this.NameTextbBox.Select();
        }
    }
}
