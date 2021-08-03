
namespace SimpleSystem
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.GoBackButton = new FontAwesome.Sharp.IconButton();
            this.CheckCurrentReservationButton = new System.Windows.Forms.Button();
            this.NewReservationButton = new System.Windows.Forms.Button();
            this.SummaryLabel = new System.Windows.Forms.Label();
            this.ExitApplicationButton = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.GoBackButton);
            this.panel1.Controls.Add(this.CheckCurrentReservationButton);
            this.panel1.Controls.Add(this.NewReservationButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 657);
            this.panel1.TabIndex = 0;
            // 
            // GoBackButton
            // 
            this.GoBackButton.IconChar = FontAwesome.Sharp.IconChar.Backward;
            this.GoBackButton.IconColor = System.Drawing.Color.Red;
            this.GoBackButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.GoBackButton.Location = new System.Drawing.Point(12, 602);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(48, 47);
            this.GoBackButton.TabIndex = 2;
            this.GoBackButton.UseVisualStyleBackColor = true;
            // 
            // CheckCurrentReservationButton
            // 
            this.CheckCurrentReservationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckCurrentReservationButton.Location = new System.Drawing.Point(44, 190);
            this.CheckCurrentReservationButton.Name = "CheckCurrentReservationButton";
            this.CheckCurrentReservationButton.Size = new System.Drawing.Size(200, 85);
            this.CheckCurrentReservationButton.TabIndex = 1;
            this.CheckCurrentReservationButton.Text = "PREGLED REZERVACIJA";
            this.CheckCurrentReservationButton.UseVisualStyleBackColor = true;
            // 
            // NewReservationButton
            // 
            this.NewReservationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewReservationButton.Location = new System.Drawing.Point(44, 35);
            this.NewReservationButton.Name = "NewReservationButton";
            this.NewReservationButton.Size = new System.Drawing.Size(200, 85);
            this.NewReservationButton.TabIndex = 0;
            this.NewReservationButton.Text = "NOVA REZERVACIJA";
            this.NewReservationButton.UseVisualStyleBackColor = true;
            this.NewReservationButton.Click += new System.EventHandler(this.NewReservationButton_Click);
            // 
            // SummaryLabel
            // 
            this.SummaryLabel.Font = new System.Drawing.Font("PMingLiU-ExtB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummaryLabel.Location = new System.Drawing.Point(306, 9);
            this.SummaryLabel.Name = "SummaryLabel";
            this.SummaryLabel.Size = new System.Drawing.Size(322, 57);
            this.SummaryLabel.TabIndex = 1;
            this.SummaryLabel.Text = "SUMMARY";
            this.SummaryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExitApplicationButton
            // 
            this.ExitApplicationButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitApplicationButton.IconChar = FontAwesome.Sharp.IconChar.ExternalLinkAlt;
            this.ExitApplicationButton.IconColor = System.Drawing.Color.Red;
            this.ExitApplicationButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ExitApplicationButton.Location = new System.Drawing.Point(1076, 602);
            this.ExitApplicationButton.Name = "ExitApplicationButton";
            this.ExitApplicationButton.Size = new System.Drawing.Size(56, 47);
            this.ExitApplicationButton.TabIndex = 2;
            this.ExitApplicationButton.UseVisualStyleBackColor = false;
            this.ExitApplicationButton.Click += new System.EventHandler(this.ExitApplicationButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MingLiU-ExtB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(337, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 85);
            this.label1.TabIndex = 3;
            this.label1.Text = "TRENUTNO GOSTIJU U APARTMANU: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(1140, 657);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitApplicationButton);
            this.Controls.Add(this.SummaryLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1160, 700);
            this.MinimumSize = new System.Drawing.Size(1160, 700);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CheckCurrentReservationButton;
        private System.Windows.Forms.Button NewReservationButton;
        private FontAwesome.Sharp.IconButton GoBackButton;
        private System.Windows.Forms.Label SummaryLabel;
        private FontAwesome.Sharp.IconButton ExitApplicationButton;
        private System.Windows.Forms.Label label1;
    }
}

