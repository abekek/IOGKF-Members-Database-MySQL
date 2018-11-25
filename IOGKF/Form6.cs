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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        public string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\HP\\Desktop\\IOGKF\\IOGKF\\IOGKF_members.mdf;Integrated Security=True;Connect Timeout=30";
        //public string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Alibek\\Desktop\\IOGKF\\IOGKF\\IOGKF_members.mdf;Integrated Security=True;Connect Timeout=30";

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "iOGKF_membersDataSet.Members". При необходимости она может быть перемещена или удалена.
            this.membersTableAdapter.Fill(this.iOGKF_membersDataSet.Members);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string SqlText;

            SqlText = "SELECT " + textBox1.Text.ToString() + " FROM Members WHERE " + textBox2.Text.ToString() + " ORDER BY " + textBox3.Text.ToString();

            SqlDataAdapter da = new SqlDataAdapter(SqlText, conString);
            DataSet ds = new DataSet();
            da.Fill(ds, "[Members]");

            dataGridView1.DataSource = ds.Tables["[Members]"].DefaultView;
        }
    }
}
