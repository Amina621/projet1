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
using System.Diagnostics;

namespace projet1
{
    public partial class Selling : Form
    {
        public Selling()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-4GIP9VN\\SQLEXPRESS;Initial Catalog=MobileStore;Integrated Security=True");


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
            var ds = new DataSet();
            da.Fill(ds);
            MobileDGV.DataSource = ds.Tables[0];
            Con.Close();

        }


        private void populateAccess()
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

        private void Selling_Load(object sender, EventArgs e)
        {
            populate();
            populateAccess();
        }

        private void MobileDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            productTb.Text = MobileDGV.SelectedRows[0].Cells[0].Value.ToString() + MobileDGV.SelectedRows[0].Cells[1].Value.ToString();
            priceTb.Text = MobileDGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void AccessorieDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            productTb.Text = AccessorieDGV.SelectedRows[0].Cells[0].Value.ToString() + AccessorieDGV.SelectedRows[0].Cells[1].Value.ToString();
            priceTb.Text = AccessorieDGV.SelectedRows[0].Cells[2].Value.ToString();
        }
        int n = 0, Grdtotal=0;

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("MOBISOFT 1.0",new Font("Century Gothic",12,FontStyle.Bold),Brushes.Red,new Point(80));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
            if(printPreviewDialog1.ShowDialog()== DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (QuantityTb.Text == "" || priceTb.Text=="")
            {
                MessageBox.Show("Enter The Quantity");
            }
            else
            {
                int total = Convert.ToInt32(QuantityTb.Text) * Convert.ToInt32(priceTb.Text);
               
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(BillDGV);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = productTb.Text;
                newRow.Cells[2].Value = priceTb.Text;
                newRow.Cells[3].Value = QuantityTb.Text;
                newRow.Cells[4].Value = total;
                BillDGV.Rows.Add(newRow);
                n++;
                Grdtotal = Grdtotal + total;
                Amounttb.Text = ""+Grdtotal;

            }
        }
    }
}
