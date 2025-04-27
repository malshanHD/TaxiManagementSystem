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
    public partial class RentCar : Form
    {
        public RentCar()
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
                System.Data.SqlClient.SqlDataReader drVehi = db.sqlReader("select jobNo,DriverStatus,taxiType from rent WHERE username='" + txtUname.Text + "'");

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
            if(lblPK.Text== "I Need Driver")
            {
                btnOk.Enabled = true;
                txtDriName.ReadOnly = false;
            }
            else
            {
                lblPK.Text = "Without Driver";
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
                db.record("UPDATE rent SET startDate='" + dateHire.Value.Date + "',vehical_no='" + txtVehiNum.Text + "',ownerName='"+ txtDriName.Text+ "' WHERE jobNo='" + lblJno.Text + "'");
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

        private void txtUname_Click(object sender, EventArgs e)
        {
            txtUname.Text = "";
        }

        private void btView_Click(object sender, EventArgs e)
        {
            //using error handler tool
            try
            {
                //call the open conncetion
                db.sqlconn();
                //assigning the search record
                System.Data.SqlClient.SqlDataReader drVehi = db.sqlReader("select * from rent WHERE jobNo='" + txtJno.Text + "'");

                //using error hadler
                try
                {
                    //read the command 
                    drVehi.Read();
                    //assigning the values
                    lblEJNo.Text = drVehi[0].ToString();
                    lblEPK.Text = drVehi[2].ToString();
                    lblEVtyoe.Text = drVehi[3].ToString();
                    eDate.Text = drVehi[4].ToString();
                    lblEVno.Text = drVehi[5].ToString();
                    lblOname.Text = drVehi[6].ToString();


                    if (lblEPK.Text== "I Need Driver")
                    {
                        lblEEvalue.Text = "2000";
                    }
                    else
                    {
                        lblEEvalue.Text = "0";
                    }

                    DateTime StartDate = Convert.ToDateTime(eDate.Text);
                    DateTime EndDate = Convert.ToDateTime(eedate.Text);
                    int year = StartDate.Year;
                    int month = StartDate.Month;
                    int days = StartDate.Day;
                    int weeks;
                    int remainingDays;

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
                    int d = 0;
                    int w = 0;
                    int drivC = 0;

                    year = Math.DivRem(days, 365, out d);
                    month = Math.DivRem(d, 30, out d);
                    days = d;
                    remainingDays = d % 7;
                    weeks = days / 7;
                    drivC = days * 2000;

                    //assigning the value to the labels
                    lblMonth.Text = month.ToString();
                    lblweek.Text = weeks.ToString();
                    lblDays.Text = remainingDays.ToString();
                    lblEEvalue.Text = drivC.ToString();


                    //find total amount 
                    int mo;
                    int we;
                    int da;
                    int total;
                    int monthValue = Convert.ToInt32(lblMonth.Text);
                    int weekValue = Convert.ToInt32(lblweek.Text);
                    int daysValue = Convert.ToInt32(lblDays.Text);
                    int driverValue = Convert.ToInt32(lblEEvalue.Text);

                    if(lblEVtyoe.Text == "TukTuk")
                    {
                        mo = monthValue * 27500;
                        we = weekValue * 6500;
                        da = daysValue * 1000;

                        total = mo + we + da+ driverValue;

                        lblTvalue.Text = total.ToString();

                    }
                    else if(lblEVtyoe.Text== "Sedan Car")
                    {
                        mo = monthValue * 40500;
                        we = weekValue * 9500;
                        da = daysValue * 1500;

                        total = mo + we + da + driverValue;

                        lblTvalue.Text = total.ToString();

                    }
                    else if (lblEVtyoe.Text == "SUV")
                    {
                        mo = monthValue * 51000;
                        we = weekValue * 11300;
                        da = daysValue * 1800;

                        total = mo + we + da + driverValue;

                        lblTvalue.Text = total.ToString();
                    }
                    else if (lblEVtyoe.Text == "MiniVan")
                    {
                        mo = monthValue * 59900;
                        we = weekValue * 14200;
                        da = daysValue * 2200;

                        total = mo + we + da + driverValue;

                        lblTvalue.Text = total.ToString();
                    }
                    else if (lblEVtyoe.Text == "Jeep")
                    {
                        mo = monthValue * 70900;
                        we = weekValue * 17000;
                        da = daysValue * 2800;

                        total = mo + we + da + driverValue;

                        lblTvalue.Text = total.ToString();
                    }
                    else 
                    {
                        mo = monthValue * 269900;
                        we = weekValue * 43900;
                        da = daysValue * 6500;

                        total = mo + we + da + driverValue;

                        lblTvalue.Text = total.ToString();
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
           

        }

        private void lblStart_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlStart.Visible = true;
            panel1.Visible = false;
        }

        private void lblEnd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Visible = true;
            pnlStart.Visible = false;
        }

        private void txtJno_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtJno_Click(object sender, EventArgs e)
        {
            txtJno.Text = "";
        }

        private void lblLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void lblPre_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminMenu am = new AdminMenu();
            am.Show();
            this.Hide();
        }

        private void btnEndRide_Click(object sender, EventArgs e)
        {
            //error hadling
            try
            {
                //open con
                db.sqlconn();
                //call insert method
                db.record("insert into available_vehi values('" + lblEVno.Text + "','" + lblEVtyoe.Text + "','" + lblOname.Text + "')");
                db.record("insert into rented values('" + txtJno.Text + "','" + lblEJNo.Text + "','" + lblEVno.Text + "','" + eDate.Value.Date + "','" + eedate.Value.Date + "','" + lblEPK.Text + "','"+ lblTvalue.Text+ "')");
                db.record("DELETE FROM rent WHERE username='" + lblEJNo.Text + "'");

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
    }
}
