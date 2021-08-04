
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
            this.MainPanel = new System.Windows.Forms.Panel();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 985);
            this.panel1.TabIndex = 0;
            // 
            // GoBackButton
            // 
            this.GoBackButton.IconChar = FontAwesome.Sharp.IconChar.Backward;
            this.GoBackButton.IconColor = System.Drawing.Color.Red;
            this.GoBackButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.GoBackButton.Location = new System.Drawing.Point(18, 926);
            this.GoBackButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(72, 72);
            this.GoBackButton.TabIndex = 2;
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // CheckCurrentReservationButton
            // 
            this.CheckCurrentReservationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckCurrentReservationButton.Location = new System.Drawing.Point(66, 292);
            this.CheckCurrentReservationButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CheckCurrentReservationButton.Name = "CheckCurrentReservationButton";
            this.CheckCurrentReservationButton.Size = new System.Drawing.Size(300, 131);
            this.CheckCurrentReservationButton.TabIndex = 1;
            this.CheckCurrentReservationButton.Text = "PREGLED REZERVACIJA";
            this.CheckCurrentReservationButton.UseVisualStyleBackColor = true;
            this.CheckCurrentReservationButton.Click += new System.EventHandler(this.CheckCurrentReservationButton_Click);
            // 
            // NewReservationButton
            // 
            this.NewReservationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewReservationButton.Location = new System.Drawing.Point(66, 54);
            this.NewReservationButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NewReservationButton.Name = "NewReservationButton";
            this.NewReservationButton.Size = new System.Drawing.Size(300, 131);
            this.NewReservationButton.TabIndex = 0;
            this.NewReservationButton.Text = "NOVA REZERVACIJA";
            this.NewReservationButton.UseVisualStyleBackColor = true;
            this.NewReservationButton.Click += new System.EventHandler(this.NewReservationButton_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(450, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1251, 985);
            this.MainPanel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(1701, 985);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximumSize = new System.Drawing.Size(1727, 1045);
            this.MinimumSize = new System.Drawing.Size(1727, 1018);
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
        private System.Windows.Forms.Panel MainPanel;
    }
}

