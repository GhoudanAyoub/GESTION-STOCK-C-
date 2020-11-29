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

namespace ELECTOMAR
{
    public partial class EDITEMPLOYER : Form
    {
        SqlConnection  con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HOME;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public EDITEMPLOYER()
        {
            InitializeComponent();
            SidePanel1.Height = button23.Height;
            SidePanel1.Top = button23.Top;
            home21.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void disp_data()
        {
                con.Open();
                String query = "SELECT * FROM HOME2";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                SDA.Fill(dt);
                con.Close();
        }
        private void EDITEMPLOYER_Load(object sender, EventArgs e)
        {
            disp_data();
        }
        
        private void button23_Click(object sender, EventArgs e)
        {

            SidePanel1.Height = button23.Height;
            SidePanel1.Top = button23.Top;
            home21.BringToFront();
        }

        private void button18_Click(object sender, EventArgs e)
        {

            SidePanel1.Height = button18.Height;
            SidePanel1.Top = button18.Top;
            viewrequest1.BringToFront();
        }
        
    }
    
}
