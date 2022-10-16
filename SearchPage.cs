using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone_2_PRG252_Group_Project
{
    public partial class SearchPage : Form
    {
        DataHandller1 handler = new DataHandller1();
        public SearchPage()
        {
            InitializeComponent();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = handler.SearchFunction(int.Parse(txtStudentID.Text));
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BCAdmin bcadminpage = new BCAdmin();
            bcadminpage.Show();
            this.Hide();
        }
    }
}
