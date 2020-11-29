using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ELECTOMAR
{
    public partial class gestiondesemployes : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HOME;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public gestiondesemployes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == String.Empty || textBox2.Text == String.Empty || textBox3.Text == String.Empty || textBox4.Text == String.Empty || textBox5.Text == String.Empty || textBox6.Text == String.Empty || textBox7.Text == String.Empty || textBox8.Text == String.Empty || textBox9.Text == String.Empty || textBox10.Text == String.Empty)
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoire", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                NewMethod(cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("L'employe est bien ajouter!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = textBox8.Text = textBox9.Text = textBox10.Text = checkedListBox1.Text = dateTimePicker1.Text = dateTimePicker2.Text = "";
            }
        }

        private void NewMethod(SqlCommand cmd)
        {
            cmd.CommandText = "insert into dbo.HOME2 values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + checkedListBox1.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "')";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = textBox8.Text = textBox9.Text = textBox10.Text = checkedListBox1.Text = dateTimePicker1.Text = dateTimePicker2.Text = "";
        }
    }
}
