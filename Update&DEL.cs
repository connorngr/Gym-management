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
    public partial class Update_DEL : Form
    {
        public Update_DEL()
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
        private void Populate()
        {
            conn.Open();
            string query = "select * from Member";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            var ds = new DataSet();
            adapter.Fill(ds);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count == 0)
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
        private void label8_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult result = System.Windows.Forms.MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận thoát", System.Windows.Forms.MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void Update_DEL_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
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

        private void Update_DEL_Load(object sender, EventArgs e)
        {
            FetchString();
            Populate();
        }
        int key = -1;
        private void MemberGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < MemberGrid.Rows.Count)
            {
                key = int.Parse(MemberGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtName.Text = MemberGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPhone.Text = MemberGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                cmbGender.Text = MemberGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtAge.Text = MemberGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (key == -1)
            {
                MessageBox.Show("Select member to delete");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this member?\n\n" +
                                        "Information to be deleted:\n" +
                                        "- Member Name: " + txtName.Text + "\n" +
                                        "- Member Phone: " + txtPhone.Text + "\n" +
                                        "- Member Gender: " + cmbGender.Text + "\n" +
                                        "- Member Age: " + txtAge.Text + "\n" +
                                        "- Payments associated with the member", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        conn.Open();
                        string check = "delete from Payment where MemID=" + key + " ;";
                        SqlCommand cmd = new SqlCommand(check, conn);
                        cmd.ExecuteNonQuery();
                        string query = "delete from Member where MemID=" + key + ";";
                        cmd = new SqlCommand(query, conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Member deleted successfully");
                        conn.Close();
                        Populate();
                        key = -1;
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
           
            if (key == -1 || txtName.Text == "" || txtPhone.Text == "" || txtAge.Text == "")
            {
                MessageBox.Show("Select member to update");
            }
            else
            {
                try
                {
                    if (txtPhone.Text.Length < 10 || txtPhone.Text.Length > 13)
                    {
                        throw new Exception("Check your phone number again");
                    }
                    bool checkAge = int.TryParse(txtAge.Text, out int age);
                    if (checkAge != true)
                    {
                        throw new Exception("Invalid age");
                    }
                    if (int.Parse(txtAge.Text) <= 0 || int.Parse(txtAge.Text) > 100)
                    {
                        throw new Exception("Invalid age");
                    }
                    if (txtName.Text.Length > 50)
                    {
                        throw new Exception("Tên không hợp lệ. Vui lòng nhập dưới 50 ký tự.");
                    }
                    if (cmbGender.Text != "Male" && cmbGender.Text != "Female")
                    {
                        throw new Exception("Invalid gender.");
                    }
                    conn.Open();
                    string message = $"Are you sure you want to update the member with the following details?\n\nName: {txtName.Text}\nPhone: {txtPhone.Text}\nGender: {cmbGender.Text}\nAge: {txtAge.Text}";
                    DialogResult result = MessageBox.Show(message, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        string query = "update Member set Name='" + txtName.Text + "', Phone='" + txtPhone.Text + "'," +
                        " Gender='" + cmbGender.Text + "', Age='" + txtAge.Text + "' where MemID=" + key + ";";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Member updated successfully");
                        conn.Close();
                        Populate();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
            }
        }

        
    }
}
