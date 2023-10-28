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
using System.Data.Common;
using System.Xml.Linq;

namespace Gym_management
{
    public partial class Login_DB : Form
    {
        public Login_DB()
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
        private void Form1_Load(object sender, EventArgs e)
        {
            FetchString();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void butRefresh_Click(object sender, EventArgs e)
        {
            uidTb.Text = "";
            passTb.Text = "";
        }

        private void butLogin_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                if (uidTb.Text.Length>10 || passTb.Text.Length>10)
                {
                    throw new Exception("Tài khoảng và mật khẩu không quá 10 kí tự. Nhập sai vui lòng nhập lại!");
                }

                
                bool isAuthenticated = false;

                string query = "SELECT Account, Password FROM Login";

                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string dbUsername = reader["Account"].ToString().Trim();
                    string dbPassword = reader["Password"].ToString().Trim();

                    if (uidTb.Text == dbUsername && passTb.Text == dbPassword)
                    {
                        isAuthenticated = true;
                        break;
                    }
                }
                if (isAuthenticated)
                {
                    FormMain fm = new FormMain();
                    fm.Show();
                    this.Hide();
                    
                }
                else
                {
                    MessageBox.Show("Bạn nhập sai tài khoảng hoặc mật khẩu vui lòng nhập lại!");
                    uidTb.Text = "";
                    passTb.Text = "";
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }

        }

        private void labExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult result = System.Windows.Forms.MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận thoát", System.Windows.Forms.MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Login_DB_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((Control.ModifierKeys & Keys.Alt) != 0 && e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // Thoát chương trình
                    Environment.Exit(0);
                }
                else
                {
                    // Chặn đóng Form
                    e.Cancel = true;
                }
            }
        }
    }
}
