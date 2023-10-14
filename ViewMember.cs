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
    public partial class ViewMember : Form
    {
        public ViewMember()
        {
            InitializeComponent();
            this.MaximizeBox = false; //Vô hiệu hoá chức năng mở rộng của form
        }

        private void ViewMember_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string phoneNumber = txtSearch.Text;
            // Kiểm tra xem có nhập đúng từ 0-9 không
            bool isValid = System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, "^[0-9]+$");
            if (isValid)
            {              
                //Hàm xử lý "TÌM KIẾM"               
            }
            else
            {
                MessageBox.Show("Vui lòng nhập thông tin và chỉ nhập số điện thoại.");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn làm mới", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                //Đặt giá trị tìm kiếm về ban đầu
                txtSearch.Text ="";
            }           
        }

        private void ViewMember_FormClosing(object sender, FormClosingEventArgs e) //Luôn hiển thị hộp thoại xác nhận khi đóng form
        {
            System.Windows.Forms.DialogResult result = System.Windows.Forms.MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận thoát", System.Windows.Forms.MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }
    }
}
