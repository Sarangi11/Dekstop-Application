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

namespace MiniProject
{
    public partial class Member_Task : Form
    {
        public Member_Task()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-G1L2N9U\\SARANGI;Initial Catalog=MiniProject;Integrated Security=True");


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Members VALUES (@MemberId,@Name,@PhoneNumber,@Adress)", con);
            cmd.Parameters.AddWithValue("@MemberId", textBox1.Text);
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@PhoneNumber", int.Parse(textBox3.Text));
            cmd.Parameters.AddWithValue("@Adress", textBox4.Text);

            cmd.ExecuteNonQuery();

            con.Close();
            button4_Click(sender, e);
            MessageBox.Show("Sussceffully Add");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE  Members SET Name=@Name,PhoneNumber=@PhoneNumber,Adress=@Adress WHERE MemberId=@MemberId", con);
            cmd.Parameters.AddWithValue("@MemberId", textBox1.Text);
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@PhoneNumber", int.Parse(textBox3.Text));
            cmd.Parameters.AddWithValue("@Adress", textBox4.Text);

            cmd.ExecuteNonQuery();

            con.Close();
            button4_Click(sender, e);
            MessageBox.Show("Sussceffully Update");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE Members WHERE MemberId=@MemberId", con);
            cmd.Parameters.AddWithValue("@MemberId", textBox1.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            button4_Click(sender, e);
            MessageBox.Show("Sussceffully Delete");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT *  FROM Members", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
