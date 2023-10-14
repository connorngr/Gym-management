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

        private void label8_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
