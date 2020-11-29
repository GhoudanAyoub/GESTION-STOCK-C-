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
    public partial class modifieremploye : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HOME;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public modifieremploye()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update dbo.HOME2 set salaire ='" + textBox9.Text + "' where salaire='" + textBox8.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            disp_data();
            MessageBox.Show("vous avez modifier un employe!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox9.Text = textBox8.Text = "";
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

        private void modifieremploye_Load(object sender, EventArgs e)
        {
            disp_data();
        }
    }
}
