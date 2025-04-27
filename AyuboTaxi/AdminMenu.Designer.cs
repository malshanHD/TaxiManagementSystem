namespace AyuboTaxi
{
    partial class AdminMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenu));
            this.btnNewVehi = new System.Windows.Forms.PictureBox();
            this.btnNewAdmin = new System.Windows.Forms.PictureBox();
            this.btnSetting1 = new System.Windows.Forms.PictureBox();
            this.btnSetting2 = new System.Windows.Forms.PictureBox();
            this.pnlAdmin = new System.Windows.Forms.Panel();
            this.btnchangepassword = new System.Windows.Forms.LinkLabel();
            this.btnLogout = new System.Windows.Forms.LinkLabel();
            this.btnSetting = new System.Windows.Forms.LinkLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnHire = new System.Windows.Forms.Button();
            this.btnRent = new System.Windows.Forms.Button();
            this.btnLT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnNewVehi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNewAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetting1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetting2)).BeginInit();
            this.pnlAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewVehi
            // 
            this.btnNewVehi.BackColor = System.Drawing.Color.Transparent;
            this.btnNewVehi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewVehi.Image = global::AyuboTaxi.Properties.Resources.Car_ssspng;
            this.btnNewVehi.Location = new System.Drawing.Point(312, 223);
            this.btnNewVehi.Name = "btnNewVehi";
            this.btnNewVehi.Size = new System.Drawing.Size(175, 158);
            this.btnNewVehi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnNewVehi.TabIndex = 1;
            this.btnNewVehi.TabStop = false;
            this.btnNewVehi.Click += new System.EventHandler(this.btnNewVehi_Click);
            // 
            // btnNewAdmin
            // 
            this.btnNewAdmin.BackColor = System.Drawing.Color.Transparent;
            this.btnNewAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnNewAdmin.Image")));
            this.btnNewAdmin.Location = new System.Drawing.Point(634, 223);
            this.btnNewAdmin.Name = "btnNewAdmin";
            this.btnNewAdmin.Size = new System.Drawing.Size(175, 158);
            this.btnNewAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnNewAdmin.TabIndex = 2;
            this.btnNewAdmin.TabStop = false;
            this.btnNewAdmin.Click += new System.EventHandler(this.btnNewAdmin_Click);
            // 
            // btnSetting1
            // 
            this.btnSetting1.BackColor = System.Drawing.Color.Transparent;
            this.btnSetting1.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting1.Image")));
            this.btnSetting1.Location = new System.Drawing.Point(12, 26);
            this.btnSetting1.Name = "btnSetting1";
            this.btnSetting1.Size = new System.Drawing.Size(62, 44);
            this.btnSetting1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSetting1.TabIndex = 3;
            this.btnSetting1.TabStop = false;
            this.btnSetting1.Click += new System.EventHandler(this.btnSetting1_Click);
            // 
            // btnSetting2
            // 
            this.btnSetting2.BackColor = System.Drawing.Color.Transparent;
            this.btnSetting2.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting2.Image")));
            this.btnSetting2.Location = new System.Drawing.Point(12, 25);
            this.btnSetting2.Name = "btnSetting2";
            this.btnSetting2.Size = new System.Drawing.Size(62, 44);
            this.btnSetting2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSetting2.TabIndex = 4;
            this.btnSetting2.TabStop = false;
            this.btnSetting2.Visible = false;
            this.btnSetting2.Click += new System.EventHandler(this.btnSetting2_Click);
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.BackColor = System.Drawing.Color.Orange;
            this.pnlAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlAdmin.Controls.Add(this.btnchangepassword);
            this.pnlAdmin.Controls.Add(this.btnLogout);
            this.pnlAdmin.Controls.Add(this.btnSetting);
            this.pnlAdmin.Location = new System.Drawing.Point(80, 26);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Size = new System.Drawing.Size(10, 668);
            this.pnlAdmin.TabIndex = 5;
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
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btnHire
            // 
            this.btnHire.BackColor = System.Drawing.Color.OrangeRed;
            this.btnHire.Font = new System.Drawing.Font("Meiryo", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHire.Location = new System.Drawing.Point(299, 496);
            this.btnHire.Name = "btnHire";
            this.btnHire.Size = new System.Drawing.Size(200, 57);
            this.btnHire.TabIndex = 6;
            this.btnHire.Text = "HIRE";
            this.btnHire.UseVisualStyleBackColor = false;
            this.btnHire.Click += new System.EventHandler(this.btnHire_Click);
            // 
            // btnRent
            // 
            this.btnRent.BackColor = System.Drawing.Color.OrangeRed;
            this.btnRent.Font = new System.Drawing.Font("Meiryo", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRent.Location = new System.Drawing.Point(618, 496);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(200, 57);
            this.btnRent.TabIndex = 7;
            this.btnRent.Text = "RENT";
            this.btnRent.UseVisualStyleBackColor = false;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // btnLT
            // 
            this.btnLT.BackColor = System.Drawing.Color.OrangeRed;
            this.btnLT.Font = new System.Drawing.Font("Meiryo", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLT.Location = new System.Drawing.Point(431, 587);
            this.btnLT.Name = "btnLT";
            this.btnLT.Size = new System.Drawing.Size(254, 57);
            this.btnLT.TabIndex = 8;
            this.btnLT.Text = "Long Tour";
            this.btnLT.UseVisualStyleBackColor = false;
            this.btnLT.Click += new System.EventHandler(this.btnLT_Click);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1060, 692);
            this.Controls.Add(this.btnLT);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.btnHire);
            this.Controls.Add(this.pnlAdmin);
            this.Controls.Add(this.btnSetting2);
            this.Controls.Add(this.btnSetting1);
            this.Controls.Add(this.btnNewAdmin);
            this.Controls.Add(this.btnNewVehi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMenu";
            ((System.ComponentModel.ISupportInitialize)(this.btnNewVehi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNewAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetting1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetting2)).EndInit();
            this.pnlAdmin.ResumeLayout(false);
            this.pnlAdmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnNewVehi;
        private System.Windows.Forms.PictureBox btnNewAdmin;
        private System.Windows.Forms.PictureBox btnSetting1;
        private System.Windows.Forms.PictureBox btnSetting2;
        private System.Windows.Forms.Panel pnlAdmin;
        private System.Windows.Forms.LinkLabel btnSetting;
        private System.Windows.Forms.LinkLabel btnLogout;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.LinkLabel btnchangepassword;
        private System.Windows.Forms.Button btnHire;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Button btnLT;
    }
}