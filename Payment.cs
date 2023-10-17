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
        SqlConnection Con = new SqlConnection(@"Data Source=CONNOR-PC;Initial Catalog=GymDB;Integrated Security=True");

        
        private void populate()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Payment.MemID as ID, " +
                "Member.Name, Member.Phone, Payment.Date, Payment.Amount from " +
                "Payment inner join Member on Payment.MemID = Member.MemID", Con);
            var ds = new DataSet();
            sda.Fill(ds);
            MemberGrid.DataSource = ds.Tables[0];
            MemberGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MemberGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Con.Close();
        }



        private void Payment_Load(object sender, EventArgs e)
        {
            DTP.Format = DateTimePickerFormat.Custom;
            DTP.CustomFormat = "dd-MM-yyyy";
            populate();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormMain fm = new FormMain();
            fm.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnPay_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtAmount.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else
            {
                string Payperiod = DTP.Value.Month.ToString() + DTP.Value.Year.ToString();
                Con.Open();
                //SqlAdapter is used to fill a dataset
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Payment where MemID = " +
                    "'" + txtID.Text + "' and Date = '" + Payperiod + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                //txtTest.Text = dt.Rows[0][0].ToString(); // Co gia tri tra ve 1, ko co gia tri tra ve 0
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Đã thanh toán tháng này.");
                }
                else
                {
                    MessageBoxButtons messageBoxButtons = MessageBoxButtons.YesNo;
                    string info = string.Format("ID: {0}\nAmount: {1}\nIs this information correct?", txtID.Text, txtAmount.Text);
                    DialogResult result = MessageBox.Show(info, "Check information", messageBoxButtons);
                    if (result == DialogResult.Yes)
                    {
                        string query = "insert into Payment values(" + txtID.Text + "," + Payperiod + "," + txtAmount.Text + ")";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        try
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Số tiền thanh toán thành công.");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("ID Not Found", "Warning");
                        }

                    }
                    //SqlCommand can be used for any purpose you have in mind
                    //related to Create / Read / Update / Delete
                                                         
                }
                Con.Close();
                populate();
            }
        }


    }
}

