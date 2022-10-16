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
    public partial class Welcome_Page : Form
    {
        public Welcome_Page()
        {
            InitializeComponent();
        }

        private void Welcome_Page_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
          
            Student_Login student_Login = new Student_Login();
            student_Login.Show();
            this.Hide();

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Student_Registragtion student_Registragtion = new Student_Registragtion();
            student_Registragtion.Show();
            this.Hide();
        }
    }
}
