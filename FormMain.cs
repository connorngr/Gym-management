﻿using System;
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
            Application.Exit();
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
    }
}
