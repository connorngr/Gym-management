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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            uidTb.Text = "";
            passTb.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(uidTb.Text=="" || passTb.Text == "")
            {
                MessageBox.Show("Vui lòng! Nhập đầy đủ tài khoảng và mật khẩu.");
            } else if(uidTb.Text=="Admin" && passTb.Text == "Admin")
            {
                FormMain fm=new FormMain();
                fm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Bạn nhập sai tài khoảng hoặc mật khẩu.");
            }
        }
    }
}
