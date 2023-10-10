using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_management
{
    public partial class AddMember : Form
    {
        public delegate void PassControl(object sender);

        // Create instance (null)
        public PassControl passControl;
        public AddMember()
        {
            InitializeComponent();
        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomTextbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Tên chỉ có thể nhập chữ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddMember_Load(object sender, EventArgs e)
        {
            rbFemale.Checked = true;    

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Số điện thoại chỉ được phép nhập số", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn huỷ đăng kí thành viên ?", "Thông báo", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
                Application.Exit();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFullName.Text == "" || txtAddress.Text == "" || txtEmail.Text == "" || txtSdt.Text == "")
                    throw new Exception("Vui lòng nhập đủ thông tin !");
                if (txtSdt.TextLength < 10)
                    throw new Exception("Số điện thoại không hợp lệ");
                
                if (!(txtFullName.TextLength > 3 && txtFullName.TextLength < 100))
                    throw new Exception("Tên quá dài hoặc quá ngắn");
                if (!txtEmail.Text.Contains("@gmail.com"))
                    throw new Exception("Sai dinh dang email");

                if (passControl != null)
                {
                    passControl(txtFullName);
                    passControl(txtSdt);
                    
                }
                this.Hide();
                MessageBox.Show("Thêm một khách hàng mới thành công", "Thông báo", MessageBoxButtons.OK);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
