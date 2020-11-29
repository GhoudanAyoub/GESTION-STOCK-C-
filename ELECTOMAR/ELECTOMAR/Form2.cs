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
using System.Data.SqlClient;

namespace ELECTOMAR
{
    public partial class Form2 : Form
    {
        

        public Form2()
        {
            InitializeComponent();
            Init_Data();
        }

        private void Seconnecter_Load(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }


        private void button5_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.facebook.com/ayoub.ghoudan");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "ELFAQIH" && textBox2.Text == "OMAR123456789")
            {
                EDITEMPLOYER E = new EDITEMPLOYER();
                E.Show();
                this.Hide();
            }
            else { 

            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HOME;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlDataAdapter sda = new SqlDataAdapter("SELECT Count(*) FROM HOME WHERE Username='" + textBox1.Text + "' and mot_de_pass='" + textBox2.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    Form4 f4 = new Form4();
                    f4.Show();
                    
                }
                else
                {
                    MessageBox.Show("Username ou mot de passe invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Text = textBox2.Text = "";
                }

            }
        }

        private void Init_Data()
        {
            if (Properties.Settings.Default.Username != string.Empty)
            {
                textBox1.Text = Properties.Settings.Default.Username;
                checkBox1.Checked = true;
            }
            else
            {
                textBox1.Text = Properties.Settings.Default.Username;
            }
        }
        private void save_data()
        {
            if (checkBox1.Checked)
            {
                Properties.Settings.Default.Username = textBox1.Text;
                Properties.Settings.Default.renne = "yes";
                Properties.Settings.Default.Save();
            }
            else
            {

                Properties.Settings.Default.Username = textBox1.Text;
                Properties.Settings.Default.renne = "no";
                Properties.Settings.Default.Save();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
