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
    public partial class request : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DEMANDE;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public request()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == String.Empty || textBox2.Text == String.Empty || textBox3.Text == String.Empty || textBox4.Text == String.Empty || textBox5.Text == String.Empty)
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
                MessageBox.Show("La demande a ete envoye avec success", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = "";
                this.Hide();
                Form4 f4 = new Form4();
                f4.Show();
            }
        }
            private void NewMethod(SqlCommand cmd)
            {
                cmd.CommandText = "insert into dbo.DEMANDE values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + checkBox1.Checked + "','" + checkBox2.Checked + "','" + checkBox3.Checked + "','" + checkBox4.Checked + "')";
            }


        
    }
}


  