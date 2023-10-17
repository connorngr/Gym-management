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
            conn.Open();
            string query = "select * from Member";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            adapter.Fill(ds);
            MemberGrid.DataSource = ds.Tables[0];
            MemberGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;   
            conn.Close();
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
            //?
            MemberGrid.DataSource = ds.Tables[0];
            conn.Close();

        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            Populate();
        }
    }
}
