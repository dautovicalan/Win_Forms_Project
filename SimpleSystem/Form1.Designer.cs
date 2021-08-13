
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.ExitButton = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.GoBackButton = new FontAwesome.Sharp.IconButton();
            this.CheckCurrentReservationButton = new System.Windows.Forms.Button();
            this.NewReservationButton = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.CursorPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.CursorPanel);
            this.panel1.Controls.Add(this.SettingsButton);
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.GoBackButton);
            this.panel1.Controls.Add(this.CheckCurrentReservationButton);
            this.panel1.Controls.Add(this.NewReservationButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 1018);
            this.panel1.TabIndex = 0;
            // 
            // SettingsButton
            // 
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold);
            this.SettingsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.SettingsButton.Image = global::SimpleSystem.Properties.Resources.icons8_settings_48;
            this.SettingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsButton.Location = new System.Drawing.Point(0, 798);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(449, 131);
            this.SettingsButton.TabIndex = 4;
            this.SettingsButton.Text = "POSTAVKE";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            this.SettingsButton.Leave += new System.EventHandler(this.SettingsButton_Leave);
            // 
            // ExitButton
            // 
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.IconChar = FontAwesome.Sharp.IconChar.Map;
            this.ExitButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ExitButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ExitButton.Location = new System.Drawing.Point(359, 935);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(85, 80);
            this.ExitButton.TabIndex = 3;
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
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Image = global::SimpleSystem.Properties.Resources.icons8_instagram_logo_48;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.GoBackButton.FlatAppearance.BorderSize = 0;
            this.GoBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoBackButton.IconChar = FontAwesome.Sharp.IconChar.Backward;
            this.GoBackButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.GoBackButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.GoBackButton.Location = new System.Drawing.Point(4, 935);
            this.GoBackButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(85, 80);
            this.GoBackButton.TabIndex = 2;
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // CheckCurrentReservationButton
            // 
            this.CheckCurrentReservationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.CheckCurrentReservationButton.FlatAppearance.BorderSize = 0;
            this.CheckCurrentReservationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckCurrentReservationButton.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckCurrentReservationButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.CheckCurrentReservationButton.Image = global::SimpleSystem.Properties.Resources.icons8_reservation_48;
            this.CheckCurrentReservationButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CheckCurrentReservationButton.Location = new System.Drawing.Point(0, 249);
            this.CheckCurrentReservationButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CheckCurrentReservationButton.Name = "CheckCurrentReservationButton";
            this.CheckCurrentReservationButton.Size = new System.Drawing.Size(450, 131);
            this.CheckCurrentReservationButton.TabIndex = 1;
            this.CheckCurrentReservationButton.Text = "PREGLED REZERVACIJA";
            this.CheckCurrentReservationButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CheckCurrentReservationButton.UseVisualStyleBackColor = false;
            this.CheckCurrentReservationButton.Click += new System.EventHandler(this.CheckCurrentReservationButton_Click);
            this.CheckCurrentReservationButton.Leave += new System.EventHandler(this.CheckCurrentReservationButton_Leave);
            // 
            // NewReservationButton
            // 
            this.NewReservationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.NewReservationButton.FlatAppearance.BorderSize = 0;
            this.NewReservationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewReservationButton.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewReservationButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.NewReservationButton.Image = global::SimpleSystem.Properties.Resources.icons8_shopping_cart_48;
            this.NewReservationButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NewReservationButton.Location = new System.Drawing.Point(0, 108);
            this.NewReservationButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NewReservationButton.Name = "NewReservationButton";
            this.NewReservationButton.Size = new System.Drawing.Size(450, 131);
            this.NewReservationButton.TabIndex = 0;
            this.NewReservationButton.Text = "NOVA REZERVACIJA";
            this.NewReservationButton.UseVisualStyleBackColor = false;
            this.NewReservationButton.Click += new System.EventHandler(this.NewReservationButton_Click);
            this.NewReservationButton.Leave += new System.EventHandler(this.NewReservationButton_Leave);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(450, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1277, 1018);
            this.MainPanel.TabIndex = 1;
            // 
            // CursorPanel
            // 
            this.CursorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.CursorPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.CursorPanel.Location = new System.Drawing.Point(0, 193);
            this.CursorPanel.Name = "CursorPanel";
            this.CursorPanel.Size = new System.Drawing.Size(3, 100);
            this.CursorPanel.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(1727, 1018);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Panel CursorPanel;
    }
}

