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
    public partial class Update_DEL : Form
    {
        public Update_DEL()
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
        private void Populate()
        {
            conn.Open();
            string query = "select * from Member";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            var ds = new DataSet();
            adapter.Fill(ds);
            MemberGrid.DataSource = ds.Tables[0];
            MemberGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MemberGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            conn.Close();
        }
        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            FormMain formMain = new FormMain();
            formMain.Show();
        }

        private void Update_DEL_Load(object sender, EventArgs e)
        {
            FetchString();
            Populate();
        }
        int key = 0;
        private void MemberGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            key = int.Parse(MemberGrid.SelectedRows[0].Cells[0].Value.ToString());
            txtName.Text = MemberGrid.SelectedRows[0].Cells[1].Value.ToString();
            txtPhone.Text = MemberGrid.SelectedRows[0].Cells[2].Value.ToString();
            cmbGender.Text = MemberGrid.SelectedRows[0].Cells[3].Value.ToString();
            txtAge.Text = MemberGrid.SelectedRows[0].Cells[4].Value.ToString();
             
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select member to delete");
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "delete from Member where MemID=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member deleted successfully");
                    conn.Close();
                    Populate();
                    key = 0;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (key == 0 || txtName.Text == "" || txtPhone.Text == ""||txtAge.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "update Member set Name='" + txtName.Text + "', Phone='" + txtPhone.Text + "'," +
    " Gender='" + cmbGender.Text + "', Age='" + txtAge.Text + "' where MemID=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member updated successfully");
                    conn.Close();
                    Populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
