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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool login = false;
            string connetionString = null;
            SqlConnection con;
            connetionString = @"Data Source=DELL\SQLEXPRESS;Initial Catalog=RMS;Integrated Security=True";
            con = new SqlConnection(connetionString);
            con.Open();
            string sql = "select * from admin where Name='" + textBox1.Text + "' and Password='" + textBox2.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                login = true;
            }
            dr.Close();
            con.Close();
            if (login == true)
            {
                MessageBox.Show("login Sucessfull");
                Form10 frm = new Form10();
                frm.Show();
            }
            else
            {
                MessageBox.Show("please use valid name and password");
            }
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }
    }
}
