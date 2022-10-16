using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Milestone_2_PRG252_Group_Project
{
    internal class DataHandller1
    {
        static string conn = @"Data Source=DESKTOP-IAFIOJ6;Initial Catalog=MileStone_2_ProjectPRG252;Integrated Security=True";
        SqlConnection connector = new SqlConnection(conn);

        public void RegisterFuction(int StudentId, string StudentName, string StudentSurname, string Gender ,string PhoneNumber,string StudentCourse)
        {
            // string query = @"Insert Into Students (ID,Name,Surname,Reg Date) Values()";

            using (SqlConnection connector = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("SPAddNew", connector);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@studentID", StudentId);
                cmd.Parameters.AddWithValue("@Student Name", StudentName);
                cmd.Parameters.AddWithValue("@Student Surname", StudentSurname);
                cmd.Parameters.AddWithValue("@Student Gender", Gender);
                cmd.Parameters.AddWithValue("@Student Phone", PhoneNumber);
                cmd.Parameters.AddWithValue("@Student Course", StudentCourse);

                try
                {
                    connector.Open();
                    cmd.ExecuteNonQuery();
                    connector.Close();

                }
                catch (Exception)
                {

                    throw;
                }

            }

        }

        public DataTable DisplayStudents()
        {

            using (SqlConnection connector = new SqlConnection(conn))
            {
                SqlDataAdapter DAdapter = new SqlDataAdapter("SPdisplayAll", connector);
                DAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable DataT = new DataTable();
                DAdapter.Fill(DataT);
                return DataT;

            }

        }

        public void Update(int StudentId, string StudentName, string StudentSurname, string Gender, string PhoneNumber, string StudentCourse)
        {
            using (SqlConnection connector = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("SPUpdateStudent", connector);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@studentID", StudentId);
                cmd.Parameters.AddWithValue("@Student Name", StudentName);
                cmd.Parameters.AddWithValue("@Student Surname",StudentSurname);
                cmd.Parameters.AddWithValue("@Student gender", Gender);
                cmd.Parameters.AddWithValue("@PhoneNumber",PhoneNumber);
                cmd.Parameters.AddWithValue("@Student Course",StudentCourse);

                try
                {
                    connector.Open();
                    cmd.ExecuteNonQuery();
                    connector.Close();

                }
                catch (Exception)
                {

                    throw;
                }

            }
        }

        public void DeleteStudent(int StudentId)
        {
            using (SqlConnection connector = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("SPDeleteStudent", connector);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@studentID", StudentId);


                try
                {
                    connector.Open();
                    cmd.ExecuteNonQuery();
                    connector.Close();

                }
                catch (Exception)
                {

                    throw;
                }

            }
        }

        public DataTable SearchFunction(int studentID)
        {
            using (SqlConnection connector = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("SPDeleteStudent", connector);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@studentID", studentID);
                DataTable DataT = new DataTable();

                try
                {
                    connector.Open();



                }
                catch (Exception)
                {

                    throw;
                }

                using (SqlDataReader DAtAR = cmd.ExecuteReader())
                {
                    DataT.Load(DAtAR);
                    return DataT;

                }


            }
        }
    }
}


    

