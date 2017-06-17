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
    public partial class Form4 : Form
    {
        public static string value1;
        public static string value2 ;
        public static string value3 ;
        public static string value4 ;
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            value1 = textBox1.Text;
        value2 = textBox2.Text;
        value3 = textBox3.Text;
        value4 = "Family";
        string connetionString = null;
            SqlConnection con;
            connetionString = @"Data Source=DELL\SQLEXPRESS;Initial Catalog=RMS;Integrated Security=True";
            con = new SqlConnection(connetionString);


            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Reservation3 (Name,Date,Time,Type) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','Family')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Booked");
            Form7 frm = new Form7();
            frm.Show();


            con.Close();
          
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

