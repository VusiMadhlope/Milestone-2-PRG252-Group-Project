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
    public partial class BCAdmin : Form
    {
        public BCAdmin()
        {
            InitializeComponent();
        }

        private void BCAdmin_Load(object sender, EventArgs e)
        {

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            SearchPage searchpage = new SearchPage();
            searchpage.Show();
            searchpage.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Student_Registragtion Registration = new Student_Registragtion();
            Registration.Show();
            Registration.Close()
;        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DeleteForm deleteform = new DeleteForm();
            deleteform.Show();
            deleteform.Hide();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
