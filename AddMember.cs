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
        SqlConnection conn = new SqlConnection();
        public void FetchString()
        {
            DBString Dbstring = new DBString();
            string db = Dbstring.getDB();
            conn = new SqlConnection(db);
        }
        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Blank_TextBox()
        {
            txtAge.Text = string.Empty;
            txtName.Text = string.Empty;
            txtAge.Text = string.Empty;
            txtPhone.Text = string.Empty;
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text==""||txtPhone.Text==""||txtAge.Text=="")
            {
                MessageBox.Show("Missing information", "Warning");
            }
            else
            {
                try
                {
                    if (txtPhone.Text.Length<10 || txtPhone.Text.Length>13)
                    {
                        throw new Exception("Check your phone number again");
                    }
                    bool checkAge = int.TryParse(txtAge.Text, out int age);
                    if (checkAge!=true)
                    {
                        throw new Exception("Invalid age");
                    }
                    if (int.Parse(txtAge.Text)<=0 || int.Parse(txtAge.Text) > 100)
                    {
                        throw new Exception("Invalid age");
                    }
                    conn.Open();
                    string query = "insert into Member values('"+txtName.Text+"'," +
                        "'"+txtPhone.Text+"', '"+cmbGender.Text+"'," +
                        "'"+txtAge.Text+"')";
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
            FetchString();
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
