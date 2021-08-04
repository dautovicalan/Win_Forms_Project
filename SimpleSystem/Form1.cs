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
            InitializeComponent();
            LoadForm(new MainMenuForm());
        }

        //Button Creation still in progress - Alan
        public void CreateExitButtonDelegate()
        {
            Button ExitButton = new Button();
            this.Controls.Add(ExitButton);
            ExitButton.Text = "EXIT";
            ExitButton.Location = new Point(70, 70);
            ExitButton.Size = new Size(50, 100);
            ExitButton.Location = new Point(20, 50);
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

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            LoadForm(new MainMenuForm());
        }
    }
}
