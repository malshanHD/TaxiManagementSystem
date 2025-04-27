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
    public partial class AyuboTaxi : Form
    {
        public AyuboTaxi()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 4;
            if (panel2.Width >= 920)
            {
                timer1.Stop();
                Login log = new Login();
                log.Show();
                this.Hide();
            }
        
        }


        private void AyuboTaxi_Load(object sender, EventArgs e)
        {

        }
    }
    }

