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

namespace IOGKF
{
    public partial class Form7 : Form
    {

        public Form7()
        {
            InitializeComponent();
            dataGridView1.RowHeaderMouseClick += new DataGridViewCellMouseEventHandler(OnRowHeaderMouseClick);
        }

        private void OnRowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //MessageBox.Show("Clicked RowHeader!");
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBox8.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        //public string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Alibek\\Desktop\\IOGKF\\IOGKF\\IOGKF_members.mdf;Integrated Security=True;Connect Timeout=30";
        public string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\HP\\Desktop\\IOGKF\\IOGKF\\IOGKF_members.mdf;Integrated Security=True;Connect Timeout=30";

        //SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\Alibek\\Desktop\\IOGKF\\IOGKF\\IOGKF_members.mdf;Integrated Security = True; Connect Timeout = 30");
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\HP\\Desktop\\IOGKF\\IOGKF\\IOGKF_members.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        int ID = 0;

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "iOGKF_membersDataSet.Members". При необходимости она может быть перемещена или удалена.
            this.membersTableAdapter.Fill(this.iOGKF_membersDataSet.Members);
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Members", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string SqlText;

            SqlText = "DELETE FROM Members WHERE " + textBox1.Text.ToString();

            SqlDataAdapter da = new SqlDataAdapter(SqlText, conString);
            DataSet ds = new DataSet();
            da.Fill(ds, "[Members]");
            MessageBox.Show("Deleted successfully!");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "")
            {
                cmd = new SqlCommand("insert into Members(member_id,last_name,first_name,age,rank,rank_value,sensei,dojo) values(@member_id,@last_name,@first_name,@age,@rank,@rank_value,@sensei,@dojo)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@member_id", textBox1.Text);
                cmd.Parameters.AddWithValue("@last_name", textBox2.Text);
                cmd.Parameters.AddWithValue("@first_name", textBox3.Text);
                cmd.Parameters.AddWithValue("@age", textBox4.Text);
                cmd.Parameters.AddWithValue("@rank", textBox5.Text);
                cmd.Parameters.AddWithValue("@rank_value", textBox6.Text);
                cmd.Parameters.AddWithValue("@sensei", textBox7.Text);
                cmd.Parameters.AddWithValue("@dojo", textBox8.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted Successfully");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Members", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void ClearData()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            ID = 0;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBox8.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "")
            {
                cmd = new SqlCommand("update Members set member_id=@member_id,last_name=@last_name,first_name=@first_name,age=@age,rank=@rank,rank_value=@rank_value,sensei=@sensei,dojo=@dojo where member_id=@member_id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@member_id", textBox1.Text);
                cmd.Parameters.AddWithValue("@last_name", textBox2.Text);
                cmd.Parameters.AddWithValue("@first_name", textBox3.Text);
                cmd.Parameters.AddWithValue("@age", textBox4.Text);
                cmd.Parameters.AddWithValue("@rank", textBox5.Text);
                cmd.Parameters.AddWithValue("@rank_value", textBox6.Text);
                cmd.Parameters.AddWithValue("@sensei", textBox7.Text);
                cmd.Parameters.AddWithValue("@dojo", textBox8.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                con.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                cmd = new SqlCommand("delete Members where member_id=@member_id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@member_id", textBox1.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }
    }
}
