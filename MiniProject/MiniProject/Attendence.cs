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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MiniProject
{
    public partial class Attendence : Form
    {
        public Attendence()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-G1L2N9U\\SARANGI;Initial Catalog=MiniProject;Integrated Security=True");

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Attendence_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String satus;

            if (checkBox1.Checked)
            {
                satus = "Yes";

            }
            else
            {
                satus = "No";

            }

            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Attendence VALUES (@MemberId,@Date,@Name,@satus)", con);
            cmd.Parameters.AddWithValue("@MemberId", textBox1.Text);
            cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@Name", textBox3.Text);
            cmd.Parameters.AddWithValue("@satus", satus);

            cmd.ExecuteNonQuery();

            con.Close();
            button4_Click(sender, e);
            MessageBox.Show("Sussceffully Add");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String satus;

            if (checkBox1.Checked)
            {
                satus = "Yes";

            }
            else
            {
                satus = "No";

            }

            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE  Attendence SET Date=@Date,Name=@Name,satus=@satus WHERE MemberId=@MemberId", con);
            cmd.Parameters.AddWithValue("@MemberId", textBox1.Text);
            cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@Name", textBox3.Text);
            cmd.Parameters.AddWithValue("@satus", satus);

            cmd.ExecuteNonQuery();

            con.Close();
            button4_Click(sender, e);
            MessageBox.Show("Sussceffully Update");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE Attendence WHERE MemberId=@MemberId", con);
            cmd.Parameters.AddWithValue("@MemberId", textBox1.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            button4_Click(sender, e);
            MessageBox.Show("Sussceffully Delete");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT *  FROM Attendence", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) AS AttendenceCount   FROM Attendence WHERE satus='Yes' ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) AS LeaveCount   FROM Attendence WHERE satus='No' ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT *    FROM Attendence WHERE satus='Yes' ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT *   FROM Attendence WHERE satus='No' ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
