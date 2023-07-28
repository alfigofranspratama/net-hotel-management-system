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

namespace HotelManagementSystem
{
    public partial class ClientInfo : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Documents\db_hotelmanagement.mdf;Integrated Security=True;Connect Timeout=30");

        public void populate()
        {
            con.Open();
            string query = "select * from clientTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            clientView.DataSource = ds.Tables[0];
            con.Close();
        }

        public ClientInfo()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateLbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void ClientInfo_Load(object sender, EventArgs e)
        {
            dateLbl.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into clientTable values('"+clientID.Text+"','"+clientName.Text+"','"+clientPhone.Text+"','"+clientCountry.SelectedItem.ToString()+"')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Client Successfully Added");
            con.Close();
        }
    }
}
