using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostel_MS.Helpers
{
    public class SqlData
    {
       
        public  String ConString = ConfigurationManager.ConnectionStrings["ConString"].ToString();
         SqlConnection con = new SqlConnection(ConString);

        public  void OpenCon()
        { 
            con.Open();
        }
        public void CloseCon()
        {
            con.Close();
        }
        public void NonQueryExecute(String Query)
        {
            SqlCommand cmd = new SqlCommand(Query,con);
            cmd.ExecuteNonQuery();

        }
    }
   
}
