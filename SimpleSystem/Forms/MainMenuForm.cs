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

namespace SimpleSystem.Forms
{
    public partial class MainMenuForm : Form
    {
        private readonly int ReservationCount = new Reservation().GetAllReservation();
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            this.ShowAllReservation.Text = ReservationCount.ToString();
        }
    }
}
