using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Milestone_2_PRG252_Group_Project
{
    public partial class Student_Login : Form
    {
        public Student_Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("\"C:\\\\Users\\\\Vusi\\\\Downloads\\\\Milestone 2 PRG252 Group Project\\\\BC Student Login Credentials\""))
            {
                using (StreamReader streamreader = new StreamReader("BC Student Login Credentials.txt"))
                {
                   // txtUSERNAME.Text = StreamReader.ReadLine();
                   //txtPassword.Text = StreamReader.ReadLine();
                }
            }
            else { }
       
        }

        private void txtUSERNAME_TextChanged(object sender, EventArgs e)
        {
            //writing from textbox to txt file
            using (StreamWriter txt = new StreamWriter("C:\\Users\\Vusi\\Downloads\\Milestone 2 PRG252 Group Project\\BC Student Login Credentials"))
            {
                txt.WriteLine("Username: " ,txtUSERNAME.Text);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtUSERNAME.Text == "Rona Malope" && txtPassword.Text == "Rona0000")
            {
                using (StreamWriter streamwriter = new StreamWriter("C:\\Users\\Vusi\\Downloads\\Milestone 2 PRG252 Group Project\\BC Student Login Credentials"))
                {
                    streamwriter.WriteLine(txtUSERNAME.Text);
                }
                UserPage userpage = new UserPage();
                userpage.Show();
                this.Hide();
            }
            else if (txtUSERNAME.Text == "Oarabile Madhlope" && txtPassword.Text == "Oarabile1111")
            {
                using (StreamWriter streamwriter = new StreamWriter("C:\\Users\\Vusi\\Downloads\\Milestone 2 PRG252 Group Project\\BC Student Login Credentials"))
                {
                    streamwriter.WriteLine(txtUSERNAME.Text);
                }
                UserPage userpage = new UserPage();
                userpage.Show();
                this.Hide();
            }
            else if (txtUSERNAME.Text == "Omphile Kgasoane" && txtPassword.Text == "PK1234")
            {
                using (StreamWriter streamwriter = new StreamWriter("C:\\Users\\Vusi\\Downloads\\Milestone 2 PRG252 Group Project\\BC Student Login Credentials"))
                {
                    streamwriter.WriteLine(txtUSERNAME.Text);
                }
                UserPage userpage = new UserPage();
                userpage.Show();
                this.Hide();
            }
            else if (txtUSERNAME.Text == "Lethabo Makhale" && txtPassword.Text == "Lethabo1122")
            {
                using (StreamWriter streamwriter = new StreamWriter("C:\\Users\\Vusi\\Downloads\\Milestone 2 PRG252 Group Project\\BC Student Login Credentials"))
                {
                    streamwriter.WriteLine(txtUSERNAME.Text);
                }
                UserPage userpage = new UserPage();
                userpage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Credentials are incorrect!!!");
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            using (StreamWriter txt = new StreamWriter("C:\\Users\\Vusi\\Downloads\\Milestone 2 PRG252 Group Project\\BC Student Login Credentials"))
            {
                txt.WriteLine("Username: ", txtUSERNAME.Text);
            }
        }
    }
}
