using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ELECTOMAR
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            SidePanel.Height = button16.Height;
            SidePanel.Top = button16.Top;
            firstCustomControl1.BringToFront();
        }
        
       

        private void button5_Click_1(object sender, EventArgs e)
        {
            SidePanel.Height = button5.Height;
            SidePanel.Top = button5.Top;
            mySecondCustmControl1.BringToFront();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Process.Start("www.electomarsud.com/");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button13.Height;
            SidePanel.Top = button13.Top;
            parteners1.BringToFront();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button16.Height;
            SidePanel.Top = button16.Top;
            firstCustomControl1.BringToFront();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button15.Height;
            SidePanel.Top = button15.Top;
            collection1.BringToFront();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button14.Height;
            SidePanel.Top = button14.Top;
            sevice2.BringToFront();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
            ourproject1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;
            request1.BringToFront();
        }
    }
}
