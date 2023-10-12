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
        private bool bIsButtonClicked;
        private object _threadProcessCCTV;

        public static string Avatar { get; private set; }

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
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
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
            Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFullName.Text == "" || txtAge.Text == ""  || txtSdt.Text == "")
                    throw new Exception("Vui lòng nhập đủ thông tin !");
                

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

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            string imagePath = "";

            try
            {
                OpenFileDialog fileOpen = new OpenFileDialog();
                fileOpen.Title = "Chọn hình ảnh sinh viên";
                fileOpen.Filter = "Hình ảnh (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png|All files (*,*)|*.*";
                if (fileOpen.ShowDialog() == DialogResult.OK)
                {
                    imagePath = fileOpen.FileName;
                    AddMember.Avatar = imagePath;
                    picture1.Image = Image.FromFile(imagePath);
                    picture1.Refresh();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi không thể upload ảnh!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void AddMember_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (e.CloseReason == CloseReason.UserClosing)
            {
                dynamic result = MessageBox.Show("Bạn có chắc muốn thoát?", "Thông Báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void AddMember_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void txtEmail1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Tên chỉ có thể nhập chữ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Số điện thoại chỉ được phép nhập số", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Tuổi chỉ được phép nhập số", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
