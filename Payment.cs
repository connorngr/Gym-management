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
            SqlDataAdapter sda = new SqlDataAdapter("select * from PaymentTbl where PPhone='" + searchPhone.Text + "'", Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            dgvPayment.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void populate()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from PaymentTbl", Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            dgvPayment.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Payment_Load(object sender, EventArgs e)
        {
            FillNum();
            populate();
        }
        private void numcb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void butPayment_Click(object sender, EventArgs e)
        {
            if (numcb != null && numcb.SelectedValue != null)
            {
                // Tiếp tục thực hiện câu truy vấn
                if (numcb.Text == "" || amounttb.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                }
                else
                {
                    string payperiode = Periode.Value.Month.ToString() + Periode.Value.Year.ToString();

                    if (Con != null)
                    {
                        Con.Open();
                        // Tiếp tục thực hiện câu truy vấn
                        SqlDataAdapter sda = new SqlDataAdapter("select count(*) from PaymentTbl where PPhone='" + numcb.SelectedValue.ToString() + "' and PMonth='" + payperiode + "'", Con);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        if (Convert.ToInt32(dt.Rows[0][0]) == 1)
                        {
                            MessageBox.Show("Đã thanh toán tháng này.");
                        }
                        else
                        {
                            string query = "insert into PaymentTbl values('" + payperiode + "','" + numcb.SelectedValue.ToString() + "','" + amounttb.Text + "')";
                            SqlCommand cmd = new SqlCommand(query, Con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Số tiền thanh toán thành công.");
                        }
                        Con.Close();
                        populate();
                    }
                    else
                    {
                        MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu.");
                        return;
                    }

                }
            }
        }

        private void butRefresh_Click(object sender, EventArgs e)
        {
            numcb.Text = "";
            amounttb.Text = "";
        }

        private void butExitOfpayment_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void butFind_Click(object sender, EventArgs e)
        {
            FillterByPhone();
            searchPhone.Text = "";
        }

        private void butShowAll_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void labExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
