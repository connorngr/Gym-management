using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_management
{
    public partial class FormMain : Form
    {
        
        public FormMain()
        {
            InitializeComponent();          
        }
        private void label3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult result = System.Windows.Forms.MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận thoát", System.Windows.Forms.MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void FormMain_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F4)
            {
                System.Windows.Forms.DialogResult result = System.Windows.Forms.MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận thoát", System.Windows.Forms.MessageBoxButtons.YesNo);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Update_DEL update_DEL   = new Update_DEL();
            update_DEL.Show();
            Hide();
        }
        private void btnAddMem_Click(object sender, EventArgs e)
        {
            AddMember addMember = new AddMember();
            addMember.Show();
            Hide();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ViewMember viewMember = new ViewMember();
            viewMember.Show();
            Hide();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            Hide();
            Payment payment = new Payment();
            payment.Show();
        }

        private void btnEquipment_Click(object sender, EventArgs e)
        {
            Hide();
            AddEquipment addEquipment = new AddEquipment();
            addEquipment.Show();
        }

        private void btnUpdateDeleteEquipment_Click(object sender, EventArgs e)
        {
            Hide();
            UpdateDeleteEquipment updateDeleteEquipment = new UpdateDeleteEquipment();
            updateDeleteEquipment.Show();
        }

        
    }
}
