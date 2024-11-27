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

namespace projet1
{
    public partial class Mobile : Form
    {
        public Mobile()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4GIP9VN\SQLEXPRESS;Initial Catalog=MobileStore;Integrated Security=True;Trust Server Certificate=True");

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Mobile_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(idtb.Text=="" || brandtb.Text=="" || modeletb.Text=="" ||pricetb.Text=="" || stocktb.Text=="" || cameratb.Text=="")
            {
                MessageBox.Show("Missing Information");
                
            }
            else
            {
                try
                {

                }catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
