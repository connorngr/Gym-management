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
            string db = Dbstring.getDB();
            conn = new SqlConnection(db);
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void Populate()
        {
            conn.Open();
            string query = "select * from Equipment";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            var ds = new DataSet();
            adapter.Fill(ds);
            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                EquipmentGrid.DataSource = ds.Tables[0];
                EquipmentGrid.Columns[0].Width = 50;
                EquipmentGrid.Columns[2].Width = 100;
                EquipmentGrid.Columns[3].Width = 100;
                EquipmentGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                EquipmentGrid.Columns[5].Width = 80;
                EquipmentGrid.Columns[6].Width = 100;
                EquipmentGrid.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            conn.Close();
        }
        private void UpdateDeleteEquipment_Load(object sender, EventArgs e)
        {
            FetchString();
            Populate();
        }

        private void labExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            FormMain formMain = new FormMain();
            formMain.Show();
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
                MessageBox.Show("Please select the ID you want to delete or click select in table");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this Equipemnt?\n\n" +
                                        "Information to be deleted:\n" +
                                        "- Equipemnt ID: " + txtID.Text + "\n" +
                                        "- Equipemnt Name: " + txtName.Text + "\n" +
                                        "- Equipemnt Quantity: " + txtQuantity.Text + "\n" +
                                        "- Equipemnt Price: " + txtPrice.Text + "\n" +
                                        "- Equipemnt Condition: " + cmbCondition.Text + "\n" +
                                        "- Equipemnt Location: " + cmbLocation.Text + "\n" +
                                        "- Payments associated with the Equipemnt", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        bool checkID = int.TryParse(txtID.Text, out int tID);
                        if (!checkID)
                        {
                            throw new Exception("ID phải là một số nguyên.");
                        }
                        conn.Open();
                        string query = "delete from Equipment where ID=" + txtID.Text + ";";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.ExecuteNonQuery();
                        if (cmd.ExecuteNonQuery() == 0)
                        {
                            MessageBox.Show("Không tồn tại ID bạn muốn xóa", "Thông báo");
                        }
                        else
                        {
                            MessageBox.Show("Equipment delete to finish");
                            Populate();
                        }
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtPrice.Text) || string.IsNullOrEmpty(txtQuantity.Text)
                || string.IsNullOrEmpty(cmbCondition.Text) || string.IsNullOrEmpty(cmbLocation.Text))
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    bool checkAmount = long.TryParse(txtPrice.Text, out long Amount);
                    if (checkAmount != true)
                    {
                        throw new Exception("Số tiền phải là số.");
                    }
                    if (Amount < 0 || Amount > 9999999999)
                    {
                        throw new Exception("Số tiền không thể lớn hơn 9.999.999.999 và không thể âm");
                    }
                    bool checkQuantity = int.TryParse(txtQuantity.Text, out int Quantity);
                    if (checkQuantity != true)
                    {
                        throw new Exception("Số lượng phải là số.");
                    }
                    if (Quantity < 0 || Quantity > 9999999999)
                    {
                        throw new Exception("Số lượng không thể lớn hơn 2.147.483.647 và không thể âm");
                    }
                    if (txtName.Text.Length > 50)
                    {
                        throw new Exception("Tên không hợp lệ. Vui lòng nhập dưới 50 ký tự.");
                    }
                    if (cmbCondition.Text != "New" && cmbCondition.Text != "Old")
                    {
                        throw new Exception("Trang thái chỉ nhận giá trị 'Old' hoặc 'New'.");
                    }
                    if (cmbLocation.Text != "shelf number 1" && cmbLocation.Text != "shelf number 2" && cmbLocation.Text != "shelf number 3")
                    {
                        throw new Exception("Vị trí chỉ nhận giá trị 'shelf number 1' hoặc 'shelf number 2' hoặc 'shelf number 3'.");
                    }
                    bool checkID = int.TryParse(txtID.Text, out int tID);
                    if (!checkID)
                    {
                        throw new Exception("ID phải là một số nguyên.");
                    }
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this Equipemnt?\n\n" +
                                        "Information to be deleted:\n" +
                                        "- Equipemnt ID: " + txtID.Text + "\n" +
                                        "- Equipemnt Name: " + txtName.Text + "\n" +
                                        "- Equipemnt Quantity: " + txtQuantity.Text + "\n" +
                                        "- Equipemnt Price: " + txtPrice.Text + "\n" +
                                        "- Equipemnt Condition: " + cmbCondition.Text + "\n" +
                                        "- Equipemnt Location: " + cmbLocation.Text + "\n" +
                                        "- Payments associated with the Equipemnt", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        conn.Open();
                        string check = "SELECT COUNT(*) FROM Equipment WHERE ID = @ID;";
                        SqlCommand checkIDCmd = new SqlCommand(check, conn);
                        checkIDCmd.Parameters.AddWithValue("@ID", txtID.Text);
                        int count = Convert.ToInt32(checkIDCmd.ExecuteScalar());
                        if (count > 0)
                        {
                            string query = "UPDATE Equipment SET Name=@Name, Price=@Price, Quantity=@Quantity, [Condition]=@Condition, Location=@Location WHERE ID=@ID;";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@Name", txtName.Text);
                            cmd.Parameters.AddWithValue("@Price", txtPrice.Text);
                            cmd.Parameters.AddWithValue("@Quantity", txtQuantity.Text);
                            cmd.Parameters.AddWithValue("@Condition", cmbCondition.Text);
                            cmd.Parameters.AddWithValue("@Location", cmbLocation.Text);
                            cmd.Parameters.AddWithValue("@ID", txtID.Text);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Member updated successfully");
                            conn.Close();
                            Populate();
                        }
                        else
                        {
                            MessageBox.Show("Không tồn tại ID trong bảng.");
                            conn.Close();
                        }
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
                if(txtSearch.Text=="")
                {
                    throw new Exception("Vui lòng nhập giá trị bán muốn tìm. nó không thể string.Empty");
                }    
                conn.Open();
                string searchText = txtSearch.Text;
                string query = "SELECT * FROM Equipment WHERE Name LIKE '%' + @SearchText + '%' OR ID LIKE '%' + @SearchText + '%';";
                SqlCommand searchCmd = new SqlCommand(query, conn);
                searchCmd.Parameters.AddWithValue("@SearchText", searchText);

                SqlDataReader reader = searchCmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu bạn nhập để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                EquipmentGrid.DataSource = dataTable;
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
