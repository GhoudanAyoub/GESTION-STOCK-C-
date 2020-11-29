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
    public partial class sevice2 : UserControl
    {
        public sevice2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TP tP = new TP();
            tP.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TI tI = new TI();
            tI.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CF cF = new CF();
            cF.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TX tX = new TX();
            tX.Show();
        }
    }
}
