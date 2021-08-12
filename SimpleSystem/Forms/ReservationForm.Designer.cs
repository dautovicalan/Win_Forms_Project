
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
            this.ClearAllButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CreateReservationButton = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DatePickerTo
            // 
            this.DatePickerTo.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.DatePickerTo.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold);
            this.DatePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePickerTo.Location = new System.Drawing.Point(523, 393);
            this.DatePickerTo.Name = "DatePickerTo";
            this.DatePickerTo.Size = new System.Drawing.Size(235, 50);
            this.DatePickerTo.TabIndex = 5;
            // 
            // NameTextbBox
            // 
            this.NameTextbBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NameTextbBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameTextbBox.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold);
            this.NameTextbBox.Location = new System.Drawing.Point(523, 186);
            this.NameTextbBox.Name = "NameTextbBox";
            this.NameTextbBox.Size = new System.Drawing.Size(235, 43);
            this.NameTextbBox.TabIndex = 1;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SurnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SurnameTextBox.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold);
            this.SurnameTextBox.Location = new System.Drawing.Point(523, 233);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(235, 43);
            this.SurnameTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(165, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 45);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label3.Location = new System.Drawing.Point(165, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 45);
            this.label3.TabIndex = 7;
            this.label3.Text = "Prezime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label4.Location = new System.Drawing.Point(165, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 45);
            this.label4.TabIndex = 8;
            this.label4.Text = "Broj Gostiju";
            // 
            // GuestNumberTextBox
            // 
            this.GuestNumberTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GuestNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GuestNumberTextBox.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold);
            this.GuestNumberTextBox.Location = new System.Drawing.Point(523, 280);
            this.GuestNumberTextBox.Name = "GuestNumberTextBox";
            this.GuestNumberTextBox.Size = new System.Drawing.Size(235, 43);
            this.GuestNumberTextBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label5.Location = new System.Drawing.Point(165, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 45);
            this.label5.TabIndex = 12;
            this.label5.Text = "Od";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label6.Location = new System.Drawing.Point(165, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 45);
            this.label6.TabIndex = 13;
            this.label6.Text = "Do";
            // 
            // DatePickerFrom
            // 
            this.DatePickerFrom.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.DatePickerFrom.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold);
            this.DatePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePickerFrom.Location = new System.Drawing.Point(523, 327);
            this.DatePickerFrom.Name = "DatePickerFrom";
            this.DatePickerFrom.Size = new System.Drawing.Size(235, 50);
            this.DatePickerFrom.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label7.Location = new System.Drawing.Point(165, 460);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(260, 45);
            this.label7.TabIndex = 15;
            this.label7.Text = "Parkirno Mjesto";
            // 
            // ParkingSpotTextBox
            // 
            this.ParkingSpotTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ParkingSpotTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ParkingSpotTextBox.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold);
            this.ParkingSpotTextBox.Location = new System.Drawing.Point(523, 458);
            this.ParkingSpotTextBox.Name = "ParkingSpotTextBox";
            this.ParkingSpotTextBox.Size = new System.Drawing.Size(235, 43);
            this.ParkingSpotTextBox.TabIndex = 6;
            // 
            // ClearAllButton
            // 
            this.ClearAllButton.FlatAppearance.BorderSize = 0;
            this.ClearAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearAllButton.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold);
            this.ClearAllButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ClearAllButton.Image = global::SimpleSystem.Properties.Resources.icons8_clear_symbol_48;
            this.ClearAllButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClearAllButton.Location = new System.Drawing.Point(406, 706);
            this.ClearAllButton.Name = "ClearAllButton";
            this.ClearAllButton.Size = new System.Drawing.Size(405, 69);
            this.ClearAllButton.TabIndex = 8;
            this.ClearAllButton.Text = "Izbrisi Sve";
            this.ClearAllButton.UseVisualStyleBackColor = true;
            this.ClearAllButton.Click += new System.EventHandler(this.ClearAllButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SimpleSystem.Properties.Resources.icons8_instagram_logo_50__1_;
            this.pictureBox1.Location = new System.Drawing.Point(1149, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // CreateReservationButton
            // 
            this.CreateReservationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.CreateReservationButton.FlatAppearance.BorderSize = 0;
            this.CreateReservationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateReservationButton.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold);
            this.CreateReservationButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.CreateReservationButton.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.CreateReservationButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.CreateReservationButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CreateReservationButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreateReservationButton.Location = new System.Drawing.Point(406, 600);
            this.CreateReservationButton.Name = "CreateReservationButton";
            this.CreateReservationButton.Size = new System.Drawing.Size(405, 69);
            this.CreateReservationButton.TabIndex = 7;
            this.CreateReservationButton.Text = "Dodaj Rezervaciju";
            this.CreateReservationButton.UseVisualStyleBackColor = false;
            this.CreateReservationButton.Click += new System.EventHandler(this.CreateReservationButton_Click);
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1251, 985);
            this.Controls.Add(this.ClearAllButton);
            this.Controls.Add(this.pictureBox1);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1251, 985);
            this.MinimumSize = new System.Drawing.Size(1251, 985);
            this.Name = "ReservationForm";
            this.Text = "ReservationForm";
            this.Load += new System.EventHandler(this.ReservationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ClearAllButton;
    }
}