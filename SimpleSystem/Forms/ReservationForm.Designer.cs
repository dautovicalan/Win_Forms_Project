
namespace SimpleSystem
{
    partial class ReservationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.DatePickerTo = new System.Windows.Forms.DateTimePicker();
            this.NameTextbBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GuestNumberTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DatePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.ParkingSpotTextBox = new System.Windows.Forms.TextBox();
            this.CreateReservationButton = new FontAwesome.Sharp.IconButton();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(465, 126);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ja Sam Rezervacijski Form";
            // 
            // DatePickerTo
            // 
            this.DatePickerTo.Location = new System.Drawing.Point(523, 393);
            this.DatePickerTo.Name = "DatePickerTo";
            this.DatePickerTo.Size = new System.Drawing.Size(315, 26);
            this.DatePickerTo.TabIndex = 1;
            // 
            // NameTextbBox
            // 
            this.NameTextbBox.Location = new System.Drawing.Point(523, 214);
            this.NameTextbBox.Name = "NameTextbBox";
            this.NameTextbBox.Size = new System.Drawing.Size(235, 26);
            this.NameTextbBox.TabIndex = 2;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(523, 246);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(235, 26);
            this.SurnameTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Prezime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Broj Gostiju";
            // 
            // GuestNumberTextBox
            // 
            this.GuestNumberTextBox.Location = new System.Drawing.Point(523, 280);
            this.GuestNumberTextBox.Name = "GuestNumberTextBox";
            this.GuestNumberTextBox.Size = new System.Drawing.Size(235, 26);
            this.GuestNumberTextBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Od";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(287, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Do";
            // 
            // DatePickerFrom
            // 
            this.DatePickerFrom.Location = new System.Drawing.Point(523, 327);
            this.DatePickerFrom.Name = "DatePickerFrom";
            this.DatePickerFrom.Size = new System.Drawing.Size(315, 26);
            this.DatePickerFrom.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(287, 458);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Parkirno Mjesto";
            // 
            // ParkingSpotTextBox
            // 
            this.ParkingSpotTextBox.Location = new System.Drawing.Point(523, 458);
            this.ParkingSpotTextBox.Name = "ParkingSpotTextBox";
            this.ParkingSpotTextBox.Size = new System.Drawing.Size(235, 26);
            this.ParkingSpotTextBox.TabIndex = 16;
            // 
            // CreateReservationButton
            // 
            this.CreateReservationButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.CreateReservationButton.IconColor = System.Drawing.Color.Black;
            this.CreateReservationButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CreateReservationButton.Location = new System.Drawing.Point(523, 547);
            this.CreateReservationButton.Name = "CreateReservationButton";
            this.CreateReservationButton.Size = new System.Drawing.Size(270, 69);
            this.CreateReservationButton.TabIndex = 17;
            this.CreateReservationButton.Text = "zavrsi";
            this.CreateReservationButton.UseVisualStyleBackColor = true;
            this.CreateReservationButton.Click += new System.EventHandler(this.CreateReservationButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 657);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "label8";
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 985);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CreateReservationButton);
            this.Controls.Add(this.ParkingSpotTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DatePickerFrom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GuestNumberTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.NameTextbBox);
            this.Controls.Add(this.DatePickerTo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1251, 985);
            this.MinimumSize = new System.Drawing.Size(1251, 985);
            this.Name = "ReservationForm";
            this.Text = "ReservationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DatePickerTo;
        private System.Windows.Forms.TextBox NameTextbBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox GuestNumberTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DatePickerFrom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ParkingSpotTextBox;
        private FontAwesome.Sharp.IconButton CreateReservationButton;
        private System.Windows.Forms.Label label8;
    }
}