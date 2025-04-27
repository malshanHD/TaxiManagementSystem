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
    public partial class newAdmin : Form
    {
        public newAdmin()
        {
            InitializeComponent();
        }
        databaseCon db = new databaseCon();
        private void btnCancel_Click(object sender, EventArgs e)
        {
            AdminMenu am = new AdminMenu();
            am.Show();
            this.Hide();
        }

        private void btnSetting_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminAccountSet adSet = new AdminAccountSet();
            adSet.Show();
        }

        private void btnchangepassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            adminPasswordchange apc = new adminPasswordchange();
            apc.Show();
        }

        private void btnLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void btnSetting1_Click(object sender, EventArgs e)
        {
            btnSetting1.Hide();
            pnlAdmin.Show();
            btnSetting2.Show();
            timer1.Start();
        }

        private void btnSetting2_Click(object sender, EventArgs e)
        {
            btnSetting2.Hide();
            pnlAdmin.Hide();
            btnSetting1.Show();
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pnlAdmin.Width += 40;
            if (pnlAdmin.Width >= 160)
            {

                timer1.Stop();
                pnlAdmin.Show();


            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pnlAdmin.Width -= 160;
            if (pnlAdmin.Width <= 160)
            {
                timer2.Stop();
                pnlAdmin.Hide();

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //error hadling
            try
            {
                //open con
                db.sqlconn();
                //call insert method
                db.record("insert into users values('" + txtFName.Text + "','" + txtadd.Text + "','" + txtConNo.Text + "','" + txtEmail.Text + "','" + txtUname.Text + "','" + txtPass.Text + "','Admin')");
                MessageBox.Show("Thank You for Trust US....");

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
    }
}
