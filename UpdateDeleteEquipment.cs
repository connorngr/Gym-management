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
    public partial class UpdateDeleteEquipment : Form
    {
        public UpdateDeleteEquipment()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection();
        public void FetchString()
        {
            DBString Dbstring = new DBString();
            // Lấy chuỗi kết nối CSDL
            string db = Dbstring.getDB();
            conn = new SqlConnection(db);
        }
        private void Populate()
        {
            conn.Open();
            string query = "select * from Equipment";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            var ds = new DataSet();
            adapter.Fill(ds);
            EquipmentGrid.DataSource = ds.Tables[0];
            EquipmentGrid.Columns[0].Width = 50;
            EquipmentGrid.Columns[2].Width = 100;
            EquipmentGrid.Columns[3].Width = 100;
            EquipmentGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            EquipmentGrid.Columns[5].Width = 100;
            EquipmentGrid.Columns[6].Width = 100;
            EquipmentGrid.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            conn.Close();
        }
        private void UpdateDeleteEquipment_Load(object sender, EventArgs e)
        {
            
            FetchString();
            Populate();
        }
        private void labExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult result = System.Windows.Forms.MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận thoát", System.Windows.Forms.MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
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
        private void EquipmentGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < EquipmentGrid.Rows.Count)
            {
                txtID.Text = EquipmentGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtName.Text = EquipmentGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtQuantity.Text = EquipmentGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtPrice.Text = EquipmentGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                cmbCondition.Text = EquipmentGrid.Rows[e.RowIndex].Cells[6].Value.ToString();
                cmbLocation.Text = EquipmentGrid.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
        }

        private void butRefresh_Click(object sender, EventArgs e)
        {
            txtID.Text = string.Empty;
            txtName.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            cmbCondition.Text = string.Empty;
            cmbLocation.Text = string.Empty;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Vui lòng chọn mã thiết bị bạn muốn xóa hoặc nhấp chuột 2 lần vào dòng trong bảng và xóa.");
            }
            else
            {
                try
                {
                    
                    if (!int.TryParse(txtID.Text, out int tID))
                    {
                        throw new Exception("Mã thiết bị bạn nhập sai.");
                    }
                    // Kiểm tra sự tồn tại của ID trong cơ sở dữ liệu
                    conn.Open();
                    string checkQuery = "SELECT COUNT(*) FROM Equipment WHERE ID = @ID";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@ID", txtID.Text);
                    int count = (int)checkCmd.ExecuteScalar();
                    conn.Close();

                    if (count == 0)
                    {
                        MessageBox.Show("Mã thiết bị bạn muốn xóa không tồn tại.", "Thông báo");
                    }
                    else
                    {
                        // Xác nhận việc xóa
                        DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa thiết bị này?\n\n" +
                                     "Thông tin sẽ bị xóa:\n" +
                                     "- Mã thiết bị: " + txtID.Text + "\n" +
                                     "- Tên thiết bị: " + txtName.Text + "\n" +
                                     "- Số lượng thiết bị: " + txtQuantity.Text + "\n" +
                                     "- Giá thiết bị: " + txtPrice.Text + "\n" +
                                     "- Tình trạng thiết bị: " + cmbCondition.Text + "\n" +
                                     "- Vị trí thiết bị: " + cmbLocation.Text + "\n" +
                                     "- Bạn có chắc muốn xóa thiết bị", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            conn.Open();
                            string deleteQuery = "DELETE FROM Equipment WHERE ID = @ID";
                            SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn);
                            deleteCmd.Parameters.AddWithValue("@ID", txtID.Text);
                            int rowsAffected = deleteCmd.ExecuteNonQuery();
                            conn.Close();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Xóa thiết bị thành công.");
                                Populate();
                            }
                            else
                            {
                                MessageBox.Show("Có lỗi xảy ra trong quá trình xóa.", "Thông báo");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    
                }
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtPrice.Text) || string.IsNullOrEmpty(txtQuantity.Text)
                || string.IsNullOrEmpty(cmbCondition.Text) || string.IsNullOrEmpty(cmbLocation.Text))
            {
                MessageBox.Show("Nhập thiếu thông tin. Vui lòng nhập lại!");
            }
            else
            {
                try
                {
                    
                    // Mã thiết bị phải kiểu int
                    bool checkID = int.TryParse(txtID.Text, out int tID);
                    if (!checkID)
                    {
                        throw new Exception("Mã thiết bị bạn nhập sai hoặc có thể sử dụng tìm kiếm theo tên để biết mã của nó.");
                    }

                    // Truy vấn xem ID có trong bảng không
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Equipment WHERE ID = @ID;";
                    SqlCommand checkIDCmd = new SqlCommand(query, conn);
                    checkIDCmd.Parameters.AddWithValue("@ID", tID);
                    int count = Convert.ToInt32(checkIDCmd.ExecuteScalar());
                    conn.Close();
                    if (count > 0)
                    {
                        // Tên thiết bị
                        if (txtName.Text.Length > 50)
                        {
                            throw new Exception("Tên không hợp lệ. Vui lòng nhập dưới 50 ký tự.");
                        }
                        // Vị trí
                        if (cmbCondition.Text != "Mới" && cmbCondition.Text != "Cũ")
                        {
                            throw new Exception("Trang thái chỉ nhận giá trị 'Mới' hoặc 'Cũ'.");
                        }
                        // Trạng thái
                        if (cmbLocation.Text != "Khu vực a" && cmbLocation.Text != "Khu vực b" && cmbLocation.Text != "Khu vực c")
                        {
                            throw new Exception("Vị trí chỉ nhận giá trị 'Khu vực a' hoặc 'Khu vực b' hoặc 'Khu vực c'.");
                        }
                        // Số lượng
                        bool checkQuantity = int.TryParse(txtQuantity.Text, out int Quantity);
                        if (checkQuantity != true)
                        {
                            throw new Exception("Số lượng phải là số và không có kí tự đặt biệt như '.'.");
                        }
                        if (Quantity < 0 || Quantity > 999999999)
                        {
                            throw new Exception("Số lượng không thể lớn hơn 999.999.999 và không thể âm");
                        }
                        // Số tiền
                        bool checkAmount = long.TryParse(txtPrice.Text, out long Amount);
                        if (checkAmount != true)
                        {
                            throw new Exception("Số tiền phải là số và không có kí tự đặt biệt như '.'.");
                        }
                        if (Amount < 0 || Amount > 999999999)
                        {
                            throw new Exception("Số tiền không thể lớn hơn 999.999.999 và không thể âm");
                        }
                        DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa thiết bị này?\n\n" +
                                                                "Thông tin sẽ bị xóa:\n" +
                                                                "- ID thiết bị: " + txtID.Text + "\n" +
                                                                "- Tên thiết bị: " + txtName.Text + "\n" +
                                                                "- Số lượng thiết bị: " + txtQuantity.Text + "\n" +
                                                                "- Giá thiết bị: " + txtPrice.Text + "\n" +
                                                                "- Tình trạng thiết bị: " + cmbCondition.Text + "\n" +
                                                                "- Vị trí thiết bị: " + cmbLocation.Text + "\n" +
                                                                "- Các thanh toán liên quan đến thiết bị", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            conn.Open();
                            query = "UPDATE Equipment SET Name=@Name, Price=@Price, Quantity=@Quantity, [Condition]=@Condition, Location=@Location WHERE ID=@ID;";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@Name", txtName.Text);
                            cmd.Parameters.AddWithValue("@Price", txtPrice.Text);
                            cmd.Parameters.AddWithValue("@Quantity", txtQuantity.Text);
                            cmd.Parameters.AddWithValue("@Condition", cmbCondition.Text);
                            cmd.Parameters.AddWithValue("@Location", cmbLocation.Text);
                            cmd.Parameters.AddWithValue("@ID", txtID.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Cập nhật thiết bị thành công");
                            conn.Close();
                            Populate();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tồn tại mã thiết bị này trong bảng.");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            Populate();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (txtSearch.Text=="")
                {
                    throw new Exception("Vui lòng nhập giá trị bán muốn tìm. Nó không thể rỗng");
                }
                conn.Open();
                string searchText = txtSearch.Text;
                string query = "SELECT * FROM Equipment WHERE Name LIKE '%' + @SearchText + '%' OR ID LIKE '%' + @SearchText + '%';";
                SqlCommand searchCmd = new SqlCommand(query, conn);
                searchCmd.Parameters.AddWithValue("@SearchText", searchText);

                SqlDataReader reader = searchCmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                EquipmentGrid.DataSource = dataTable;
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void UpdateDeleteEquipment_FormClosing(object sender, FormClosingEventArgs e)
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
