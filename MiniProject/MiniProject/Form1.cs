using System.Data.SqlClient;

namespace MiniProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-G1L2N9U\\SARANGI;Initial Catalog=MiniProject;Integrated Security=True");


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Register  (Id,Name,Phone,password) VALUES (@Id,@Name,@Phone,@password)", con);
            cmd.Parameters.AddWithValue("@Id", textBox1.Text);
            cmd.Parameters.AddWithValue("@Name",textBox1.Text);
            cmd.Parameters.AddWithValue("@Phone",int.Parse(textBox2.Text));
            cmd.Parameters.AddWithValue("@password",textBox3.Text);

            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Sussceffully Register");

            Navigate navigate = new Navigate();
            navigate.Show();
        }
    }
}
