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
    public partial class Update_Delete : Form
    {
        public Update_Delete()
        {
            InitializeComponent();
        }

        private void txtPhoneNum_TextChanged(object sender, EventArgs e)
        {
            string phoneNumber = txtPhoneNum.Text;
            // Kiểm tra xem có nhập đúng từ 0-9 không
            bool isValid = System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, "^[0-9]+$");
            if (isValid)
            {
                //HÀM XỬ LÝ               
            }
            else
            {
                MessageBox.Show("Vui lòng chỉ nhập số điện thoại.");
            }
        }
    }
}
