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
using System.Xml.Linq;

namespace Gym_management
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection();
        public void FetchString()
        {
            DBString Dbstring = new DBString();
            string db = Dbstring.getDB();
            conn = new SqlConnection(db);
        }

        private void populate()
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Payment.MemID as ID, " +
                "Member.Name, Member.Phone, Payment.Date, Payment.Amount from " +
                "Payment inner join Member on Payment.MemID = Member.MemID", conn);
            var ds = new DataSet();
            sda.Fill(ds);
            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MemberGrid.DataSource = ds.Tables[0];
                MemberGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                MemberGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            conn.Close();
        }
        private void Payment_Load(object sender, EventArgs e)
        {
            FetchString();
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
                try
                {
                    bool checkAmount = long.TryParse(txtAmount.Text, out long Amount);
                    if (checkAmount != true)
                    {
                        throw new Exception("Số tiền phải là số.");
                    }
                    if (Amount<0 || Amount>9999999999)
                    {
                        throw new Exception("Số tiền không thể lớn hơn 9.999.999.999 và không thể âm");
                    }
                    bool checkID = int.TryParse(txtID.Text, out int ID);
                    if (checkID != true)
                    {
                        throw new Exception("Invalid ID.It should be 1 figure");
                    }
                
                string Payperiod = DTP.Value.Month.ToString() + DTP.Value.Year.ToString();
                conn.Open();
                //SqlAdapter is used to fill a dataset
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Payment where MemID = " +
                    "'" + txtID.Text + "' and Date = '" + Payperiod + "'", conn);
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
                        SqlCommand cmd = new SqlCommand(query, conn);
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
                conn.Close();
                populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


    }
}

