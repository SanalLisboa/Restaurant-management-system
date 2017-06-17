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
namespace Restaurant_management_system
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            SqlConnection con;
            connetionString = @"Data Source=DELL\SQLEXPRESS;Initial Catalog=RMS;Integrated Security=True";
            con = new SqlConnection(connetionString);
            con.Open();
            string str;
            str = "select * from reservation3 where Name ='" + textBox1.Text.Trim() + "'";
            SqlCommand cmd = new SqlCommand(str ,con);
            SqlDataReader reader = cmd.ExecuteReader();
            if(reader.Read())
            {
                textBox2.Text = reader["Name"].ToString();
                textBox3.Text = reader["Date"].ToString();
                textBox4.Text = reader["Time"].ToString();
                textBox5.Text = reader["Type"].ToString();
            }
   
   


        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
