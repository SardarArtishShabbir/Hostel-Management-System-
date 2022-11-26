using Hostel_MS.Helpers;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hostel_MS.Forms
{
    public partial class Room : Form
    {
        SqlData sqlData = new SqlData();
        public Room()
           
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            
            String Query = "INSERT INTO tbl_Room VALUES('" + txt_number.Text + "','" + txt_floor.Text + "','" + cmb_type.Text + "','" + cmb_washroom.Text + "','" + txt_seatRent.Text + "')";
            sqlData.OpenCon();
            sqlData.NonQueryExecute(Query);
            sqlData.CloseCon();
            Mymessage.success("Room");


            
        }
    }
}
