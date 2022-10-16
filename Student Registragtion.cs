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
    public partial class Student_Registragtion : Form
    {
        DataHandller1 handler = new DataHandller1();
        public Student_Registragtion()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            handler.RegisterFuction(int.Parse(txtStudentID.Text), txtStudentname.Text, txtStudentSurname.Text, txtStuGender.Text, txtStuPhone.Text,txtStuModCode.Text);
            BCAdmin bcadminpage = new BCAdmin();
            bcadminpage.Show();
            this.Hide();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            handler.Update(int.Parse(txtStudentID.Text), txtStudentname.Text, txtStudentSurname.Text, txtStuGender.Text, txtStuPhone.Text, txtStuModCode.Text);
            MessageBox.Show("Update has been successfully completed");
        }
    }
}
