namespace AyuboTaxi
{
    partial class VehicleReg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehicleReg));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.ComboTrans = new System.Windows.Forms.ComboBox();
            this.dateReg = new System.Windows.Forms.DateTimePicker();
            this.comboVtype = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNoSeats = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOaddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOwnerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVehNo = new System.Windows.Forms.TextBox();
            this.pnlAdmin = new System.Windows.Forms.Panel();
            this.btnchangepassword = new System.Windows.Forms.LinkLabel();
            this.btnLogout = new System.Windows.Forms.LinkLabel();
            this.btnSetting = new System.Windows.Forms.LinkLabel();
            this.btnSetting2 = new System.Windows.Forms.PictureBox();
            this.btnSetting1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtFuelType = new System.Windows.Forms.ComboBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pnlAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetting2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetting1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(201)))), ((int)(((byte)(74)))));
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancel.Location = new System.Drawing.Point(587, 604);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 35);
            this.btnCancel.TabIndex = 62;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(201)))), ((int)(((byte)(74)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.Location = new System.Drawing.Point(365, 604);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 35);
            this.btnAdd.TabIndex = 61;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ComboTrans
            // 
            this.ComboTrans.FormattingEnabled = true;
            this.ComboTrans.Items.AddRange(new object[] {
            "Automatic",
            "Semi-Automatic",
            "Manual "});
            this.ComboTrans.Location = new System.Drawing.Point(367, 559);
            this.ComboTrans.Name = "ComboTrans";
            this.ComboTrans.Size = new System.Drawing.Size(322, 24);
            this.ComboTrans.TabIndex = 60;
            // 
            // dateReg
            // 
            this.dateReg.CustomFormat = "yyyy/mm/dd";
            this.dateReg.Location = new System.Drawing.Point(367, 275);
            this.dateReg.Name = "dateReg";
            this.dateReg.Size = new System.Drawing.Size(322, 22);
            this.dateReg.TabIndex = 68;
            // 
            // comboVtype
            // 
            this.comboVtype.FormattingEnabled = true;
            this.comboVtype.Items.AddRange(new object[] {
            "TukTuk",
            "Sedan Car",
            "SUV",
            "MiniVan",
            "Jeep",
            "Van"});
            this.comboVtype.Location = new System.Drawing.Point(367, 159);
            this.comboVtype.Name = "comboVtype";
            this.comboVtype.Size = new System.Drawing.Size(322, 24);
            this.comboVtype.TabIndex = 58;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(367, 534);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 17);
            this.label10.TabIndex = 57;
            this.label10.Text = "Transmission";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(364, 477);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 17);
            this.label7.TabIndex = 56;
            this.label7.Text = "Number Of Seats";
            // 
            // txtNoSeats
            // 
            this.txtNoSeats.BackColor = System.Drawing.Color.White;
            this.txtNoSeats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNoSeats.Location = new System.Drawing.Point(367, 497);
            this.txtNoSeats.Multiline = true;
            this.txtNoSeats.Name = "txtNoSeats";
            this.txtNoSeats.Size = new System.Drawing.Size(322, 29);
            this.txtNoSeats.TabIndex = 55;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(364, 420);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 17);
            this.label8.TabIndex = 54;
            this.label8.Text = "Fuel Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(364, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 52;
            this.label5.Text = "Owner Address";
            // 
            // txtOaddress
            // 
            this.txtOaddress.BackColor = System.Drawing.Color.White;
            this.txtOaddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOaddress.Location = new System.Drawing.Point(367, 383);
            this.txtOaddress.Multiline = true;
            this.txtOaddress.Name = "txtOaddress";
            this.txtOaddress.Size = new System.Drawing.Size(322, 29);
            this.txtOaddress.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(367, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 17);
            this.label6.TabIndex = 50;
            this.label6.Text = "Contact Number";
            // 
            // txtCno
            // 
            this.txtCno.BackColor = System.Drawing.Color.White;
            this.txtCno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCno.Location = new System.Drawing.Point(367, 326);
            this.txtCno.Multiline = true;
            this.txtCno.Name = "txtCno";
            this.txtCno.Size = new System.Drawing.Size(322, 29);
            this.txtCno.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(367, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 48;
            this.label3.Text = "Registration Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(367, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 47;
            this.label4.Text = "Owner Name";
            // 
            // txtOwnerName
            // 
            this.txtOwnerName.BackColor = System.Drawing.Color.White;
            this.txtOwnerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOwnerName.Location = new System.Drawing.Point(367, 213);
            this.txtOwnerName.Multiline = true;
            this.txtOwnerName.Name = "txtOwnerName";
            this.txtOwnerName.Size = new System.Drawing.Size(322, 29);
            this.txtOwnerName.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(367, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 45;
            this.label2.Text = "Vehicle Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(370, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 44;
            this.label1.Text = "Vehicle  Number";
            // 
            // txtVehNo
            // 
            this.txtVehNo.BackColor = System.Drawing.Color.White;
            this.txtVehNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVehNo.Location = new System.Drawing.Point(367, 97);
            this.txtVehNo.Multiline = true;
            this.txtVehNo.Name = "txtVehNo";
            this.txtVehNo.Size = new System.Drawing.Size(322, 29);
            this.txtVehNo.TabIndex = 43;
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.BackColor = System.Drawing.Color.Orange;
            this.pnlAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlAdmin.Controls.Add(this.btnchangepassword);
            this.pnlAdmin.Controls.Add(this.btnLogout);
            this.pnlAdmin.Controls.Add(this.btnSetting);
            this.pnlAdmin.Location = new System.Drawing.Point(92, 23);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Size = new System.Drawing.Size(10, 668);
            this.pnlAdmin.TabIndex = 65;
            this.pnlAdmin.Visible = false;
            // 
            // btnchangepassword
            // 
            this.btnchangepassword.AutoSize = true;
            this.btnchangepassword.BackColor = System.Drawing.Color.Transparent;
            this.btnchangepassword.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchangepassword.ForeColor = System.Drawing.Color.Maroon;
            this.btnchangepassword.LinkColor = System.Drawing.SystemColors.Info;
            this.btnchangepassword.Location = new System.Drawing.Point(12, 88);
            this.btnchangepassword.Name = "btnchangepassword";
            this.btnchangepassword.Size = new System.Drawing.Size(190, 27);
            this.btnchangepassword.TabIndex = 11;
            this.btnchangepassword.TabStop = true;
            this.btnchangepassword.Text = "Change Password";
            this.btnchangepassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnchangepassword_LinkClicked);
            // 
            // btnLogout
            // 
            this.btnLogout.AutoSize = true;
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Maroon;
            this.btnLogout.LinkColor = System.Drawing.SystemColors.Info;
            this.btnLogout.Location = new System.Drawing.Point(12, 130);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(83, 27);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.TabStop = true;
            this.btnLogout.Text = "Logout";
            this.btnLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnLogout_LinkClicked);
            // 
            // btnSetting
            // 
            this.btnSetting.AutoSize = true;
            this.btnSetting.BackColor = System.Drawing.Color.Transparent;
            this.btnSetting.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.Color.Maroon;
            this.btnSetting.LinkColor = System.Drawing.SystemColors.Info;
            this.btnSetting.Location = new System.Drawing.Point(12, 39);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(181, 27);
            this.btnSetting.TabIndex = 9;
            this.btnSetting.TabStop = true;
            this.btnSetting.Text = "Personal Details ";
            this.btnSetting.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnSetting_LinkClicked);
            // 
            // btnSetting2
            // 
            this.btnSetting2.BackColor = System.Drawing.Color.Transparent;
            this.btnSetting2.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting2.Image")));
            this.btnSetting2.Location = new System.Drawing.Point(24, 23);
            this.btnSetting2.Name = "btnSetting2";
            this.btnSetting2.Size = new System.Drawing.Size(62, 44);
            this.btnSetting2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSetting2.TabIndex = 64;
            this.btnSetting2.TabStop = false;
            this.btnSetting2.Visible = false;
            this.btnSetting2.Click += new System.EventHandler(this.btnSetting2_Click);
            // 
            // btnSetting1
            // 
            this.btnSetting1.BackColor = System.Drawing.Color.Transparent;
            this.btnSetting1.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting1.Image")));
            this.btnSetting1.Location = new System.Drawing.Point(24, 23);
            this.btnSetting1.Name = "btnSetting1";
            this.btnSetting1.Size = new System.Drawing.Size(62, 44);
            this.btnSetting1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSetting1.TabIndex = 63;
            this.btnSetting1.TabStop = false;
            this.btnSetting1.Click += new System.EventHandler(this.btnSetting1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtFuelType
            // 
            this.txtFuelType.FormattingEnabled = true;
            this.txtFuelType.Items.AddRange(new object[] {
            "Petrol",
            "Diesel",
            "Hibrid"});
            this.txtFuelType.Location = new System.Drawing.Point(365, 444);
            this.txtFuelType.Name = "txtFuelType";
            this.txtFuelType.Size = new System.Drawing.Size(324, 24);
            this.txtFuelType.TabIndex = 66;
            // 
            // VehicleReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AyuboTaxi.Properties.Resources.adminplus;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1060, 692);
            this.Controls.Add(this.txtFuelType);
            this.Controls.Add(this.pnlAdmin);
            this.Controls.Add(this.btnSetting2);
            this.Controls.Add(this.btnSetting1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.ComboTrans);
            this.Controls.Add(this.dateReg);
            this.Controls.Add(this.comboVtype);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNoSeats);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtOaddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOwnerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVehNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VehicleReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VehicleReg";
            this.pnlAdmin.ResumeLayout(false);
            this.pnlAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetting2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetting1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox ComboTrans;
        private System.Windows.Forms.DateTimePicker dateReg;
        private System.Windows.Forms.ComboBox comboVtype;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNoSeats;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOaddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOwnerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVehNo;
        private System.Windows.Forms.Panel pnlAdmin;
        private System.Windows.Forms.LinkLabel btnchangepassword;
        private System.Windows.Forms.LinkLabel btnLogout;
        private System.Windows.Forms.LinkLabel btnSetting;
        private System.Windows.Forms.PictureBox btnSetting2;
        private System.Windows.Forms.PictureBox btnSetting1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox txtFuelType;
        private System.Windows.Forms.Timer timer2;
    }
}