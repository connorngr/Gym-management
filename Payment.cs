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
using System.Data.Common;

namespace Gym_management
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }
        
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\GymDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void FillNum()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select MPhone from MemberTbl", Con);
            SqlDataReader rdr;
            //ExecuteReader
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("MPhone", typeof(string));
            dt.Load(rdr);
            numcb.ValueMember = "MPhone";
            numcb.DataSource = dt;
            Con.Close();
        }
        private void FillterByPhone()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from PaymentTbl where PPhone='"+searchPhone.Text+"'", Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            dgvPayment.DataSource = ds.Tables[0];

            Con.Close();
        }
        private void populate()
        {
            Con.Open();
            SqlDataAdapter sda=new SqlDataAdapter("select * from PaymentTbl",Con);
            SqlCommandBuilder builder= new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            dgvPayment.DataSource = ds.Tables[0];

            Con.Close();
        }
        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            numcb.Text = "";
            amounttb.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormMain fm=new FormMain();
            fm.Show();
            this.Hide();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            FillNum();
            populate();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(numcb.Text=="" || amounttb.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else
            {
                string payperiode=Periode.Value.Month.ToString() + Periode.Value.Year.ToString();
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from PaymentTbl where PPhone='"+numcb.SelectedValue.ToString()+"' and PMonth='"+payperiode+"'",Con);
                DataTable dt=new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString()=="1")
                {
                    MessageBox.Show("Đã thanh toán tháng này.");
                }
                else
                {
                    string query = "insert into PaymentTbl values('" + payperiode + "','" + numcb.SelectedValue.ToString() + "','" + amounttb.Text + "')";
                    SqlCommand cmd= new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Số tiền thanh toán thành công.");
                }
                Con.Close();
                populate();
            }
        }

        private void numcb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FillterByPhone();
            searchPhone.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}
