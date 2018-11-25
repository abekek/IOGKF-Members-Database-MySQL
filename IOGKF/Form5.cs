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

namespace IOGKF
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        public string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\HP\\Desktop\\IOGKF\\IOGKF\\IOGKF_members.mdf;Integrated Security=True;Connect Timeout=30";
        //public string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Alibek\\Desktop\\IOGKF\\IOGKF\\IOGKF_members.mdf;Integrated Security=True;Connect Timeout=30";
        //public string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Users\020331600578\\Desktop\\IOGKF\\IOGKF\\IOGKF_members.mdf;Integrated Security=True;Connect Timeout=30";

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form3 form3= new Form3();
            form3.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);

            con.Open();

            if(con.State == System.Data.ConnectionState.Open)
            {
                string q = "insert into Members(member_id, last_name, first_name," +
                    " age, rank, rank_value, sensei, dojo)" +
                    " values('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + comboBox2.Text.ToString() + "','" + comboBox1.Text.ToString() + "','" + comboBox3.Text.ToString() + "','" + textBox8.Text.ToString() + "') ";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Connection was successful!");
            }

            con.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
