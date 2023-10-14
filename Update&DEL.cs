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

        SqlConnection conn = new SqlConnection(@"Data Source=CONNOR-PC;Initial Catalog=GymDB;Integrated Security=True");
        private void Populate()
        {
            conn.Open();
            string query = "select ID, Name, Phone, Gender, Age from Member";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder();
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
            Populate();
        }

        private void MemberGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = MemberGrid.SelectedRows[0].Cells[1].Value.ToString();
            txtPhone.Text = MemberGrid.SelectedRows[0].Cells[2].Value.ToString();
            cmbGender.Text = MemberGrid.SelectedRows[0].Cells[3].Value.ToString();
            txtAge.Text = MemberGrid.SelectedRows[0].Cells[4].Value.ToString();
        }
    }
}
