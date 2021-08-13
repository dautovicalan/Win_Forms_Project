using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System.IO;
using iText.Kernel.Geom;

namespace SimpleSystem.Forms
{
    public partial class DetailReservationInfoForm : Form
    {
        private int ReservationId;
        public DetailReservationInfoForm(string reservationId, string reservationName, string reservationSurname, 
            string guestNumber, string dateFrom, string dateTo, string countDays, string price, string parkingSpot)
        {
            InitializeComponent();

            this.ReservationId = Convert.ToInt16(reservationId);
            this.NameTextBox.Text = reservationName;
            this.SurnameTextBox.Text = reservationSurname;
            this.GuestNumberTextBox.Text = guestNumber;
            this.DateFromTextBox.Text = (dateFrom);
            this.DateToTextBox.Text = (dateTo);
            this.DayCountTextBox.Text = (countDays);
            this.PriceTextBox.Text = (price);
            this.ParkingSpotTextBox.Text = (parkingSpot);
        }

       

        private void FinishAndSaveButton_Click(object sender, EventArgs e)
        {
            var reservation = new Reservation
            {
                Name = this.NameTextBox.Text,
                Surname = this.SurnameTextBox.Text,
                GuestNumber = Convert.ToInt16(this.GuestNumberTextBox.Text),
                DateFrom = Convert.ToDateTime(this.DateFromTextBox.Text),
                DateTo = Convert.ToDateTime(this.DateToTextBox.Text)
            };
            reservation.UpdateDataBase(ReservationId);
            ShowReservationForm srf = (ShowReservationForm) Application.OpenForms["ShowReservationForm"];
            srf.ShowSqlData();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var reservation = new Reservation
            {
                Name = this.NameTextBox.Text,
                Surname = this.SurnameTextBox.Text,
                GuestNumber = Convert.ToInt16(this.GuestNumberTextBox.Text),
                DateFrom = Convert.ToDateTime(this.DateFromTextBox.Text),
                DateTo = Convert.ToDateTime(this.DateToTextBox.Text)
            };
            reservation.DeleteQueryFromDataBase(ReservationId);
            this.Close();
            ShowReservationForm srf = (ShowReservationForm) Application.OpenForms["ShowReservationForm"];
            srf.ShowSqlData();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            this.NameTextBox.ReadOnly = false;
            this.SurnameTextBox.ReadOnly = false;
            this.GuestNumberTextBox.ReadOnly = false;
            this.DateFromTextBox.ReadOnly = false;
            this.DateToTextBox.ReadOnly = false;
            this.DayCountTextBox.ReadOnly = false;
            this.PriceTextBox.ReadOnly = false;
            this.ParkingSpotTextBox.ReadOnly = false;
        }

        private void PrintToPdfButton_Click(object sender, EventArgs e)
        {
            var reservation = new Reservation
            {
                Name = this.NameTextBox.Text,
                Surname = this.SurnameTextBox.Text,
                GuestNumber = Convert.ToInt16(this.GuestNumberTextBox.Text),
                DateFrom = Convert.ToDateTime(this.DateFromTextBox.Text),
                DateTo = Convert.ToDateTime(this.DateToTextBox.Text)
            };
            saveFileDialog1.ShowDialog();
            using (FileStream stream = new FileStream( saveFileDialog1.FileName+ ".pdf", FileMode.Create))
            {
                PdfWriter writer = new PdfWriter(stream);
                PdfDocument pdf = new PdfDocument(writer);
                Document document = new Document(pdf);
                Paragraph header = new Paragraph("HEADER")
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetFontSize(20);
                Paragraph p1 = new Paragraph(reservation.ToString())
                    .SetFontSize(20);
 
                document.Add(header);
                document.Add(p1);
                document.Close();
            }
        }
    }
}
