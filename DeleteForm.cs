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
    public partial class DeleteForm : Form
    {
        DataHandller1 handler = new DataHandller1();
        public DeleteForm()
        {
            InitializeComponent();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            handler.DeleteStudent(int.Parse(txtStudentID.Text));
            Console.WriteLine("student Data Deleted");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BCAdmin AdminPage = new BCAdmin();
            AdminPage.Show();
            AdminPage.Hide();
        }
    }
}
