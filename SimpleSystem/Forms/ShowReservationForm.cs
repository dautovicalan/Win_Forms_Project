using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SimpleSystem.Forms
{
    public partial class ShowReservationForm : Form
    {
        private DataSet ds = new DataSet();   
        private SqlConnection con =
            new SqlConnection(@"Data Source=DESKTOP-O3O7OSS;Initial Catalog=SimpleAppDataBase;Integrated Security=True;");

        private SqlDataAdapter da = new SqlDataAdapter();

        public ShowReservationForm()
        {
            InitializeComponent();
        }

        public void ShowSqlData()
        {
            da.SelectCommand = new SqlCommand("SELECT * FROM Reservation", con);
            this.DataGridSql.Update();
            this.DataGridSql.Refresh();
            ds.Clear();
            da.Fill(ds);
            this.DataGridSql.DataSource = ds.Tables[0];
        }

        private void StyleDataGridSql()
        {
            this.DataGridSql.BorderStyle = BorderStyle.None;
            this.DataGridSql.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            this.DataGridSql.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridSql.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 126, 249);
            this.DataGridSql.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            this.DataGridSql.BackgroundColor = Color.FromArgb(46, 51, 73);
            this.DataGridSql.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridSql.EnableHeadersVisualStyles = false;
            this.DataGridSql.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            this.DataGridSql.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);
            this.DataGridSql.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 51, 73);
            this.DataGridSql.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.DataGridSql.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void ShowReservationForm_Load(object sender, EventArgs e)
        {
            StyleDataGridSql();
            ShowSqlData();
        }
        
        private void DataGridSql_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var showInfoForm = new DetailReservationInfoForm(DataGridSql.Rows[e.RowIndex].Cells["ReservationId"].Value.ToString(), 
                DataGridSql.Rows[e.RowIndex].Cells["Name"].Value.ToString(),
                DataGridSql.Rows[e.RowIndex].Cells["Surname"].Value.ToString(),
                DataGridSql.Rows[e.RowIndex].Cells["GuestNumber"].Value.ToString(),
                DataGridSql.Rows[e.RowIndex].Cells["DateFrom"].Value.ToString(),
                DataGridSql.Rows[e.RowIndex].Cells["DateTo"].Value.ToString(),
                DataGridSql.Rows[e.RowIndex].Cells["CountDays"].Value.ToString(),
                DataGridSql.Rows[e.RowIndex].Cells["Price"].Value.ToString(),
                DataGridSql.Rows[e.RowIndex].Cells["ParkingSpot"].Value.ToString());
            showInfoForm.Show();
        }
    }
}