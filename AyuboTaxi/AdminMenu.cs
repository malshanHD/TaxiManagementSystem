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
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
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

        private void btnLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login l = new Login();
            l.Show();
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

        private void btnNewAdmin_Click(object sender, EventArgs e)
        {
            newAdmin na = new newAdmin();
            na.Show();
            this.Hide();
        }

        private void btnNewVehi_Click(object sender, EventArgs e)
        {
            VehicleReg vg = new VehicleReg();
            vg.Show();
            this.Hide();
        }

        private void btnHire_Click(object sender, EventArgs e)
        {
            Drive tt = new Drive();
            tt.Show();
            this.Hide();
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            RentCar rc = new RentCar();
            rc.Show();
            this.Hide();
        }

        private void btnLT_Click(object sender, EventArgs e)
        {
            longTour lt = new longTour();
            lt.Show();
            this.Hide();
        }
    }
}
