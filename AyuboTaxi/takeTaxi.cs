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
    public partial class takeTaxi : Form
    {
        public takeTaxi()
        {
            InitializeComponent();
        }

        databaseCon db = new databaseCon();
        private void pbTukTuk_Click(object sender, EventArgs e)
        {
            lblTxType.Text = "TukTuk";
            button1.Enabled = true;
            if (cmboPackType.Text== "100KM per Day")
            {
                int a = 40;
                int b = 100;
                int packvalue = 0;
                packvalue = a * b;
                lblTvalue.Text = packvalue.ToString();
                lblExKmvalue.Text = "50";
                lblmaxH.Text = "03:00";
             }
            else if(cmboPackType.Text == "200KM per Day")
            {
                int a = 35;
                int b = 200;
                int packvalue = 0;
                packvalue = a * b;
                lblTvalue.Text =  packvalue.ToString();
                lblExKmvalue.Text = "45";
                lblmaxH.Text = "6:00";
            }
            else if (cmboPackType.Text == "300KM per Day ")
            {
                int a = 30;
                int b = 300;
                int packvalue = 0;
                packvalue = a * b;
                lblTvalue.Text =  packvalue.ToString();
                lblExKmvalue.Text = "40";
                lblmaxH.Text = "9:00";
            }
            else
            {
                
            }
        }

        private void button1_DragEnter(object sender, DragEventArgs e)
        {
           
        }

        private void cmboPackType_SelectedIndexChanged(object sender, EventArgs e)
        {
            pbTukTuk.Enabled = true;
            pbSedan.Enabled = true;
            pbSUV.Enabled = true;
            pbJeep.Enabled = true;
            pbVan.Enabled = true;
            pictureBox1.Visible = true;
            lblPacktype.Text = cmboPackType.Text;

        }

        private void pnlVehHire_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbSedan_Click(object sender, EventArgs e)
        {
            lblTxType.Text = "Sedan Car";
            button1.Enabled = true;
            if (cmboPackType.Text == "100KM per Day")
            {
                int a = 50;
                int b = 100;
                int packvalue = 0;
                packvalue = a * b;
                lblTvalue.Text =  packvalue.ToString();
                lblExKmvalue.Text = "60";
                lblmaxH.Text = "3:00";
            }
            else if (cmboPackType.Text == "200KM per Day")
            {
                int a = 45;
                int b = 200;
                int packvalue = 0;
                packvalue = a * b;
                lblTvalue.Text =  packvalue.ToString();
                lblExKmvalue.Text = "55";
                lblmaxH.Text = "6:00";
            }
            else if (cmboPackType.Text == "300KM per Day ")
            {
                int a = 40;
                int b = 300;
                int packvalue = 0;
                packvalue = a * b;
                lblTvalue.Text =  packvalue.ToString();
                lblExKmvalue.Text = "50";
                lblmaxH.Text = "9:00";
            }
            else
            {

            }
        }

        private void pbSUV_Click(object sender, EventArgs e)
        {
            lblTxType.Text = "SUV";
            button1.Enabled = true;
            if (cmboPackType.Text == "100KM per Day")
            {
                int a = 60;
                int b = 100;
                int packvalue = 0;
                packvalue = a * b;
                lblTvalue.Text = packvalue.ToString();
                lblExKmvalue.Text = "70";
                lblmaxH.Text = "3:00";
            }
            else if (cmboPackType.Text == "200KM per Day")
            {
                int a = 55;
                int b = 200;
                int packvalue = 0;
                packvalue = a * b;
                lblTvalue.Text =  packvalue.ToString();
                lblExKmvalue.Text = "65";
                lblmaxH.Text = "6:00";
            }
            else if (cmboPackType.Text == "300KM per Day ")
            {
                int a = 50;
                int b = 300;
                int packvalue = 0;
                packvalue = a * b;
                lblTvalue.Text =  packvalue.ToString();
                lblExKmvalue.Text = "60";
                lblmaxH.Text = "9:00";
            }
            else
            {

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            lblTxType.Text = "MiniVan";
            button1.Enabled = true;
            if (cmboPackType.Text == "100KM per Day")
            {
                int a = 70;
                int b = 100;
                int packvalue = 0;
                packvalue = a * b;
                lblTvalue.Text =  packvalue.ToString();
                lblExKmvalue.Text = "80";
                lblmaxH.Text = "3:00";
            }
            else if (cmboPackType.Text == "200KM per Day")
            {
                int a = 65;
                int b = 200;
                int packvalue = 0;
                packvalue = a * b;
                lblTvalue.Text =  packvalue.ToString();
                lblExKmvalue.Text = "75";
                lblmaxH.Text = "6:00";
            }
            else if (cmboPackType.Text == "300KM per Day ")
            {
                int a = 60;
                int b = 300;
                int packvalue = 0;
                packvalue = a * b;
                lblTvalue.Text =  packvalue.ToString();
                lblExKmvalue.Text = "70";
                lblmaxH.Text = "9:00";
            }
            else
            {

            }
        }

        private void pbJeep_Click(object sender, EventArgs e)
        {
            lblTxType.Text = "Jeep";
            button1.Enabled = true;
            if (cmboPackType.Text == "100KM per Day")
            {
                int a = 72;
                int b = 100;
                int packvalue = 0;
                packvalue = a * b;
                lblTvalue.Text =  packvalue.ToString();
                lblExKmvalue.Text = "80";
                lblmaxH.Text = "3:00";
            }
            else if (cmboPackType.Text == "200KM per Day")
            {
                int a = 67;
                int b = 200;
                int packvalue = 0;
                packvalue = a * b;
                lblTvalue.Text =  packvalue.ToString();
                lblExKmvalue.Text = "75";
                lblmaxH.Text = "6:00";
            }
            else if (cmboPackType.Text == "300KM per Day ")
            {
                int a = 62;
                int b = 300;
                int packvalue = 0;
                packvalue = a * b;
                lblTvalue.Text =  packvalue.ToString();
                lblExKmvalue.Text = "70";
                lblmaxH.Text = "9:00";
            }
            else
            {

            }
        }

        private void pbVan_Click(object sender, EventArgs e)
        {
            lblTxType.Text = "Van";
            button1.Enabled = true;
            if (cmboPackType.Text == "100KM per Day")
            {
                int a = 90;
                int b = 100;
                int packvalue = 0;
                packvalue = a * b;
                lblTvalue.Text =  packvalue.ToString();
                lblExKmvalue.Text = "95";
                lblmaxH.Text = "3:00";
            }
            else if (cmboPackType.Text == "200KM per Day")
            {
                int a = 85;
                int b = 200;
                int packvalue = 0;
                packvalue = a * b;
                lblTvalue.Text =  packvalue.ToString();
                lblExKmvalue.Text = "90";
                lblmaxH.Text = "6:00";
            }
            else if (cmboPackType.Text == "300KM per Day ")
            {
                int a = 80;
                int b = 300;
                int packvalue = 0;
                packvalue = a * b;
                lblTvalue.Text =  packvalue.ToString();
                lblExKmvalue.Text = "85";
                lblmaxH.Text = "9:00";
            }
            else
            {

            }
        }

        private void takeTaxi_Load(object sender, EventArgs e)
        {
            lblName.Text = Login.passingtext;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //error hadling
            try
            {
                //open con
                db.sqlconn();
                //call insert method
                db.record("insert into hire values('"+lblName.Text+"','"+lblPacktype.Text+"','"+lblTxType.Text+ "','','','','','" + lblExKmvalue.Text + "','"+ lblTvalue.Text+ "','"+ lblmaxH.Text+ "','')");
                MessageBox.Show("Now Take your Vehical Using Your username....");

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

        private void lblRide_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlVehHire.Visible = true;
            panel1.Visible = false;
            panel3.Visible = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Visible = true;
            pnlVehHire.Visible = false;
            panel3.Visible = false;
        }

        private void cmboDriver_SelectedIndexChanged(object sender, EventArgs e)
        {
            rentTuk.Enabled = true;
            rentSedan.Enabled = true;
            rentSUV.Enabled = true;
            rentMiniVan.Enabled = true;
            rentJeep.Enabled = true;
            rentVAN.Enabled = true;

            if(cmboDriver.Text== "I Need Driver")
            {
                rentDriCost.Text = "2500";
            }
            else
            {
                rentDriCost.Text = "0";
            }
        }

        private void rentTuk_Click(object sender, EventArgs e)
        {
            lblTType.Text = "TukTuk";
            int oneday = 1000;
            int oneweek = 6500;
            int onemonth = 27500;

            if(cmboDriver.Text == "I Need Driver")
            {
                oneday = oneday + 2000*1;
                oneweek = oneweek + 2000*7;
                onemonth = onemonth + 2000*30;

                lblOneDay.Text = oneday.ToString();
                lblOneWeek.Text = oneweek.ToString();
                lblOneMonth.Text = onemonth.ToString();
            }
            else
            {
                lblOneDay.Text = oneday.ToString();
                lblOneWeek.Text = oneweek.ToString();
                lblOneMonth.Text = onemonth.ToString();
            }
          }

        private void rentSedan_Click(object sender, EventArgs e)
        {
            lblTType.Text = "Sedan Car";
            int oneday = 1500;
            int oneweek = 9500;
            int onemonth = 40500;

            if (cmboDriver.Text == "I Need Driver")
            {
                oneday = oneday + 2000 * 1;
                oneweek = oneweek + 2000 * 7;
                onemonth = onemonth + 2000 * 30;

                lblOneDay.Text = oneday.ToString();
                lblOneWeek.Text = oneweek.ToString();
                lblOneMonth.Text = onemonth.ToString();
            }
            else
            {
                lblOneDay.Text = oneday.ToString();
                lblOneWeek.Text = oneweek.ToString();
                lblOneMonth.Text = onemonth.ToString();
            }
        }

        private void rentSUV_Click(object sender, EventArgs e)
        {
            lblTType.Text = "SUV";
            int oneday = 1800;
            int oneweek = 11300;
            int onemonth = 51000;

            if (cmboDriver.Text == "I Need Driver")
            {
                oneday = oneday + 2000 * 1;
                oneweek = oneweek + 2000 * 7;
                onemonth = onemonth + 2000 * 30;

                lblOneDay.Text = oneday.ToString();
                lblOneWeek.Text = oneweek.ToString();
                lblOneMonth.Text = onemonth.ToString();
            }
            else
            {
                lblOneDay.Text = oneday.ToString();
                lblOneWeek.Text = oneweek.ToString();
                lblOneMonth.Text = onemonth.ToString();
            }
        }

        private void rentMiniVan_Click(object sender, EventArgs e)
        {
            lblTType.Text = "MiniVan";
            int oneday = 2200;
            int oneweek = 14000;
            int onemonth = 59900;

            if (cmboDriver.Text == "I Need Driver")
            {
                oneday = oneday + 2000 * 1;
                oneweek = oneweek + 2000 * 7;
                onemonth = onemonth + 2000 * 30;

                lblOneDay.Text = oneday.ToString();
                lblOneWeek.Text = oneweek.ToString();
                lblOneMonth.Text = onemonth.ToString();
            }
            else
            {
                lblOneDay.Text = oneday.ToString();
                lblOneWeek.Text = oneweek.ToString();
                lblOneMonth.Text = onemonth.ToString();
            }
        }

        private void rentJeep_Click(object sender, EventArgs e)
        {
            lblTType.Text = "Jeep";
            int oneday = 2800;
            int oneweek = 17000;
            int onemonth = 70900;

            if (cmboDriver.Text == "I Need Driver")
            {
                oneday = oneday + 2000 * 1;
                oneweek = oneweek + 2000 * 7;
                onemonth = onemonth + 2000 * 30;

                lblOneDay.Text = oneday.ToString();
                lblOneWeek.Text = oneweek.ToString();
                lblOneMonth.Text = onemonth.ToString();
            }
            else
            {
                lblOneDay.Text = oneday.ToString();
                lblOneWeek.Text = oneweek.ToString();
                lblOneMonth.Text = onemonth.ToString();
            }
        }

        private void rentVAN_Click(object sender, EventArgs e)
        {
            lblTType.Text = "Van";
            int oneday = 6500;
            int oneweek = 43900;
            int onemonth = 269900;

            if (cmboDriver.Text == "I Need Driver")
            {
                oneday = oneday + 2000 * 1;
                oneweek = oneweek + 2000 * 7;
                onemonth = onemonth + 2000 * 30;

                lblOneDay.Text = oneday.ToString();
                lblOneWeek.Text = oneweek.ToString();
                lblOneMonth.Text = onemonth.ToString();
            }
            else
            {
                lblOneDay.Text = oneday.ToString();
                lblOneWeek.Text = oneweek.ToString();
                lblOneMonth.Text = onemonth.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //error hadling
            try
            {
                //open con
                db.sqlconn();
                //call insert method
                db.record("insert into rent values('" + lblName.Text + "','" + cmboDriver.Text + "','" + lblTType.Text + "','','','')");
                MessageBox.Show("Now Take your Vehical Using Your username....");

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

        private void lblLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void lblPre_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void lngTtuk_Click(object sender, EventArgs e)
        {
            lngTtaxType.Text = "TukTuk";
            
            lngTHire.Enabled = true;
            if(lngTcmboPACK.Text== "1 day")
            {
                int a = 35;
                int b = 700;
                int packVal = 0;
                packVal = a * b;
                lblMAxkM.Text = b.ToString();
                lblLextraKMval.Text = "40";
                lngTPackVal.Text = packVal.ToString();
                lngTnight.Text = "0";

            }
            else if(lngTcmboPACK.Text== "2 day ")
            {
                int a = 15;
                int b = 2000;
                int packVal = 0;
                packVal = a * b;
                lblMAxkM.Text = b.ToString();
                lblLextraKMval.Text = "35";
                lngTPackVal.Text = packVal.ToString();
                lngTnight.Text = "2500";
            }
            else
            {
                int a = 10;
                int b = 4500;
                int packVal = 0;
                packVal = a * b;
                lblMAxkM.Text = b.ToString();
                lblLextraKMval.Text = "30";
                lngTPackVal.Text = packVal.ToString();
                lngTnight.Text = "4500";
            }

        }

        private void lngTcmboPACK_SelectedIndexChanged(object sender, EventArgs e)
        {
            lngTtuk.Enabled = true;
            lngTsedan.Enabled = true;
            lngTSUV.Enabled = true;
            lngTMini.Enabled = true;
            lngTjeep.Enabled = true;
            lngTVAN.Visible = true;
            lngTpackType.Text = lngTcmboPACK.Text;
        }

        private void lngTsedan_Click(object sender, EventArgs e)
        {
            lngTtaxType.Text = "Sedan";

            lngTHire.Enabled = true;
            if (lngTcmboPACK.Text == "1 day")
            {
                int a = 40;
                int b = 700;
                int packVal = 0;
                packVal = a * b;
                lblMAxkM.Text = b.ToString();
                lblLextraKMval.Text = "45";
                lngTPackVal.Text = packVal.ToString();
                lngTnight.Text = "0";

            }
            else if (lngTcmboPACK.Text == "2 day ")
            {
                int a = 20;
                int b = 2000;
                int packVal = 0;
                packVal = a * b;
                lblMAxkM.Text = b.ToString();
                lblLextraKMval.Text = "40";
                lngTPackVal.Text = packVal.ToString();
                lngTnight.Text = "2700";
            }
            else
            {
                int a = 15;
                int b = 4500;
                int packVal = 0;
                packVal = a * b;
                lblMAxkM.Text = b.ToString();
                lblLextraKMval.Text = "35";
                lngTPackVal.Text = packVal.ToString();
                lngTnight.Text = "4800";
            }
        }

        private void lngTSUV_Click(object sender, EventArgs e)
        {
            lngTtaxType.Text = "SUV";

            lngTHire.Enabled = true;
            if (lngTcmboPACK.Text == "1 day")
            {
                int a = 45;
                int b = 700;
                int packVal = 0;
                packVal = a * b;
                lblMAxkM.Text = b.ToString();
                lblLextraKMval.Text = "50";
                lngTPackVal.Text = packVal.ToString();
                lngTnight.Text = "0";

            }
            else if (lngTcmboPACK.Text == "2 day ")
            {
                int a = 25;
                int b = 2000;
                int packVal = 0;
                packVal = a * b;
                lblMAxkM.Text = b.ToString();
                lblLextraKMval.Text = "40";
                lngTPackVal.Text = packVal.ToString();
                lngTnight.Text = "2900";
            }
            else
            {
                int a = 20;
                int b = 4500;
                int packVal = 0;
                packVal = a * b;
                lblMAxkM.Text = b.ToString();
                lblLextraKMval.Text = "35";
                lngTPackVal.Text = packVal.ToString();
                lngTnight.Text = "4900";
            }
        }

        private void lngTMini_Click(object sender, EventArgs e)
        {
            lngTtaxType.Text = "MiniVan";

            lngTHire.Enabled = true;
            if (lngTcmboPACK.Text == "1 day")
            {
                int a = 50;
                int b = 700;
                int packVal = 0;
                packVal = a * b;
                lblMAxkM.Text = b.ToString();
                lblLextraKMval.Text = "55";
                lngTPackVal.Text = packVal.ToString();
                lngTnight.Text = "0";

            }
            else if (lngTcmboPACK.Text == "2 day ")
            {
                int a = 35;
                int b = 2000;
                int packVal = 0;
                packVal = a * b;
                lblMAxkM.Text = b.ToString();
                lblLextraKMval.Text = "50";
                lngTPackVal.Text = packVal.ToString();
                lngTnight.Text = "3100";
            }
            else
            {
                int a = 25;
                int b = 4500;
                int packVal = 0;
                packVal = a * b;
                lblMAxkM.Text = b.ToString();
                lblLextraKMval.Text = "30";
                lngTPackVal.Text = packVal.ToString();
                lngTnight.Text = "6000";
            }
        }

        private void lngTjeep_Click(object sender, EventArgs e)
        {
            lngTtaxType.Text = "Jeep";

            lngTHire.Enabled = true;
            if (lngTcmboPACK.Text == "1 day")
            {
                int a = 60;
                int b = 700;
                int packVal = 0;
                packVal = a * b;
                lblMAxkM.Text = b.ToString();
                lblLextraKMval.Text = "55";
                lngTPackVal.Text = packVal.ToString();
                lngTnight.Text = "0";

            }
            else if (lngTcmboPACK.Text == "2 day ")
            {
                int a = 40;
                int b = 2000;
                int packVal = 0;
                packVal = a * b;
                lblMAxkM.Text = b.ToString();
                lblLextraKMval.Text = "45";
                lngTPackVal.Text = packVal.ToString();
                lngTnight.Text = "3400";
            }
            else
            {
                int a = 35;
                int b = 4500;
                int packVal = 0;
                packVal = a * b;
                lblMAxkM.Text = b.ToString();
                lblLextraKMval.Text = "40";
                lngTPackVal.Text = packVal.ToString();
                lngTnight.Text = "6200";
            }
        }

        private void lngTVAN_Click(object sender, EventArgs e)
        {
            lngTtaxType.Text = "VAN";

            lngTHire.Enabled = true;
            if (lngTcmboPACK.Text == "1 day")
            {
                int a = 70;
                int b = 700;
                int packVal = 0;
                packVal = a * b;
                lblMAxkM.Text = b.ToString();
                lblLextraKMval.Text = "75";
                lngTPackVal.Text = packVal.ToString();
                lngTnight.Text = "0";

            }
            else if (lngTcmboPACK.Text == "2 day ")
            {
                int a = 65;
                int b = 2000;
                int packVal = 0;
                packVal = a * b;
                lblMAxkM.Text = b.ToString();
                lblLextraKMval.Text = "70";
                lngTPackVal.Text = packVal.ToString();
                lngTnight.Text = "3400";
            }
            else
            {
                int a = 55;
                int b = 4500;
                int packVal = 0;
                packVal = a * b;
                lblMAxkM.Text = b.ToString();
                lblLextraKMval.Text = "60";
                lngTPackVal.Text = packVal.ToString();
                lngTnight.Text = "6200";
            }
        }

        private void lblLongTour_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            panel3.Visible = true;
            pnlVehHire.Visible = false;
            panel1.Visible = false;
        }

        private void lngTHire_Click(object sender, EventArgs e)
        {
            //error hadling
            try
            {
                //open con
                db.sqlconn();
                //call insert method
                db.record("insert into longTourHire values('" + lblName.Text + "','" + lngTpackType.Text + "','" + lngTtaxType.Text + "','"+ lngTPackVal.Text+ "','"+ lblLextraKMval.Text+ "','"+ lblMAxkM.Text+ "','"+ lngTnight.Text+ "','','','','')");
                MessageBox.Show("Now Take your Vehical Using Your username....");

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

        private void lngTnight_Click(object sender, EventArgs e)
        {

        }
    }
}
