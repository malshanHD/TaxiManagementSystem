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
    public partial class Login : Form
    {
        public static string passingtext;
        public Login()
        {
            InitializeComponent();
        }

        //create db con objet
        databaseCon db = new databaseCon();
        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void lblSingup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            membersReg memreg = new membersReg();
            memreg.Show();
            this.Hide();
        }

        private void lblfrgt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            resetPassword rp = new resetPassword();
            rp.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=MALSHANH;Initial Catalog=AyuboDrive;Integrated Security=True";
            con.Open();
            string uname = txtUsername.Text;
            string pass = txtpassword.Text;
            SqlCommand cmd = new SqlCommand("select uUsername,uPassword,uUserType from users where uUsername='"+uname+ "' and uPassword='"+pass+"'",con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows.Count>0)
            {
                string level = dt.Rows[0][2].ToString();
                if(level=="Admin")
                {
                    passingtext = txtUsername.Text;
                    AdminMenu am = new AdminMenu();
                    am.Show();
                    this.Hide();
                }
                else
                {
                    passingtext = txtUsername.Text;
                    takeTaxi tt = new takeTaxi();
                    tt.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Invalid Password or Username... Please check and try again");
            }
            con.Close();
        }
    }
}

