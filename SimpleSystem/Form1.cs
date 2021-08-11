using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using SimpleSystem.Forms;

namespace SimpleSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            LoginForm login = new LoginForm();
            login.ShowDialog();
            if (login.StartProgram())
            {
                InitializeComponent();
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
            LoadForm(new ReservationForm());
        }
        private void CheckCurrentReservationButton_Click(object sender, EventArgs e)
        { 
            LoadForm(new ShowReservationForm());
        }
        private void GoBackButton_Click(object sender, EventArgs e)
        {
            LoadForm(new MainMenuForm());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Maximazing form to original size
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;

            LoadForm(new MainMenuForm());
        }

        private void label1_Click(object sender, EventArgs e)
        {
            LoadForm(new MainMenuForm());
        }

        private void NewReservationButton_MouseHover(object sender, EventArgs e)
        {
            this.NewReservationButton.BackColor = Color.Aqua;
        }

        private void NewReservationButton_MouseLeave(object sender, EventArgs e)
        {
            this.NewReservationButton.BackColor = Color.MediumPurple;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CheckCurrentReservationButton_MouseHover(object sender, EventArgs e)
        {
            this.CheckCurrentReservationButton.BackColor = Color.Aqua;
        }

        private void CheckCurrentReservationButton_MouseLeave(object sender, EventArgs e)
        {
            this.CheckCurrentReservationButton.BackColor = Color.MediumPurple;

        }
    }
}
