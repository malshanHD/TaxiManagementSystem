namespace AyuboTaxi
{
    partial class newAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newAdmin));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlAdmin = new System.Windows.Forms.Panel();
            this.btnchangepassword = new System.Windows.Forms.LinkLabel();
            this.btnLogout = new System.Windows.Forms.LinkLabel();
            this.btnSetting = new System.Windows.Forms.LinkLabel();
            this.btnSetting2 = new System.Windows.Forms.PictureBox();
            this.btnSetting1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUname = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtConNo = new System.Windows.Forms.TextBox();
            this.txtadd = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
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
            this.btnCancel.Location = new System.Drawing.Point(613, 603);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 35);
            this.btnCancel.TabIndex = 42;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(201)))), ((int)(((byte)(74)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.Location = new System.Drawing.Point(391, 603);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 35);
            this.btnAdd.TabIndex = 41;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.BackColor = System.Drawing.Color.Orange;
            this.pnlAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlAdmin.Controls.Add(this.btnchangepassword);
            this.pnlAdmin.Controls.Add(this.btnLogout);
            this.pnlAdmin.Controls.Add(this.btnSetting);
            this.pnlAdmin.Location = new System.Drawing.Point(70, 65);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Size = new System.Drawing.Size(10, 668);
            this.pnlAdmin.TabIndex = 45;
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
            this.btnSetting2.Location = new System.Drawing.Point(2, 65);
            this.btnSetting2.Name = "btnSetting2";
            this.btnSetting2.Size = new System.Drawing.Size(62, 44);
            this.btnSetting2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSetting2.TabIndex = 44;
            this.btnSetting2.TabStop = false;
            this.btnSetting2.Visible = false;
            this.btnSetting2.Click += new System.EventHandler(this.btnSetting2_Click);
            // 
            // btnSetting1
            // 
            this.btnSetting1.BackColor = System.Drawing.Color.Transparent;
            this.btnSetting1.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting1.Image")));
            this.btnSetting1.Location = new System.Drawing.Point(2, 65);
            this.btnSetting1.Name = "btnSetting1";
            this.btnSetting1.Size = new System.Drawing.Size(62, 44);
            this.btnSetting1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSetting1.TabIndex = 43;
            this.btnSetting1.TabStop = false;
            this.btnSetting1.Click += new System.EventHandler(this.btnSetting1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(387, 521);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(387, 453);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(387, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Your Email Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(387, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Your Contact Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(387, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Your Permanent Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(387, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Full Name";
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(201)))), ((int)(((byte)(74)))));
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.DimGray;
            this.txtPass.Location = new System.Drawing.Point(391, 540);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(331, 27);
            this.txtPass.TabIndex = 17;
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUname
            // 
            this.txtUname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(201)))), ((int)(((byte)(74)))));
            this.txtUname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUname.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUname.ForeColor = System.Drawing.Color.DimGray;
            this.txtUname.Location = new System.Drawing.Point(391, 471);
            this.txtUname.Multiline = true;
            this.txtUname.Name = "txtUname";
            this.txtUname.Size = new System.Drawing.Size(331, 27);
            this.txtUname.TabIndex = 16;
            this.txtUname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(201)))), ((int)(((byte)(74)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.DimGray;
            this.txtEmail.Location = new System.Drawing.Point(391, 403);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(331, 27);
            this.txtEmail.TabIndex = 15;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtConNo
            // 
            this.txtConNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(201)))), ((int)(((byte)(74)))));
            this.txtConNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConNo.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConNo.ForeColor = System.Drawing.Color.DimGray;
            this.txtConNo.Location = new System.Drawing.Point(391, 331);
            this.txtConNo.Multiline = true;
            this.txtConNo.Name = "txtConNo";
            this.txtConNo.Size = new System.Drawing.Size(331, 27);
            this.txtConNo.TabIndex = 14;
            this.txtConNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtadd
            // 
            this.txtadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(201)))), ((int)(((byte)(74)))));
            this.txtadd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtadd.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadd.ForeColor = System.Drawing.Color.DimGray;
            this.txtadd.Location = new System.Drawing.Point(391, 258);
            this.txtadd.Multiline = true;
            this.txtadd.Name = "txtadd";
            this.txtadd.Size = new System.Drawing.Size(331, 27);
            this.txtadd.TabIndex = 13;
            this.txtadd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFName
            // 
            this.txtFName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(201)))), ((int)(((byte)(74)))));
            this.txtFName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFName.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFName.ForeColor = System.Drawing.Color.DimGray;
            this.txtFName.Location = new System.Drawing.Point(391, 186);
            this.txtFName.Multiline = true;
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(331, 27);
            this.txtFName.TabIndex = 12;
            this.txtFName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // newAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1060, 692);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pnlAdmin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSetting2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSetting1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtadd);
            this.Controls.Add(this.txtUname);
            this.Controls.Add(this.txtConNo);
            this.Controls.Add(this.txtEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "newAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "newAdmin";
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
        private System.Windows.Forms.Panel pnlAdmin;
        private System.Windows.Forms.LinkLabel btnchangepassword;
        private System.Windows.Forms.LinkLabel btnLogout;
        private System.Windows.Forms.LinkLabel btnSetting;
        private System.Windows.Forms.PictureBox btnSetting2;
        private System.Windows.Forms.PictureBox btnSetting1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUname;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtConNo;
        private System.Windows.Forms.TextBox txtadd;
        private System.Windows.Forms.TextBox txtFName;
    }
}