
namespace SimpleSystem.Forms
{
    partial class DetailReservationInfoForm
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
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.EditButton = new FontAwesome.Sharp.IconButton();
            this.GuestNumberTextBox = new System.Windows.Forms.TextBox();
            this.DateFromTextBox = new System.Windows.Forms.TextBox();
            this.DateToTextBox = new System.Windows.Forms.TextBox();
            this.DayCountTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.ParkingSpotTextBox = new System.Windows.Forms.TextBox();
            this.FinishAndSaveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(109, 105);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.ReadOnly = true;
            this.NameTextBox.Size = new System.Drawing.Size(216, 26);
            this.NameTextBox.TabIndex = 1;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(109, 146);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.ReadOnly = true;
            this.SurnameTextBox.Size = new System.Drawing.Size(216, 26);
            this.SurnameTextBox.TabIndex = 2;
            // 
            // EditButton
            // 
            this.EditButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.EditButton.IconColor = System.Drawing.Color.Black;
            this.EditButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EditButton.Location = new System.Drawing.Point(599, 362);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(132, 48);
            this.EditButton.TabIndex = 3;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // GuestNumberTextBox
            // 
            this.GuestNumberTextBox.Location = new System.Drawing.Point(109, 194);
            this.GuestNumberTextBox.Name = "GuestNumberTextBox";
            this.GuestNumberTextBox.ReadOnly = true;
            this.GuestNumberTextBox.Size = new System.Drawing.Size(216, 26);
            this.GuestNumberTextBox.TabIndex = 4;
            // 
            // DateFromTextBox
            // 
            this.DateFromTextBox.Location = new System.Drawing.Point(109, 241);
            this.DateFromTextBox.Name = "DateFromTextBox";
            this.DateFromTextBox.ReadOnly = true;
            this.DateFromTextBox.Size = new System.Drawing.Size(216, 26);
            this.DateFromTextBox.TabIndex = 5;
            // 
            // DateToTextBox
            // 
            this.DateToTextBox.Location = new System.Drawing.Point(109, 289);
            this.DateToTextBox.Name = "DateToTextBox";
            this.DateToTextBox.ReadOnly = true;
            this.DateToTextBox.Size = new System.Drawing.Size(216, 26);
            this.DateToTextBox.TabIndex = 6;
            // 
            // DayCountTextBox
            // 
            this.DayCountTextBox.Location = new System.Drawing.Point(109, 336);
            this.DayCountTextBox.Name = "DayCountTextBox";
            this.DayCountTextBox.ReadOnly = true;
            this.DayCountTextBox.Size = new System.Drawing.Size(216, 26);
            this.DayCountTextBox.TabIndex = 7;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(109, 384);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.ReadOnly = true;
            this.PriceTextBox.Size = new System.Drawing.Size(216, 26);
            this.PriceTextBox.TabIndex = 8;
            // 
            // ParkingSpotTextBox
            // 
            this.ParkingSpotTextBox.Location = new System.Drawing.Point(109, 433);
            this.ParkingSpotTextBox.Name = "ParkingSpotTextBox";
            this.ParkingSpotTextBox.ReadOnly = true;
            this.ParkingSpotTextBox.Size = new System.Drawing.Size(216, 26);
            this.ParkingSpotTextBox.TabIndex = 9;
            // 
            // FinishAndSaveButton
            // 
            this.FinishAndSaveButton.Location = new System.Drawing.Point(443, 362);
            this.FinishAndSaveButton.Name = "FinishAndSaveButton";
            this.FinishAndSaveButton.Size = new System.Drawing.Size(135, 48);
            this.FinishAndSaveButton.TabIndex = 10;
            this.FinishAndSaveButton.Text = "FINISH AND SAVE";
            this.FinishAndSaveButton.UseVisualStyleBackColor = true;
            this.FinishAndSaveButton.Click += new System.EventHandler(this.FinishAndSaveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(595, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(752, 359);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(144, 55);
            this.ExitButton.TabIndex = 12;
            this.ExitButton.Text = "EXIT";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DetailReservationInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 524);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FinishAndSaveButton);
            this.Controls.Add(this.ParkingSpotTextBox);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.DayCountTextBox);
            this.Controls.Add(this.DateToTextBox);
            this.Controls.Add(this.DateFromTextBox);
            this.Controls.Add(this.GuestNumberTextBox);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.NameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetailReservationInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetailReservationInfoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private FontAwesome.Sharp.IconButton EditButton;
        private System.Windows.Forms.TextBox GuestNumberTextBox;
        private System.Windows.Forms.TextBox DateFromTextBox;
        private System.Windows.Forms.TextBox DateToTextBox;
        private System.Windows.Forms.TextBox DayCountTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.TextBox ParkingSpotTextBox;
        private System.Windows.Forms.Button FinishAndSaveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExitButton;
    }
}