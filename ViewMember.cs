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
                MessageBox.Show("Vui lòng chỉ nhập số điện thoại.");
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
    }
}
