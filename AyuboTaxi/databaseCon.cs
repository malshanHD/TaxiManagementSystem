using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AyuboTaxi
{
    class databaseCon
    {
        //instance variable
        SqlConnection sqlCon;
        SqlCommand sqlComm;
        SqlDataAdapter sqlAdapt;
        SqlDataReader sqlRead;
        DataSet DSvehi;
        DataSet login;

        //create memory variable 
        string sql;

        public SqlConnection sqlconn()
        {
            //assigning connection
            sql = "Data Source=MALSHANH;Initial Catalog=AyuboDrive;Integrated Security=True";
            sqlCon = new SqlConnection(sql);

            //open the connection
            sqlCon.Open();
            //pass value
            return sqlCon;

        }
        //create closs con method
        public void closeCon()
        {
            //close the connection
            sqlCon.Close();
        }
        //create the write data query 
        public void record(string qry)
        {
            //assigning the values 
            sqlComm = new SqlCommand(qry, sqlCon);
            //execute the command 
            sqlComm.ExecuteNonQuery();
        }
        //search queary
        public SqlDataReader sqlReader(string qry)
        {
            //assigning the values 
            sqlComm = new SqlCommand(qry, sqlCon);
            //read the connection 
            sqlRead = sqlComm.ExecuteReader();
            //pass the value 
            return sqlRead;
        }
        //create the show records methods
        public object showGrid(string qry)
        {
            //assigning the adapter control value
            sqlAdapt = new SqlDataAdapter(qry, sqlCon);
            //fill the database control
            sqlAdapt.Fill(DSvehi = new DataSet());
            //assigning the grid view cotrol
            object dgvVehi = DSvehi.Tables[0];
            //pass the value;
            return dgvVehi;

        }

    }
}
