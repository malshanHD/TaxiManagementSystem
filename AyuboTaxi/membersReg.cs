using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyuboTaxi
{
    public partial class membersReg : Form
    {
        public membersReg()
        {
            InitializeComponent();
        }

        databaseCon db = new databaseCon();
        private void membersReg_Load(object sender, EventArgs e)
        {
           
        }

        private void txtFName_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            //error hadling
            try
            {
                //open con
                db.sqlconn();
                //call insert method
                db.record("insert into users values('"+txtFName.Text+"','"+txtAdddress.Text+"','"+txtConNo.Text+"','"+txtEmail.Text+"','"+txtUname.Text+"','"+txtPass.Text+"','user')");
                MessageBox.Show("Thank You for Trust US....");

            }
            catch(Exception ex)
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }
    }
}
