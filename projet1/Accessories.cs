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
using System.Data.SqlClient;

namespace projet1
{
    public partial class Accessories : Form
    {
        public Accessories()
        {
            InitializeComponent();

        }
        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-4GIP9VN\\SQLEXPRESS;Initial Catalog=MobileStore;Integrated Security=True");

        private void populate()
        {
            Con.Open();
            String query = "select * from AccessoireTb ";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            AccessorieDGV.DataSource = ds.Tables[0];
            Con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Aid.Text == "" || Abrand.Text == "" || Amodele.Text == "" || Aprice.Text == "" || Astock.Text == "" )
            {
                MessageBox.Show("Missing Information");

            }
            else
            {
                try
                {
                    Con.Open();
                    String sql = "insert into AccessoireTb values('" +Abrand .Text + "','" + Amodele.Text + "'," + Aprice.Text + "," + Astock.Text + ")";


                    SqlCommand cmd = new SqlCommand(sql, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Accessorie Added Successfully");

                    Con.Close();
                    populate();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void Accessories_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Aid.Text = "";
            Abrand.Text = "";
            Amodele.Text = "";
            Aprice.Text = "";
            Astock.Text = "";
           

        }

        private void AccessorieDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Aid.Text = AccessorieDGV.SelectedRows[0].Cells[0].Value.ToString();
            Abrand.Text = AccessorieDGV.SelectedRows[0].Cells[1].Value.ToString();
            Amodele.Text = AccessorieDGV.SelectedRows[0].Cells[2].Value.ToString();
            Aprice.Text = AccessorieDGV.SelectedRows[0].Cells[3].Value.ToString();
            Astock.Text = AccessorieDGV.SelectedRows[0].Cells[4].Value.ToString();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Aid.Text == "")
            {
                MessageBox.Show("Entrer The mobile to be Deleted");
            }
            else
            {
                try
                {
                    Con.Open();
                    String query = "delete from AccessoireTb where idacces=" + Aid.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Accessorie Deleted");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (Aid.Text == "" || Abrand.Text == "" || Amodele.Text == "" || Aprice.Text == "" || Astock.Text == "")
            {
                MessageBox.Show("Missing Information");

            }
            else
            {
                try
                {
                    Con.Open();
                    String sql = "update AccessoireTb set brandacces='" + Abrand.Text + "',modeleacces='" + Amodele.Text + "',priceacces=" + Aprice.Text + ",stockacces=" + Astock.Text +  " where idacces=" + Aid.Text + "";


                    SqlCommand cmd = new SqlCommand(sql, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Accessorie Updated Successfully");

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
    

