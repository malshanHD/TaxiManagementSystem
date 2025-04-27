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
    public partial class AdminAccountSet : Form
    {
        public AdminAccountSet()
        {
            InitializeComponent();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

       

        private void AdminAccountSet_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            AdminMenu adm = new AdminMenu();
            adm.Show();
            this.Hide();
        }
    }
}
