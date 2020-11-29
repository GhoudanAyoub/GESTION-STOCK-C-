using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELECTOMAR
{
    public partial class ourproject : UserControl
    {
        public ourproject()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("!!!Oops No Other Pictures For CLINIQUE LE MARRAKECH!!!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hayoub h = new Hayoub();
            h.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            riad r = new riad();
            r.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hcaspin hcaspin = new Hcaspin();
            hcaspin.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("!!!Oops No Other Pictures For CLINIQUE GRAND ATLAS!!!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("!!!Oops No Other Pictures For ETABLISSEMENT EL IRAQI!!!");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("!!!Oops No Other Pictures!!!");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("!!!Oops No Other Pictures!!!");
        }
    }
}
