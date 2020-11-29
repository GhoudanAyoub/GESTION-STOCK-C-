using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace ELECTOMAR
{
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HOME;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public Form3()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            int minvalue = 8;

            if (textBox1.Text == String.Empty || textBox2.Text == String.Empty || textBox3.Text == String.Empty || textBox4.Text == String.Empty || textBox5.Text== String.Empty || textBox6.Text == String.Empty)
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoire", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox5.Text.Length < minvalue)
            {
                MessageBox.Show("Le mot de passe doit contenir au moins 8 caractères", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox5.Text != textBox6.Text)
            {
                MessageBox.Show("Les mots de passes ne correspondent pas", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                NewMethod(cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("La demande a ete envoye avec success", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = "";
                this.Hide();
                Form2 f2 = new Form2();
                f2.Show();
            }
        }

        private void NewMethod(SqlCommand cmd)
        {
            cmd.CommandText = "insert into dbo.HOME values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}



