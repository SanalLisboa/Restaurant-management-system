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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
         
        }
        SqlConnection con;
        SqlDataAdapter mda;
        int i = 0;
        DataTable dt = new DataTable();
        string name;
        private void Form10_Load(object sender, EventArgs e)
        {
            
            string connetionString = @"Data Source=DELL\SQLEXPRESS;Initial Catalog=RMS;Integrated Security=True";
            con = new SqlConnection(connetionString);
            con.Open();
            mda = new SqlDataAdapter("select * from Reservation3 ", con);

            
            mda.Fill(dt);
            showdata();

            
        }
        public void showdata()
        {
            

            textBox1.Text = dt.Rows[i][0].ToString();
            textBox2.Text = dt.Rows[i][1].ToString();
            textBox3.Text = dt.Rows[i][2].ToString();
            textBox4.Text = dt.Rows[i][3].ToString();
            name = textBox1.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            i--;
            if ( i >= 0)
            {
                showdata();
            }
            else
            {
                MessageBox.Show("End");
                i = 0;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            i = dt.Rows.Count - 1;
            showdata();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            i = 0;
            showdata();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            i++;
            if (i < dt.Rows.Count)
            {
                showdata();
            }
            else
            {
                MessageBox.Show("End");
                i = dt.Rows.Count - 1;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string s;
            s = "delete from Reservation3 where Name ='"+name+"'";
            SqlCommand cd = new SqlCommand(s, con);
            cd.ExecuteNonQuery();
            MessageBox.Show("Record Deleted ");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlCommand d = new SqlCommand("insert into Reservation3 (Name,Date,Time,Type) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" +textBox4.Text+"')", con);
            d.ExecuteNonQuery();
            MessageBox.Show("inserted");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string p;
            p= "update Reservation3 set Name = '" + textBox1.Text + "',Date = '" + textBox2.Text + "',Time = '" + textBox3.Text + "',Type = '" + textBox4.Text + "' where Name='" + name + "'";
            SqlCommand l = new SqlCommand(p, con);
               l.ExecuteNonQuery();
            MessageBox.Show("Record updated");
                
                }
    }
}
