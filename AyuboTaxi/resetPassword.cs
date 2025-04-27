using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AyuboTaxi
{
    public partial class resetPassword : Form
    {
        public resetPassword()
        {
            InitializeComponent();
        }

        databaseCon db = new databaseCon();
        private void btnHome_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=MalshanH;Initial Catalog=AyuboDrive;Integrated Security=True";
            con.Open();
            string uname = txtUname.Text;
            string email = txtEmail.Text;
            string newpass = txtNewPass.Text;
            string confirm = txtCpass.Text;
            SqlCommand cmd = new SqlCommand("select uUsername,uEmail from users where uUsername='" + uname + "' and uEmail='" + email + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                if(newpass==confirm)
                {
                    //error hadling
                    try
                    {
                        //open con
                        db.sqlconn();
                        //call insert method
                        db.record("update users set uPassword='"+newpass+ "' where uUsername='"+uname+"'");
                        MessageBox.Show("Password Changed....");

                    }
                    catch (Exception ex)
                    {
                        //catch the error 
                        MessageBox.Show("error : " + ex.Message, "Ayubo Drive", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        //close the connection
                        db.closeCon();
                    }

                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show("Invalid Password or Username... Please check and try again");
            }
            con.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }
    }
}
