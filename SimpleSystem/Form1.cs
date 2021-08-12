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
using FontAwesome.Sharp;
using SimpleSystem.Forms;

namespace SimpleSystem
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public Form1()
        {
            LoginForm login = new LoginForm();
            login.ShowDialog();
            if (login.StartProgram())
            {
                InitializeComponent();
                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            }
        }

        /// <summary>
        /// Loading other forms to the main form (Form1).
        /// Function parametar is an object
        /// </summary>
        /// <param name="Form"></param>
        public void LoadForm(object Form)
        {
            if (this.MainPanel.Controls.Count > 0)
            {
                this.MainPanel.Controls.RemoveAt(0);
            }
            //Creating a form object and setting his properties
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = FormBorderStyle.None;
            //Adding created form to the MainPanel in Form1
            this.MainPanel.Controls.Add(f);
            this.MainPanel.Tag = f;
            f.Show();
        }

        private void NewReservationButton_Click(object sender, EventArgs e)
        {
            NewReservationButton.BackColor = Color.FromArgb(46, 51, 73);
            LoadForm(new ReservationForm());
        }
        private void CheckCurrentReservationButton_Click(object sender, EventArgs e)
        { 
            CheckCurrentReservationButton.BackColor = Color.FromArgb(46, 51, 73);
            LoadForm(new ShowReservationForm());
        }
        private void GoBackButton_Click(object sender, EventArgs e)
        {
            LoadForm(new MainMenuForm());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadForm(new MainMenuForm());
        }

        private void label1_Click(object sender, EventArgs e)
        {
            LoadForm(new MainMenuForm());
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NewReservationButton_Leave(object sender, EventArgs e)
        {
            NewReservationButton.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void CheckCurrentReservationButton_Leave(object sender, EventArgs e)
        {
            CheckCurrentReservationButton.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SettingsButton.BackColor = Color.FromArgb(46, 51, 73);
            LoadForm(new SettingsForm());
        }

        private void SettingsButton_Leave(object sender, EventArgs e)
        {
            SettingsButton.BackColor = Color.FromArgb(24, 30, 54);
        }
    }
}