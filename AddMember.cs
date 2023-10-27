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

namespace Gym_management
{
    public partial class AddMember : Form
    {
        public AddMember()
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
        private void label8_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult result = System.Windows.Forms.MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận thoát", System.Windows.Forms.MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void Blank_TextBox()
        {
            txtAge.Text = string.Empty;
            txtName.Text = string.Empty;
            cmbGender.Text = string.Empty;
            txtPhone.Text = string.Empty;
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text==""||txtPhone.Text==""||txtAge.Text=="")
            {
                MessageBox.Show("Thiếu thông tin", "Cảnh báo");
            }
            else
            {
                try
                {
                    if (txtPhone.Text.Length<10 || txtPhone.Text.Length>13)
                    {
                        throw new Exception("Số điện thoại phải từ 10 đến 13 số. Vui lòng nhập lại!");
                    }
                    bool checkAge = int.TryParse(txtAge.Text, out int age);
                    if (checkAge!=true)
                    {
                        throw new Exception("Tuổi không hợp lệ");
                    }
                    if (int.Parse(txtAge.Text)<=0 || int.Parse(txtAge.Text) > 100)
                    {
                        throw new Exception("Tuổi không hợp lệ");
                    }
                    if (txtName.Text.Length > 50)
                    {
                        throw new Exception("Tên không hợp lệ. Vui lòng nhập dưới 50 ký tự.");
                    }
                    if (cmbGender.Text != "Nam" && cmbGender.Text != "Nữ" )
                    {
                        throw new Exception("Giới tính chỉ nhận giá trị là 'Nam' hoặc 'Nữ'.");
                    }
                    conn.Open();
                    string query = "INSERT INTO Member (Name, Phone, Gender, Age) " +
                        "VALUES (@Name, @Phone, @Gender, @Age)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@Gender", cmbGender.Text);
                    cmd.Parameters.AddWithValue("@Age", txtAge.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành viên thành công.");
                    Blank_TextBox();
                    conn.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void AddMember_Load(object sender, EventArgs e)
        {
            cmbGender.SelectedIndex = 0;
            FetchString();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            Blank_TextBox();
            MessageBox.Show("Xóa tất cả thông tin thành công!", "Thông báo");
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

        private void AddMember_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((Control.ModifierKeys & Keys.Alt) != 0 && e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // Thoát chương trình
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
