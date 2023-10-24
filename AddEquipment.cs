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
    public partial class AddEquipment : Form
    {
        public AddEquipment()
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

        private void Equipment_Load(object sender, EventArgs e)
        {
            cmbCondition.Text = string.Empty;
            cmbLocation.Text = string.Empty;
            DTP.Format = DateTimePickerFormat.Custom;
            DTP.CustomFormat = "dd-MM-yyyy";
            FetchString();
        }
        private void Blank_TextBox()
        {
            txtName.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtManufacturer.Text = string.Empty;
            cmbCondition.Text = string.Empty;
            cmbLocation.Text = string.Empty;
        }

        private void labExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult result = System.Windows.Forms.MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận thoát", System.Windows.Forms.MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void AddEquipment_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F4)
            {
                System.Windows.Forms.DialogResult result = System.Windows.Forms.MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận thoát", System.Windows.Forms.MessageBoxButtons.YesNo);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            Blank_TextBox();
            MessageBox.Show("Clear all information succesfully!", "Notification");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn ẩn Form hiện tại và quay lại Form Main?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                FormMain formMain = new FormMain();
                formMain.Show();
            }
        }
        
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string Payperiod = DTP.Value.Day.ToString() + DTP.Value.Month.ToString() + DTP.Value.Year.ToString();
            int price = -1;
            if (txtName.Text == "" || txtQuantity.Text == "" || txtPrice.Text=="" || 
                txtManufacturer.Text=="" || string.IsNullOrEmpty(cmbCondition.Text) || string.IsNullOrEmpty(cmbLocation.Text))
            {
                MessageBox.Show("Missing information", "Warning");
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
                    if (Quantity < 0 || Quantity > 2147483647)
                    {
                        throw new Exception("Số lượng không thể lớn hơn 2.147.483.647 và không thể âm");
                    }
                    if (txtName.Text.Length > 50)
                    {
                        throw new Exception("Tên không hợp lệ. Vui lòng nhập dưới 50 ký tự.");
                    }
                    if (txtManufacturer.Text.Length > 50)
                    {
                        throw new Exception("Tên nhà sản xuất không hợp lệ. Vui lòng nhập dưới 50 ký tự.");
                    }
                    if (cmbCondition.Text != "New" && cmbCondition.Text != "Old")
                    {
                        throw new Exception("Trang thái chỉ nhận giá trị 'Old' hoặc 'New'.");
                    }
                    if (cmbLocation.Text != "shelf number 1" && cmbLocation.Text != "shelf number 2" && cmbLocation.Text != "shelf number 3")
                    {
                        throw new Exception("Vị trí chỉ nhận giá trị 'shelf number 1' hoặc 'shelf number 2' hoặc 'shelf number 3'.");
                    }
                    conn.Open();
                    string query = "insert into Equipment values('" + txtName.Text + "'," + "'" + txtQuantity.Text + "'," +
                        " '" + txtPrice.Text + "'," +" " + "'" + txtManufacturer.Text + "'," + "'" + Payperiod + "'" +
                        "," + "'" + cmbCondition.Text + "'," + "'" + cmbLocation.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Equipment successfully added");
                    Blank_TextBox();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void AddEquipment_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        
    }
}
