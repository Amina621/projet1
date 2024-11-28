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
        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-4GIP9VN\\SQLEXPRESS;Initial Catalog=MobileStore;Integrated Security=True");

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void populate()
        {
            Con.Open();
            String query = "select * from MobileTb ";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds =  new DataSet();
            da.Fill(ds);
            MobileDGV.DataSource = ds.Tables[0];
            Con.Close();

        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (idtb.Text == "")
            {
                MessageBox.Show("Entrer The mobile to be Deleted");
            }
            else
            {
                try
                {
                    Con.Open();
                    String query = "delete from MobileTb where Mobid=" + idtb.Text + "";
                    SqlCommand cmd = new SqlCommand(query,Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Mobile Deleted");
                    Con.Close();
                    populate();
                }catch(Exception Ex)
                {

                }
            }
        }

        private void Mobile_Load(object sender, EventArgs e)
        {
            populate();
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
                    Con.Open();
                    String sql = "insert into MobileTb values('" + brandtb.Text + "','" + modeletb.Text + "'," + int.Parse(pricetb.Text )+ "," + int.Parse(stocktb.Text )+ "," +int.Parse( romcb.SelectedItem.ToString()) + "," +int.Parse(ramcb.SelectedItem.ToString())+","+int.Parse(cameratb.Text)+")";


                    SqlCommand cmd = new SqlCommand(sql,Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Mobile Added Successfully");

                    Con.Close();
                    populate();

                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idtb.Text = MobileDGV.SelectedRows[0].Cells[0].Value.ToString();
            brandtb.Text = MobileDGV.SelectedRows[0].Cells[1].Value.ToString();
            modeletb.Text = MobileDGV.SelectedRows[0].Cells[2].Value.ToString();
            pricetb.Text = MobileDGV.SelectedRows[0].Cells[3].Value.ToString();
            stocktb.Text = MobileDGV.SelectedRows[0].Cells[4].Value.ToString();
            romcb.SelectedItem = MobileDGV.SelectedRows[0].Cells[5].Value.ToString();
            ramcb.SelectedItem = MobileDGV.SelectedRows[0].Cells[6].Value.ToString();
            cameratb.Text = MobileDGV.SelectedRows[0].Cells[7].Value.ToString();




        }

        private void button4_Click(object sender, EventArgs e)
        {
            idtb.Text = "";
            brandtb.Text = "";
            modeletb.Text = "";
            pricetb.Text = "";
            stocktb.Text = "";
            cameratb.Text = "";



        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (idtb.Text == "" || brandtb.Text == "" || modeletb.Text == "" || pricetb.Text == "" || stocktb.Text == "" || cameratb.Text == "")
            {
                MessageBox.Show("Missing Information");

            }
            else
            {
                try
                {
                    Con.Open();
                    String sql = "update MobileTb set Mobbrand='"+brandtb.Text+"',Mobmodele='"+modeletb.Text+"',Mobprice="+pricetb.Text+",Mobstock="+stocktb.Text+",MRam="+ramcb.SelectedItem.ToString()+",MRom="+romcb.SelectedItem.ToString()+",MCamera="+cameratb.Text+" where Mobid="+idtb.Text+"";


                    SqlCommand cmd = new SqlCommand(sql, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Mobile Updated Successfully");

                    Con.Close();
                    populate();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }
    }
}
