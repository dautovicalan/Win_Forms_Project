
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
            this.ExitButton = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.GoBackButton = new FontAwesome.Sharp.IconButton();
            this.CheckCurrentReservationButton = new System.Windows.Forms.Button();
            this.NewReservationButton = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Controls.Add(this.panel2);
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
            // ExitButton
            // 
            this.ExitButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ExitButton.IconColor = System.Drawing.Color.Black;
            this.ExitButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ExitButton.Location = new System.Drawing.Point(307, 896);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(107, 77);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 100);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 26F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "IME FIRME";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.CheckCurrentReservationButton.BackColor = System.Drawing.Color.MediumPurple;
            this.CheckCurrentReservationButton.FlatAppearance.BorderSize = 0;
            this.CheckCurrentReservationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckCurrentReservationButton.Font = new System.Drawing.Font("Bauhaus 93", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckCurrentReservationButton.Image = global::SimpleSystem.Properties.Resources.icons8_reservation_24;
            this.CheckCurrentReservationButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CheckCurrentReservationButton.Location = new System.Drawing.Point(0, 249);
            this.CheckCurrentReservationButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CheckCurrentReservationButton.Name = "CheckCurrentReservationButton";
            this.CheckCurrentReservationButton.Size = new System.Drawing.Size(450, 131);
            this.CheckCurrentReservationButton.TabIndex = 1;
            this.CheckCurrentReservationButton.Text = "PREGLED REZERVACIJA";
            this.CheckCurrentReservationButton.UseVisualStyleBackColor = false;
            this.CheckCurrentReservationButton.Click += new System.EventHandler(this.CheckCurrentReservationButton_Click);
            this.CheckCurrentReservationButton.MouseLeave += new System.EventHandler(this.CheckCurrentReservationButton_MouseLeave);
            this.CheckCurrentReservationButton.MouseHover += new System.EventHandler(this.CheckCurrentReservationButton_MouseHover);
            // 
            // NewReservationButton
            // 
            this.NewReservationButton.BackColor = System.Drawing.Color.MediumPurple;
            this.NewReservationButton.FlatAppearance.BorderSize = 0;
            this.NewReservationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewReservationButton.Font = new System.Drawing.Font("Bauhaus 93", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewReservationButton.Image = global::SimpleSystem.Properties.Resources.icons8_shopping_cart_24;
            this.NewReservationButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NewReservationButton.Location = new System.Drawing.Point(0, 108);
            this.NewReservationButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NewReservationButton.Name = "NewReservationButton";
            this.NewReservationButton.Size = new System.Drawing.Size(450, 131);
            this.NewReservationButton.TabIndex = 0;
            this.NewReservationButton.Text = "NOVA REZERVACIJA";
            this.NewReservationButton.UseVisualStyleBackColor = false;
            this.NewReservationButton.Click += new System.EventHandler(this.NewReservationButton_Click);
            this.NewReservationButton.MouseLeave += new System.EventHandler(this.NewReservationButton_MouseLeave);
            this.NewReservationButton.MouseHover += new System.EventHandler(this.NewReservationButton_MouseHover);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Indigo;
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(450, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1251, 985);
            this.MainPanel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(1701, 985);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximumSize = new System.Drawing.Size(1727, 1045);
            this.MinimumSize = new System.Drawing.Size(1727, 1018);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CheckCurrentReservationButton;
        private System.Windows.Forms.Button NewReservationButton;
        private FontAwesome.Sharp.IconButton GoBackButton;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton ExitButton;
    }
}

