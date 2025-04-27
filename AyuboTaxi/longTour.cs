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
    public partial class longTour : Form
    {
        public longTour()
        {
            InitializeComponent();
        }
        databaseCon db = new databaseCon();
        private void btnView_Click(object sender, EventArgs e)
        {
            //using error handler tool
            try
            {
                //call the open conncetion
                db.sqlconn();
                //assigning the search record
                System.Data.SqlClient.SqlDataReader drVehi = db.sqlReader("select job_no,package_type,vehicleType from longTourHire WHERE username='" + txtUname.Text + "'");

                //using error hadler
                try
                {
                    //read the command 
                    drVehi.Read();
                    //assigning the values
                    lblJno.Text = drVehi[0].ToString();
                    lblPK.Text = drVehi[1].ToString();
                    lblVehiType.Text = drVehi[2].ToString();


                }
                catch (Exception ex)
                {
                    //catch the error 
                    MessageBox.Show("Record not found!! ", "Ayubo Drive", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                //catch the error 
                //catch the error 
                MessageBox.Show("error : " + ex.Message, "Ayubo Drive", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //close the connection
                db.closeCon();
            }
        }

        private void btnVehi_Click(object sender, EventArgs e)
        {
            //using error handler tool
            try
            {
                //call the open connection method
                db.sqlconn();
                //call the show grid method
                dataGridView1.DataSource = db.showGrid("select * from available_vehi where vehicalType='" + lblVehiType.Text + "'");
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

        private void btnOk_Click(object sender, EventArgs e)
        {
            //using error handler tool
            try
            {
                //call the open conncetion
                db.sqlconn();
                //assigning the search record
                System.Data.SqlClient.SqlDataReader drVehi = db.sqlReader("select DriverName from available_vehi WHERE vehicalNo='" + txtVehiNum.Text + "'");

                //using error hadler
                try
                {
                    //read the command 
                    drVehi.Read();
                    //assigning the values
                    txtDriName.Text = drVehi[0].ToString();


                }
                catch (Exception ex)
                {
                    //catch the error 
                    MessageBox.Show("Record not found!! ", "Ayubo Drive", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                //catch the error 
                //catch the error 
                MessageBox.Show("error : " + ex.Message, "Ayubo Drive", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //close the connection
                db.closeCon();
            }
        }

        private void btnStartRide_Click(object sender, EventArgs e)
        {
            //error hadling
            try
            {
                //open con
                db.sqlconn();
                //call insert method
                db.record("UPDATE longTourHire SET hiredDate='" + dateHire.Value.Date + "',startKM='" + txtStartKM.Text + "',driverName='" + txtDriName.Text + "',vehicleNo='" + txtVehiNum.Text + "' WHERE job_no='" + lblJno.Text + "'");
                db.record("DELETE FROM available_vehi WHERE vehicalNo='" + txtVehiNum.Text + "'");
                MessageBox.Show("Yeh..!....");

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

        private void txtJno_Click(object sender, EventArgs e)
        {
            txtJno.Text = "";
        }

        private void btView_Click(object sender, EventArgs e)
        {
            //using error handler tool
            try
            {
                //call the open conncetion
                db.sqlconn();
                //assigning the search record
                System.Data.SqlClient.SqlDataReader drVehi = db.sqlReader("select * from longTourHire WHERE job_no='" + txtJno.Text + "'");

                //using error hadler
                try
                {
                    //read the command 
                    drVehi.Read();
                    //assigning the values
                    lblEJNo.Text = drVehi[0].ToString();
                    lblEPK.Text = drVehi[2].ToString();
                    lblEVtyoe.Text = drVehi[3].ToString();
                    lblpackvalue.Text = drVehi[4].ToString();
                    lblEEvalue.Text = drVehi[5].ToString();
                    lblMxKM.Text = drVehi[6].ToString();
                    lblovr.Text = drVehi[7].ToString();
                    eDate.Text = drVehi[8].ToString();
                    lblEStartKM.Text = drVehi[9].ToString();
                    lblEDname.Text = drVehi[10].ToString();
                    lblEVno.Text = drVehi[11].ToString();


                    DateTime StartDate = Convert.ToDateTime(eDate.Text);
                    DateTime EndDate = Convert.ToDateTime(eedate.Text);
                    int days = StartDate.Day;
                    int year = StartDate.Year;
                    int month = StartDate.Month;

                    int leap_year = 0;
                    for (int i = year; i < StartDate.Year; i++)
                    {
                        if (DateTime.IsLeapYear(i))
                        {
                            ++leap_year;
                        }
                    }

                    TimeSpan timespan = EndDate.Subtract(StartDate);
                    days = timespan.Days - leap_year;
                   // lblRHours.Text = timespan.ToString();

                    int d = 0;
                    year = Math.DivRem(days, 365, out d);
                    month = Math.DivRem(d, 30, out d);
                    days = d;
                    lblRHours.Text = d.ToString();

                    if(lblEPK.Text== "1 day")
                    {
                        packDays.Text = "1";
                    }
                    else if(lblEPK.Text== "2 day ")
                    {
                        packDays.Text = "2";
                    }
                    else
                    {
                        packDays.Text = "3";
                    }

                }
                catch (Exception ex)
                {
                    //catch the error 
                    MessageBox.Show("Record not found!! ", "Ayubo Drive", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                //catch the error 
                //catch the error 
                MessageBox.Show("error : " + ex.Message, "Ayubo Drive", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //close the connection
                db.closeCon();
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //total KM calculate 
            int endKm = Convert.ToInt32(txtEndKM.Text);
            int startKM = Convert.ToInt32(lblEStartKM.Text);
            int totalKM;
            int maxKM = Convert.ToInt32(lblMxKM.Text);
            int rideDays = Convert.ToInt32(lblRHours.Text);
            

            totalKM = endKm - startKM;

            if(maxKM>totalKM)
            {
                int packDay = Convert.ToInt32(packDays.Text);
                int extradays;
                int extraDaTotal;
                int totalVal;
                int packVal = Convert.ToInt32(lblpackvalue.Text);
                int overNight = Convert.ToInt32(lblovr.Text);
                
                int overnightVal;
                


                if (packDay>rideDays)
                {
                    totalVal = packVal + overNight;
                    lblTvalue.Text = totalVal.ToString();
                    lblWhours.Text = overNight.ToString();
                }
                else
                {
                    extradays = rideDays - packDay;
                    extraDaTotal = extradays * 3000;
                    totalVal = extraDaTotal + packVal;
                    overnightVal = extraDaTotal + overNight;
                    lblWhours.Text = overNight.ToString();

                    lblTvalue.Text = totalVal.ToString();
                }

            }
            else
            {
                int packDay = Convert.ToInt32(packDays.Text);
                int extradays;
                int extraDaTotal;
                int totalVal;
                int packVal = Convert.ToInt32(lblpackvalue.Text);
                int extraKM;
                int extraKMVal;
                int extra1Km = Convert.ToInt32(lblEEvalue.Text);
                int overNight = Convert.ToInt32(lblovr.Text);
                int overnightVal;
                extraKM = totalKM - maxKM;
                extraKMVal = extraKM * extra1Km;

                lbleeKMValue.Text = extraKM.ToString();
                lblExKMvalue.Text = extraKMVal.ToString();

                if (packDay > rideDays)
                {
                    totalVal = packVal + extraKMVal+overNight;
                    lblTvalue.Text = totalVal.ToString();

                }
                else
                {
                    extradays = rideDays - packDay;
                    extraDaTotal = extradays * 3000;
                    overnightVal = extraDaTotal + overNight;

                    totalVal = overnightVal + packVal+ extraKMVal;
                    lblWhours.Text = overNight.ToString();

                    lblTvalue.Text = totalVal.ToString();
                }


            }

            

        }

        private void lblRHours_Click(object sender, EventArgs e)
        {

        }

        private void btnEndRide_Click(object sender, EventArgs e)
        {
            //error hadling
            try
            {
                //open con
                db.sqlconn();
                //call insert method
                db.record("insert into available_vehi values('" + lblEVno.Text + "','" + lblEVtyoe.Text + "','" + lblEDname.Text + "')");
                db.record("insert into EndLongTourHire values('" + txtJno.Text + "','" + lblEJNo.Text + "','" + lblEVno.Text + "','" + lblEPK.Text + "','" + lblRHours.Text + "','" + eDate.Value.Date + "','" + eedate.Value.Date + "','" + lblTvalue.Text + "')");
                db.record("DELETE FROM longTourHire WHERE username='" + lblEJNo.Text + "'");

                MessageBox.Show("Thank you....");

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

        private void lblStart_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void lblEnd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
        }

        private void lblPre_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminMenu am = new AdminMenu();
            am.Show();
            this.Hide();
        }

        private void lblLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }
    }
}
