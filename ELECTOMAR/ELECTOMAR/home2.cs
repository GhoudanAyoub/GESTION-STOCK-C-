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
    public partial class home2 : UserControl
    {
        public home2()
        {
            InitializeComponent();
            SidePanel11.Height = button30.Height;
            SidePanel11.Top = button30.Top;
            gestiondesemployes1.BringToFront();
        }

        private void button30_Click(object sender, EventArgs e)
        {

            SidePanel11.Height = button30.Height;
            SidePanel11.Top = button30.Top;
            gestiondesemployes1.BringToFront();
        }

        private void button31_Click(object sender, EventArgs e)
        {

            SidePanel11.Height = button31.Height;
            SidePanel11.Top = button31.Top;
            supprimeremploye1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SidePanel11.Height = button1.Height;
            SidePanel11.Top = button1.Top;
            recherchemploye1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SidePanel11.Height = button2.Height;
            SidePanel11.Top = button2.Top;
            modifieremploye1.BringToFront();
        }
    }
}
