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
    public partial class LoginForm : Form
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
        public LoginForm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private bool Success = false;
        public bool StartProgram()
        {
            return Success;
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            if (UserNameTextBox.Text == "Alan" && PasswordTextBox.Text == "12345")
            { 
                this.Close();
                Success = true;

            }
            else
            {
                this.WrongPasswordLabel.Text = "WRONG USERNAME OR PASSWORD";
            }

        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.UserNameTextBox.Select();
        }
    }
}
