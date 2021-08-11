
namespace SimpleSystem.Forms
{
    partial class ShowReservationForm
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
            this.DataGridSql = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSql)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridSql
            // 
            this.DataGridSql.AllowUserToAddRows = false;
            this.DataGridSql.AllowUserToDeleteRows = false;
            this.DataGridSql.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridSql.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridSql.Location = new System.Drawing.Point(0, 0);
            this.DataGridSql.Name = "DataGridSql";
            this.DataGridSql.ReadOnly = true;
            this.DataGridSql.RowHeadersWidth = 62;
            this.DataGridSql.RowTemplate.Height = 28;
            this.DataGridSql.Size = new System.Drawing.Size(1251, 985);
            this.DataGridSql.TabIndex = 0;
            this.DataGridSql.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridSql_CellContentDoubleClick);
            // 
            // ShowReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1251, 985);
            this.Controls.Add(this.DataGridSql);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1251, 985);
            this.MinimumSize = new System.Drawing.Size(1251, 985);
            this.Name = "ShowReservationForm";
            this.Text = "ShowReservationForm";
            this.Load += new System.EventHandler(this.ShowReservationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSql)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridSql;
    }
}