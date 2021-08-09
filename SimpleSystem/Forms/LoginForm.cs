using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleSystem.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
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
    }
}
