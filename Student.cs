using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone_2_PRG252_Group_Project
{
     class Student : Module
    {
        private string name;
        private string surname;
        private int studentID;
        private Image image;
        private DateTime dob;
        private string gender;
        private int phone;
        private string address;
        private string module;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int StudentID { get => studentID; set => studentID = value; }
        public Image Image { get => image; set => image = value; }
        public DateTime Dob { get => dob; set => dob = value; }
        public string Gender { get => gender; set => gender = value; }
        public int Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
        public string Module { get => module; set => module = value; }
        public Student()
        {

        }

        public Student(string name, string surname, int studentID, Image image, DateTime dob, string gender, int phone, string address, string module)
        {
            this.Name = name;
            this.Surname = surname;
            this.StudentID = studentID;
            this.Image = image;
            this.Dob = dob;
            this.Gender = gender;
            this.Phone = phone;
            this.Address = address;
            this.Module = module;
        }
    }
}
