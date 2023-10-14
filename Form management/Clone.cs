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
    public partial class AddMember : Form
    {
        public AddMember()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=CONNOR-PC;Initial Catalog=GymDB;Integrated Security=True");
        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Blank_TextBox()
        {
            txtAge.Text = string.Empty;
            txtName.Text = string.Empty;
            txtAge.Text = string.Empty;
            txtAmount.Text = string.Empty;
            txtPhone.Text = string.Empty;
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text==""||txtPhone.Text==""||txtAmount.Text==""||txtAmount.Text=="")
            {
                MessageBox.Show("Missing information", "Warning");
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "insert into Member values('"+txtName.Text+"'," +
                        "'"+txtPhone.Text+"', '"+cmbGender.Text+"'," +
                        "'"+txtAge.Text+"', '"+txtAmount.Text+"')";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member successfully added");
                    Blank_TextBox();
                    conn.Close();
                }
                catch(Exception ex)
                {
                    conn.Close();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void AddMember_Load(object sender, EventArgs e)
        {
            cmbGender.SelectedIndex = 0;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Blank_TextBox();
            MessageBox.Show("Clear all information succesfully!", "Notification");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            formMain.Show();
            Hide();
        }
    }
}
