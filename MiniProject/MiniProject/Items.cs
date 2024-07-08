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
    public partial class Items : Form
    {
        public Items()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-G1L2N9U\\SARANGI;Initial Catalog=MiniProject;Integrated Security=True");


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Items_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Items VALUES (@ItemID,@ItemCategory,@date)", con);
            cmd.Parameters.AddWithValue("@ItemID", textBox1.Text);
            cmd.Parameters.AddWithValue("@ItemCategory", textBox3.Text);
            cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value);


            cmd.ExecuteNonQuery();

            con.Close();
            button4_Click(sender, e);
            MessageBox.Show("Sussceffully Add");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE  Items SET ItemCategory=@ItemCategory,date=@date WHERE ItemId=@ItemID", con);
            cmd.Parameters.AddWithValue("@ItemID", textBox1.Text);
            cmd.Parameters.AddWithValue("@ItemCategory", textBox3.Text);
            cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value);

            cmd.ExecuteNonQuery();

            con.Close();
            button4_Click(sender, e);
            MessageBox.Show("Sussceffully Update");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE Items WHERE ItemId=@ItemID", con);
            cmd.Parameters.AddWithValue("@ItemID", textBox1.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            button4_Click(sender, e);
            MessageBox.Show("Sussceffully Delete");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT *  FROM Items", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt   = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
