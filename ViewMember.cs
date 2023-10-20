using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        SqlConnection conn = new SqlConnection();
        public void FetchString()
        {
            DBString Dbstring = new DBString();
            string db = Dbstring.getDB();
            conn = new SqlConnection(db);
        }
        
        private void Populate()
        {
            try
            {
                conn.Open();
                string query = "select * from Member";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder();
                var ds = new DataSet();
                adapter.Fill(ds);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MemberGrid.DataSource = ds.Tables[0];
                    MemberGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
                conn.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ViewMember_Load(object sender, EventArgs e)
        {
                FetchString();
                Populate();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            FormMain formMain = new FormMain();
            formMain.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "select * from Member where Name LIKE '%"+txtSearchName.Text+"%'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            var ds = new DataSet();
            adapter.Fill(ds);
            MemberGrid.DataSource = ds.Tables[0];
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("The name you looked for isn't in the list.", "Confident");
            }
            conn.Close();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            Populate();
        }
    }
}
