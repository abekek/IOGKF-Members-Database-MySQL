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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        //SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\Alibek\\Desktop\\IOGKF\\IOGKF\\IOGKF_members.mdf;Integrated Security = True; Connect Timeout = 30");
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\HP\\Desktop\\IOGKF\\IOGKF\\IOGKF_members.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataAdapter adapt;

        //public string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Alibek\\Desktop\\IOGKF\\IOGKF_members.mdf;Integrated Security=True;Connect Timeout=30";
        public string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\HP\\Desktop\\IOGKF\\IOGKF\\IOGKF_members.mdf;Integrated Security=True;Connect Timeout=30";

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "iOGKF_membersDataSet.Members". При необходимости она может быть перемещена или удалена.
            this.membersTableAdapter.Fill(this.iOGKF_membersDataSet.Members);
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Members", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            //FillMembers();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "iOGKF_membersDataSet.Members". При необходимости она может быть перемещена или удалена.
            //this.membersTableAdapter.Fill(this.iOGKF_membersDataSet.Members);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            Form6 form6 = new Form6();
            form6.ShowDialog();
            //dataGridView1.Update();
            //dataGridView1.Refresh();
            //string query = textBox1.Text.ToString();
            //Form6 f = new Form6();

            //SqlDataAdapter da = new SqlDataAdapter(query, conString);
            //DataSet ds = new DataSet();
            //da.Fill(ds, "[Members]");
            //f.dataGridView1.DataSource = ds.Tables["[Members]"].DefaultView;
            //f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.membersTableAdapter.Fill(this.iOGKF_membersDataSet.Members);
        }

        //private void FillMembers()
        //{
        //    string SqlText = "SELECT * FROM [Members]";
        //    SqlDataAdapter da = new SqlDataAdapter(SqlText, conString);
        //    DataSet ds = new DataSet();
        //    da.Fill(ds, "[Members]");
        //    dataGridView1.DataSource = ds.Tables["[Members]"].DefaultView;
        //}
    }
}
