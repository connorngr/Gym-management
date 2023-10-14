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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void FormMain_Load(object sender, EventArgs e)
        {

        }
        private void bunifuThinButtonAddMember_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chưa cập nhật! Vui lòng quay lại sau.");
        }
        private void bunifuThinButtonPayment_Click(object sender, EventArgs e)
        {
            Payment pm = new Payment();
            pm.Show();
            this.Hide();
        }

        private void labExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButtonUpdateDeleteMember_Click(object sender, EventArgs e)
        {
            UpdateDelete pm = new UpdateDelete();
            pm.Show();
            this.Hide();
        }

        private void bunifuThinButtonShowAll_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chưa cập nhật!. Vui lòng quay lại sau.");
        }
    }
}
