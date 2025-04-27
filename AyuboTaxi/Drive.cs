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
    public partial class Drive : Form
    {
        public Drive()
        {
            InitializeComponent();
        }
        databaseCon db = new databaseCon();
        private void txtUname_Click(object sender, EventArgs e)
        {
            txtUname.Text = "";
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            //using error handler tool
            try
            {
                //call the open conncetion
                db.sqlconn();
                //assigning the search record
                System.Data.SqlClient.SqlDataReader drVehi = db.sqlReader("select job_no,package_type,vehical_type from hire WHERE username='" + txtUname.Text + "'");

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
                dataGridView1.DataSource = db.showGrid("select * from available_vehi where vehicalType='"+lblVehiType.Text+"'");
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
                db.record("UPDATE hire SET hired_date='"+dateHire.Value.Date+"',start_KM='"+txtStartKM.Text+"',driver_name='"+txtDriName.Text+"',vehical_no='"+txtVehiNum.Text+"',startTime='"+ lblTime.Text + "' WHERE job_no='"+lblJno.Text+"'");
                db.record("DELETE FROM available_vehi WHERE vehicalNo='"+txtVehiNum.Text+"'");
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

        private void btView_Click(object sender, EventArgs e)
        {
            //using error handler tool
            try
            {
                //call the open conncetion
                db.sqlconn();
                //assigning the search record
                System.Data.SqlClient.SqlDataReader drVehi = db.sqlReader("select * from hire WHERE job_no='" + txtJno.Text + "'");

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
                    lblEStartKM.Text = drVehi[5].ToString();
                    lblEDname.Text = drVehi[6].ToString();
                    lblEVno.Text = drVehi[7].ToString();
                    lblEEvalue.Text = drVehi[8].ToString();
                    lblpackvalue.Text= drVehi[9].ToString();
                    lblMxHours.Text = drVehi[10].ToString();
                    RStTime.Text = drVehi[11].ToString();

                    
                    lblRHours.Text = (Convert.ToDateTime(lblendTime.Text) - Convert.ToDateTime(RStTime.Text)).ToString();
                   

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

        private void txtJno_Click(object sender, EventArgs e)
        {
            txtJno.Text = "";
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //variable 
            int startKM = Convert.ToInt32(lblEStartKM.Text);
            int endKM = Convert.ToInt32(txtEndKM.Text);
            int extraKM = Convert.ToInt32(lbleeKMValue.Text);
            int extraKMValuePerKM = Convert.ToInt32(lblEEvalue.Text);
            int extraKMtotal = Convert.ToInt32(lblExKMvalue.Text);
            int totalValue = Convert.ToInt32(lblTvalue.Text);
            int packvalue = Convert.ToInt32(lblpackvalue.Text);
            

            int totalKM;
            //check veihical type
            if (lblEVtyoe.Text == "TukTuk")
            {
                //find KM
                totalKM = endKM - startKM;
                //define package 
                if (lblEPK.Text == "100KM per Day")
                {
                    //calculate 
                    if (totalKM > 100)
                    {
                        extraKM = totalKM - 100;
                        extraKMtotal = extraKMValuePerKM * extraKM;
                        totalValue = packvalue + extraKMtotal;

                        lbleeKMValue.Text = extraKM.ToString();
                        lblExKMvalue.Text = extraKMtotal.ToString();
                        lblTvalue.Text = totalValue.ToString();

                        int waitingH = DateTime.Compare(DateTime.Parse(lblMxHours.Text), DateTime.Parse(lblRHours.Text)); 
                        lblWhours.Text = waitingH.ToString();
                        if(waitingH>0)
                        {
                            lblWhours.Text = "0";
                            
                        }
                        else
                        {
                            waitingH = waitingH * -400;
                            lblWhours.Text = waitingH.ToString();
                            totalValue = totalValue + waitingH;
                            lblTvalue.Text = totalValue.ToString();
                        }

                    }
                    else
                    {
                        lblTvalue.Text = lblpackvalue.Text;
                    }
                }
                else if (lblEPK.Text == "200KM per Day")
                {
                    if (totalKM > 200)
                    {
                        extraKM = totalKM - 200;
                        extraKMtotal = extraKMValuePerKM * extraKM;
                        totalValue = packvalue + extraKMtotal;

                        lbleeKMValue.Text = extraKM.ToString();
                        lblExKMvalue.Text = extraKMtotal.ToString();
                        lblTvalue.Text = totalValue.ToString();

                        int waitingH = DateTime.Compare(DateTime.Parse(lblMxHours.Text), DateTime.Parse(lblRHours.Text));
                        lblWhours.Text = waitingH.ToString();
                        if (waitingH > 0)
                        {
                            lblWhours.Text = "0";
                        }
                        else
                        {
                            waitingH = waitingH * -400;
                            lblWhours.Text = waitingH.ToString();
                        }

                    }
                    else
                    {
                        lblTvalue.Text = lblpackvalue.Text;
                    }
                }
                else if (lblEPK.Text == "300KM per Day ")
                {
                    if (totalKM > 300)
                    {
                        extraKM = totalKM - 300;
                        extraKMtotal = extraKMValuePerKM * extraKM;
                        totalValue = packvalue + extraKMtotal;

                        lbleeKMValue.Text = extraKM.ToString();
                        lblExKMvalue.Text = extraKMtotal.ToString();
                        lblTvalue.Text = totalValue.ToString();

                        int waitingH = DateTime.Compare(DateTime.Parse(lblMxHours.Text), DateTime.Parse(lblRHours.Text));
                        lblWhours.Text = waitingH.ToString();
                        if (waitingH > 0)
                        {
                            lblWhours.Text = "0";
                        }
                        else
                        {
                            waitingH = waitingH * -400;
                            lblWhours.Text = waitingH.ToString();
                        }

                    }
                    else
                    {
                        lblTvalue.Text = lblpackvalue.Text;
                    }
                }
            }
            
            else if (lblEVtyoe.Text == "Sedan Car")
            {
                totalKM = endKM - startKM;
                if (lblEPK.Text == "100KM per Day")
                {
                    if (totalKM > 100)
                    {
                        extraKM = totalKM - 100;
                        extraKMtotal = extraKMValuePerKM * extraKM;
                        totalValue = packvalue + extraKMtotal;

                        lbleeKMValue.Text = extraKM.ToString();
                        lblExKMvalue.Text = extraKMtotal.ToString();
                        lblTvalue.Text = totalValue.ToString();

                        int waitingH = DateTime.Compare(DateTime.Parse(lblMxHours.Text), DateTime.Parse(lblRHours.Text));
                        lblWhours.Text = waitingH.ToString();
                        if (waitingH > 0)
                        {
                            lblWhours.Text = "0";
                        }
                        else
                        {
                            waitingH = waitingH * -400;
                            lblWhours.Text = waitingH.ToString();
                        }

                    }
                    else
                    {
                        lblTvalue.Text = lblpackvalue.Text;
                    }
                }
                else if (lblEPK.Text == "200KM per Day")
                {
                    if (totalKM > 200)
                    {
                        extraKM = totalKM - 200;
                        extraKMtotal = extraKMValuePerKM * extraKM;
                        totalValue = packvalue + extraKMtotal;

                        lbleeKMValue.Text = extraKM.ToString();
                        lblExKMvalue.Text = extraKMtotal.ToString();
                        lblTvalue.Text = totalValue.ToString();

                        int waitingH = DateTime.Compare(DateTime.Parse(lblMxHours.Text), DateTime.Parse(lblRHours.Text));
                        lblWhours.Text = waitingH.ToString();
                        if (waitingH > 0)
                        {
                            lblWhours.Text = "0";
                        }
                        else
                        {
                            waitingH = waitingH * -400;
                            lblWhours.Text = waitingH.ToString();
                        }

                    }
                    else
                    {
                        lblTvalue.Text = lblpackvalue.Text;
                    }
                }
                else if (lblEPK.Text == "300KM per Day ")
                {
                    if (totalKM > 300)
                    {
                        extraKM = totalKM - 300;
                        extraKMtotal = extraKMValuePerKM * extraKM;
                        totalValue = packvalue + extraKMtotal;

                        lbleeKMValue.Text = extraKM.ToString();
                        lblExKMvalue.Text = extraKMtotal.ToString();
                        lblTvalue.Text = totalValue.ToString();

                        int waitingH = DateTime.Compare(DateTime.Parse(lblMxHours.Text), DateTime.Parse(lblRHours.Text));
                        lblWhours.Text = waitingH.ToString();
                        if (waitingH > 0)
                        {
                            lblWhours.Text = "0";
                        }
                        else
                        {
                            waitingH = waitingH * -400;
                            lblWhours.Text = waitingH.ToString();
                        }

                    }
                    else
                    {
                        lblTvalue.Text = lblpackvalue.Text;
                    }
                }
            }

            else if (lblEVtyoe.Text == "SUV")
            {
                totalKM = endKM - startKM;
                if (lblEPK.Text == "100KM per Day")
                {
                    if (totalKM > 100)
                    {
                        extraKM = totalKM - 100;
                        extraKMtotal = extraKMValuePerKM * extraKM;
                        totalValue = packvalue + extraKMtotal;

                        lbleeKMValue.Text = extraKM.ToString();
                        lblExKMvalue.Text = extraKMtotal.ToString();
                        lblTvalue.Text = totalValue.ToString();

                        int waitingH = DateTime.Compare(DateTime.Parse(lblMxHours.Text), DateTime.Parse(lblRHours.Text));
                        lblWhours.Text = waitingH.ToString();
                        if (waitingH > 0)
                        {
                            lblWhours.Text = "0";
                        }
                        else
                        {
                            waitingH = waitingH * -400;
                            lblWhours.Text = waitingH.ToString();
                        }

                    }
                    else
                    {
                        lblTvalue.Text = lblpackvalue.Text;
                    }
                }
                else if (lblEPK.Text == "200KM per Day")
                {
                    if (totalKM > 200)
                    {
                        extraKM = totalKM - 200;
                        extraKMtotal = extraKMValuePerKM * extraKM;
                        totalValue = packvalue + extraKMtotal;

                        lbleeKMValue.Text = extraKM.ToString();
                        lblExKMvalue.Text = extraKMtotal.ToString();
                        lblTvalue.Text = totalValue.ToString();

                        int waitingH = DateTime.Compare(DateTime.Parse(lblMxHours.Text), DateTime.Parse(lblRHours.Text));
                        lblWhours.Text = waitingH.ToString();
                        if (waitingH > 0)
                        {
                            lblWhours.Text = "0";
                        }
                        else
                        {
                            waitingH = waitingH * -400;
                            lblWhours.Text = waitingH.ToString();
                        }

                    }
                    else
                    {
                        lblTvalue.Text = lblpackvalue.Text;
                    }
                }
                else if (lblEPK.Text == "300KM per Day ")
                {
                    if (totalKM > 300)
                    {
                        extraKM = totalKM - 300;
                        extraKMtotal = extraKMValuePerKM * extraKM;
                        totalValue = packvalue + extraKMtotal;

                        lbleeKMValue.Text = extraKM.ToString();
                        lblExKMvalue.Text = extraKMtotal.ToString();
                        lblTvalue.Text = totalValue.ToString();

                        int waitingH = DateTime.Compare(DateTime.Parse(lblMxHours.Text), DateTime.Parse(lblRHours.Text));
                        lblWhours.Text = waitingH.ToString();
                        if (waitingH > 0)
                        {
                            lblWhours.Text = "0";
                        }
                        else
                        {
                            waitingH = waitingH * -400;
                            lblWhours.Text = waitingH.ToString();
                        }

                    }
                    else
                    {
                        lblTvalue.Text = lblpackvalue.Text;
                    }
                }
            }

            else if (lblEVtyoe.Text == "MiniVan")
            {
                totalKM = endKM - startKM;
                if (lblEPK.Text == "100KM per Day")
                {
                    if (totalKM > 100)
                    {
                        extraKM = totalKM - 100;
                        extraKMtotal = extraKMValuePerKM * extraKM;
                        totalValue = packvalue + extraKMtotal;

                        lbleeKMValue.Text = extraKM.ToString();
                        lblExKMvalue.Text = extraKMtotal.ToString();
                        lblTvalue.Text = totalValue.ToString();

                        int waitingH = DateTime.Compare(DateTime.Parse(lblMxHours.Text), DateTime.Parse(lblRHours.Text));
                        lblWhours.Text = waitingH.ToString();
                        if (waitingH > 0)
                        {
                            lblWhours.Text = "0";
                        }
                        else
                        {
                            waitingH = waitingH * -400;
                            lblWhours.Text = waitingH.ToString();
                        }

                    }
                    else
                    {
                        lblTvalue.Text = lblpackvalue.Text;
                    }
                }
                else if (lblEPK.Text == "200KM per Day")
                {
                    if (totalKM > 200)
                    {
                        extraKM = totalKM - 200;
                        extraKMtotal = extraKMValuePerKM * extraKM;
                        totalValue = packvalue + extraKMtotal;

                        lbleeKMValue.Text = extraKM.ToString();
                        lblExKMvalue.Text = extraKMtotal.ToString();
                        lblTvalue.Text = totalValue.ToString();

                        int waitingH = DateTime.Compare(DateTime.Parse(lblMxHours.Text), DateTime.Parse(lblRHours.Text));
                        lblWhours.Text = waitingH.ToString();
                        if (waitingH > 0)
                        {
                            lblWhours.Text = "0";
                        }
                        else
                        {
                            waitingH = waitingH * -400;
                            lblWhours.Text = waitingH.ToString();
                        }

                    }
                    else
                    {
                        lblTvalue.Text = lblpackvalue.Text;
                    }
                }
                else if (lblEPK.Text == "300KM per Day ")
                {
                    if (totalKM > 300)
                    {
                        extraKM = totalKM - 300;
                        extraKMtotal = extraKMValuePerKM * extraKM;
                        totalValue = packvalue + extraKMtotal;

                        lbleeKMValue.Text = extraKM.ToString();
                        lblExKMvalue.Text = extraKMtotal.ToString();
                        lblTvalue.Text = totalValue.ToString();

                        int waitingH = DateTime.Compare(DateTime.Parse(lblMxHours.Text), DateTime.Parse(lblRHours.Text));
                        lblWhours.Text = waitingH.ToString();
                        if (waitingH > 0)
                        {
                            lblWhours.Text = "0";
                        }
                        else
                        {
                            waitingH = waitingH * -400;
                            lblWhours.Text = waitingH.ToString();
                        }

                    }
                    else
                    {
                        lblTvalue.Text = lblpackvalue.Text;
                    }
                }
            }

            else if (lblEVtyoe.Text == "Jeep")
            {
                totalKM = endKM - startKM;
                if (lblEPK.Text == "100KM per Day")
                {
                    if (totalKM > 100)
                    {
                        extraKM = totalKM - 100;
                        extraKMtotal = extraKMValuePerKM * extraKM;
                        totalValue = packvalue + extraKMtotal;

                        lbleeKMValue.Text = extraKM.ToString();
                        lblExKMvalue.Text = extraKMtotal.ToString();
                        lblTvalue.Text = totalValue.ToString();

                        int waitingH = DateTime.Compare(DateTime.Parse(lblMxHours.Text), DateTime.Parse(lblRHours.Text));
                        lblWhours.Text = waitingH.ToString();
                        if (waitingH > 0)
                        {
                            lblWhours.Text = "0";
                        }
                        else
                        {
                            waitingH = waitingH * -400;
                            lblWhours.Text = waitingH.ToString();
                        }

                    }
                    else
                    {
                        lblTvalue.Text = lblpackvalue.Text;
                    }
                }
                else if (lblEPK.Text == "200KM per Day")
                {
                    if (totalKM > 200)
                    {
                        extraKM = totalKM - 200;
                        extraKMtotal = extraKMValuePerKM * extraKM;
                        totalValue = packvalue + extraKMtotal;

                        lbleeKMValue.Text = extraKM.ToString();
                        lblExKMvalue.Text = extraKMtotal.ToString();
                        lblTvalue.Text = totalValue.ToString();
                        



                        int waitingH = DateTime.Compare(DateTime.Parse(lblMxHours.Text), DateTime.Parse(lblRHours.Text));
                        lblWhours.Text = waitingH.ToString();
                        if (waitingH > 0)
                        {
                            lblWhours.Text = "0";
                        }
                        else
                        {
                            waitingH = waitingH * -400;
                            lblWhours.Text = waitingH.ToString();
                        }

                    }
                    else
                    {
                        lblTvalue.Text = lblpackvalue.Text;
                    }
                }
                else if (lblEPK.Text == "300KM per Day ")
                {
                    if (totalKM > 300)
                    {
                        extraKM = totalKM - 300;
                        extraKMtotal = extraKMValuePerKM * extraKM;
                        totalValue = packvalue + extraKMtotal;

                        lbleeKMValue.Text = extraKM.ToString();
                        lblExKMvalue.Text = extraKMtotal.ToString();
                        lblTvalue.Text = totalValue.ToString();

                        int waitingH = DateTime.Compare(DateTime.Parse(lblMxHours.Text), DateTime.Parse(lblRHours.Text));
                        lblWhours.Text = waitingH.ToString();
                        if (waitingH > 0)
                        {
                            lblWhours.Text = "0";
                        }
                        else
                        {
                            waitingH = waitingH * -400;
                            lblWhours.Text = waitingH.ToString();
                        }

                    }
                    else
                    {
                        lblTvalue.Text = lblpackvalue.Text;
                    }
                }
            }
            else
            {
                totalKM = endKM - startKM;
                if (lblEPK.Text == "100KM per Day")
                {
                    if (totalKM > 100)
                    {
                        extraKM = totalKM - 100;
                        extraKMtotal = extraKMValuePerKM * extraKM;
                        totalValue = packvalue + extraKMtotal;

                        lbleeKMValue.Text = extraKM.ToString();
                        lblExKMvalue.Text = extraKMtotal.ToString();
                        lblTvalue.Text = totalValue.ToString();

                        int waitingH = DateTime.Compare(DateTime.Parse(lblMxHours.Text), DateTime.Parse(lblRHours.Text));
                        lblWhours.Text = waitingH.ToString();
                        if (waitingH > 0)
                        {
                            lblWhours.Text = "0";
                        }
                        else
                        {
                            waitingH = waitingH * -400;
                            lblWhours.Text = waitingH.ToString();
                        }

                    }
                    else
                    {
                        lblTvalue.Text = lblpackvalue.Text;
                    }
                }
                else if (lblEPK.Text == "200KM per Day")
                {
                    if (totalKM > 200)
                    {
                        extraKM = totalKM - 200;
                        extraKMtotal = extraKMValuePerKM * extraKM;
                        totalValue = packvalue + extraKMtotal;

                        lbleeKMValue.Text = extraKM.ToString();
                        lblExKMvalue.Text = extraKMtotal.ToString();
                        lblTvalue.Text = totalValue.ToString();

                        int waitingH = DateTime.Compare(DateTime.Parse(lblMxHours.Text), DateTime.Parse(lblRHours.Text));
                        lblWhours.Text = waitingH.ToString();
                        if (waitingH > 0)
                        {
                            lblWhours.Text = "0";
                        }
                        else
                        {
                            waitingH = waitingH * -400;
                            lblWhours.Text = waitingH.ToString();
                        }

                    }
                    else
                    {
                        lblTvalue.Text = lblpackvalue.Text;
                    }
                }
                else if (lblEPK.Text == "300KM per Day ")
                {
                    if (totalKM > 300)
                    {
                        extraKM = totalKM - 300;
                        extraKMtotal = extraKMValuePerKM * extraKM;
                        totalValue = packvalue + extraKMtotal;

                        lbleeKMValue.Text = extraKM.ToString();
                        lblExKMvalue.Text = extraKMtotal.ToString();
                        lblTvalue.Text = totalValue.ToString();

                        int waitingH = DateTime.Compare(DateTime.Parse(lblMxHours.Text), DateTime.Parse(lblRHours.Text));
                        lblWhours.Text = waitingH.ToString();
                        if (waitingH > 0)
                        {
                            lblWhours.Text = "0";
                        }
                        else
                        {
                            waitingH = waitingH * -400;
                            lblWhours.Text = waitingH.ToString();
                        }

                    }
                    else
                    {
                        lblTvalue.Text = lblpackvalue.Text;
                    }
                }

            }




        }

        private void Drive_Load(object sender, EventArgs e)
        {
            timer1.Start();
            hidepanel();
            panel1.Visible = false;
        }

        public void hidepanel()
        {
            pnStart.Visible = false;
            panel1.Visible = false;
        }
        private void lblStart_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            hidepanel();
            pnStart.Visible = true;
            
        }

        private void lblEnd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            hidepanel();
            panel1.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm");
            lblendTime.Text = DateTime.Now.ToString("HH:mm");
        }

        private void RStTime_Click(object sender, EventArgs e)
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
                db.record("insert into hired values('" + txtJno.Text + "','" + lblEJNo.Text + "','" + lblEVno.Text + "','" + lblEPK.Text + "','" + lblRHours.Text + "','" + eDate.Value.Date + "','" + eedate.Value.Date + "','" + lblTvalue.Text + "')");
                db.record("DELETE FROM hire WHERE username='" + lblEJNo.Text + "'");

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtStartKM_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDriName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVehiNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateHire_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblVehiType_Click(object sender, EventArgs e)
        {

        }

        private void lblJno_Click(object sender, EventArgs e)
        {

        }

        private void lblPK_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblPackType_Click(object sender, EventArgs e)
        {

        }

        private void txtUname_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
    

