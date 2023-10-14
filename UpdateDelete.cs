using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;

namespace Gym_management
{
    public partial class UpdateDelete : Form
    {
        public UpdateDelete()
        {
            InitializeComponent();
        }
        private void populate()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from MemberTbl", Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            dgvUpdateDelete.DataSource = ds.Tables[0];
            Con.Close();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\GymDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void UpdateDelete_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void labExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void dgvUpdateDelete_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvUpdateDelete.Rows.Count)
            {
                bunifuMaterialTextboxNameMember.Text = dgvUpdateDelete.Rows[e.RowIndex].Cells[1].Value.ToString();
                bunifuMaterialTextboxNum.Text = dgvUpdateDelete.Rows[e.RowIndex].Cells[2].Value.ToString();
                cmbGender.Text = dgvUpdateDelete.Rows[e.RowIndex].Cells[3].Value.ToString();
                bunifuMaterialTextboxAge.Text = dgvUpdateDelete.Rows[e.RowIndex].Cells[4].Value.ToString();
                amounttb.Text = dgvUpdateDelete.Rows[e.RowIndex].Cells[5].Value.ToString();
                cmbTiming.Text = dgvUpdateDelete.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
        }

        private void butRefresh_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextboxNameMember.Text = "";
            bunifuMaterialTextboxNum.Text = "";
            cmbGender.Text = "";
            bunifuMaterialTextboxAge.Text = "";
            amounttb.Text = "";
            cmbTiming.Text = "";
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            if (bunifuMaterialTextboxNum.Text=="")
            {
                MessageBox.Show("Vui lòng chọn sinh viên bạn muốn xóa hoặc nhập số điện thoại");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from MemberTbl where MPhone=" + bunifuMaterialTextboxNum.Text + ";";
                    SqlCommand cmd= new SqlCommand(query,Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thành viên đã xóa thành công");
                    Con.Close();
                    populate();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void butExitOfpayment_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            formMain.Show();
            this.Hide();
        }

        private void butUpdate_Click(object sender, EventArgs e)
        {
            if (bunifuMaterialTextboxNum.Text == "" || bunifuMaterialTextboxNameMember.Text=="" 
                || bunifuMaterialTextboxAge.Text=="" || cmbGender.Text=="" || amounttb.Text=="" || cmbTiming.Text=="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update MemberTbl set MName='"+ bunifuMaterialTextboxNameMember.Text + "',MPhone='"+bunifuMaterialTextboxNum.Text+"',MGen='"+cmbGender.Text+"',MAge='"+bunifuMaterialTextboxAge.Text+"',MAmount='"+amounttb.Text+"',MTiming='"+cmbTiming.Text+"' where MPhone="+ bunifuMaterialTextboxNum.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thành viên đã cập nhật thành công");
                    Con.Close();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
