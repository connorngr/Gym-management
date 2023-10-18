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
    public partial class AddEquipment : Form
    {
        public AddEquipment()
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

        private void Equipment_Load(object sender, EventArgs e)
        {
            cmbLocation.SelectedIndex = 0;
            cmbCondition.SelectedIndex = 0;
            DTP.Format = DateTimePickerFormat.Custom;
            DTP.CustomFormat = "dd-MM-yyyy";
            FetchString();
        }
        private void Blank_TextBox()
        {
            txtName.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtManufacturer.Text = string.Empty;
            cmbCondition.SelectedIndex = -1;
            cmbLocation.SelectedIndex = -1;
        }

        private void labExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
        
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string Payperiod = DTP.Value.Day.ToString() + DTP.Value.Month.ToString() + DTP.Value.Year.ToString();
            int price = -1;
            if (txtName.Text == "" || txtQuantity.Text == "" || txtPrice.Text=="" || 
                txtManufacturer.Text=="" || string.IsNullOrEmpty(cmbCondition.Text) || string.IsNullOrEmpty(cmbLocation.Text))
            {
                MessageBox.Show("Missing information", "Warning");
            }
            else
            {
                try
                {
                    bool checkPrice = int.TryParse(txtPrice.Text, out price);
                    
                    if (price<=0 || price>= 2147483647 || price==-1) 
                    {
                        throw new Exception("Check your price again. Price just from 0 to 2147483647");
                    }
                    conn.Open();
                    string query = "insert into Equipment values('" + txtName.Text + "'," + "'" + txtQuantity.Text + "'," +
                        " '" + txtPrice.Text + "'," +" " + "'" + txtManufacturer.Text + "'," + "'" + Payperiod + "'" +
                        "," + "'" + cmbCondition.Text + "'," + "'" + cmbLocation.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Equipment successfully added");
                    Blank_TextBox();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
