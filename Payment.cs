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
            MemberGrid.DataSource = ds.Tables[0];
            MemberGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MemberGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MemberGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            conn.Close();
        }
        private void Payment_Load(object sender, EventArgs e)
        {
            FetchString();
            DTP.Format = DateTimePickerFormat.Custom;
            DTP.CustomFormat = "dd-MM-yyyy";
            populate();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn ẩn giao diện hiện tại và quay lại giao diện chính?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                FormMain formMain = new FormMain();
                formMain.Show();
            }
        }
        private void label10_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult result = System.Windows.Forms.MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận thoát", System.Windows.Forms.MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
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
                    if (Amount < 0 || Amount > 999999999)
                    {
                        throw new Exception("Số tiền không thể lớn hơn 999.999.999 và không thể âm");
                    }
                    bool checkID = int.TryParse(txtID.Text, out int ID);
                    if (checkID != true)
                    {
                        throw new Exception("ID không hợp lệ. Nó phải chỉ có 1 chữ số.");
                    }

                    string Payperiod = DTP.Value.Month.ToString() + DTP.Value.Year.ToString();
                    conn.Open();
                    // Kiểm tra xem ID có tồn tại trong bảng Member hay không
                    string checkMemberQuery = "SELECT COUNT(*) FROM Member WHERE MemID = @MemID";
                    SqlCommand checkMemberCmd = new SqlCommand(checkMemberQuery, conn);
                    checkMemberCmd.Parameters.AddWithValue("@MemID", txtID.Text);
                    int memberCount = (int)checkMemberCmd.ExecuteScalar();

                    if (memberCount == 0)
                    {
                        conn.Close();
                        MessageBox.Show("Mã thành viên không tồn tại.");
                    }
                    else
                    {
                        // Kiểm tra xem đã thanh toán tháng này chưa
                        string checkQuery = "SELECT COUNT(*) FROM Payment WHERE MemID = @MemID AND Date = @Date";
                        SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                        checkCmd.Parameters.AddWithValue("@MemID", txtID.Text);
                        checkCmd.Parameters.AddWithValue("@Date", Payperiod);
                        int paymentCount = (int)checkCmd.ExecuteScalar();

                        if (paymentCount == 1)
                        {
                            conn.Close();
                            MessageBox.Show("Đã thanh toán tháng này.");
                        }
                        else
                        {
                            MessageBoxButtons messageBoxButtons = MessageBoxButtons.YesNo;
                            string info = string.Format("ID: {0}\nSố tiền: {1}\nThông tin này có chính xác không?", txtID.Text, txtAmount.Text);
                            DialogResult result = MessageBox.Show(info, "Kiểm tra thông tin", messageBoxButtons);

                            if (result == DialogResult.Yes)
                            {
                                // Thực hiện chèn dữ liệu vào bảng Payment
                                string insertQuery = "INSERT INTO Payment (MemID, Date, Amount) VALUES (@MemID, @Date, @Amount)";
                                SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                                insertCmd.Parameters.AddWithValue("@MemID", txtID.Text);
                                insertCmd.Parameters.AddWithValue("@Date", Payperiod);
                                insertCmd.Parameters.AddWithValue("@Amount", txtAmount.Text);

                                insertCmd.ExecuteNonQuery();
                                MessageBox.Show("Số tiền thanh toán thành công.");
                            }
                            conn.Close();
                        }
                        populate();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Payment_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((Control.ModifierKeys & Keys.Alt) != 0 && e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // Thoát chương trình ngay lập tức
                    Environment.Exit(0);
                }
                else
                {
                    // Chặn đóng Form
                    e.Cancel = true;
                }
            }
        }
    }
}

