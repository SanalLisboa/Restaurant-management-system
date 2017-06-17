using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Restaurant_management_system
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            SqlConnection con;
            connetionString = @"Data Source=DELL\SQLEXPRESS;Initial Catalog=RMS;Integrated Security=True";
            con = new SqlConnection(connetionString);

         
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into user1 (Name,Password,Email,Mobile,Address) values('" + textBox1.Text + "','" + textBox2.Text + "','" +textBox3.Text+"','" +textBox4.Text+"','" +richTextBox1.Text+"')", con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("SUBMITED! ");
                con.Close();
            Form1 frm = new Form1();
            frm.Show();


        }
    }

        }
    

