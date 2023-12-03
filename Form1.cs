using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnphone_Click(object sender, EventArgs e)
        {
            phoneform pf = new phoneform();
            pf.Show();
        }

        private void btncustomer_Click(object sender, EventArgs e)
        {
            customerform cf = new customerform();
            cf.Show();
        }
    }
}
