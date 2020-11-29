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
    public partial class recherchemploye : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HOME;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public recherchemploye()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM HOME2 WHERE NOM= '" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter(cmd);

            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            textBox1.Text = "";
        }
        private void disp_data()
        {
            con.Open();
            String query = "SELECT * FROM HOME2";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void recherchemploye_Load(object sender, EventArgs e)
        {
            disp_data();
        }
    }
}
