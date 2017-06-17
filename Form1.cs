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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool login = false;
            string connetionString = null;
            SqlConnection con;
            connetionString = @"Data Source=DELL\SQLEXPRESS;Initial Catalog=RMS;Integrated Security=True";
            con = new SqlConnection(connetionString);
            con.Open();
            string sql = "select * from user1 where Name='" + textBox1.Text + "' and Password='" + textBox2.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                login = true;
            }
            dr.Close();
            con.Close();
            if (login==true)
            {
                MessageBox.Show("login Sucessfull");
                Form3 frm = new Form3();
                frm.Show();
            }
            else
            {
                MessageBox.Show("please use valid name and password");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 frm = new Form6();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form9 frm = new Form9();
            frm.Show();
        }
    }
}
