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

namespace PhoneShop
{
    public partial class customerform : Form
    {
        public customerform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\zare\\PhoneShop\\PhoneShop\\phoneshopdata.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into phones values (@Model,@Color,@Memory,@RAM,@CPU,@Price)", con);

            cmd.Parameters.AddWithValue("@Name", textBox1.Text); cmd.Parameters.AddWithValue("@Model", textBox1.Text);
            cmd.Parameters.AddWithValue("@Family", textBox2.Text);
            cmd.Parameters.AddWithValue("@Address", textBox5.Text);
            cmd.Parameters.AddWithValue("@Phone", int.Parse(textBox4.Text));
            cmd.Parameters.AddWithValue("@Post", int.Parse(textBox3.Text));
           
            //cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("successfully saved");






        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\zare\\PhoneShop\\PhoneShop\\phoneshopdata.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update phones set Name=@Name,Family=@Family,Address=@Address,Phone=@Phone,Post=@Post, where id=@id", con);

            cmd.Parameters.AddWithValue("@Name", textBox1.Text); cmd.Parameters.AddWithValue("@Model", textBox1.Text);
            cmd.Parameters.AddWithValue("@Family", textBox2.Text);
            cmd.Parameters.AddWithValue("@Address", textBox5.Text);
            cmd.Parameters.AddWithValue("@Phone", int.Parse(textBox4.Text));
            cmd.Parameters.AddWithValue("@Post", int.Parse(textBox3.Text));
            //cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("successfully updated");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\zare\\PhoneShop\\PhoneShop\\phoneshopdata.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete phones where id=@id", con);
            cmd.Parameters.AddWithValue("@Name", textBox1.Text);
            // cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("deleted");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\zare\\PhoneShop\\PhoneShop\\phoneshopdata.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from customer ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dataGridView1.DataSource = dt;
            da.Fill(dt);
        }
    }
}
