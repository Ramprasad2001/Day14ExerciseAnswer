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
using System.Configuration;

namespace Day14Exercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private SqlConnection objconnection = null;
        private SqlCommand objcommand = null;
        private SqlDataReader ObjReader = null;

     
        private void BtnSearch_Click(object sender, EventArgs e)
        {
             using (objconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Training"].ConnectionString))
            {
                using (objcommand = new SqlCommand("Select  Stud_Name, Dept_Code, Address from Student_master Where Stud_Code=@Stud_Code", objconnection))
                {
                    objcommand.Parameters.AddWithValue("@Stud_Code", TxtStudentCode.Text);

                    if (objconnection.State == ConnectionState.Closed)
                    {
                        objconnection.Open();
                    }

                    using (ObjReader = objcommand.ExecuteReader())
                    {
                        if (ObjReader.HasRows)
                        {
                            ObjReader.Read();
                            TxtStudentName.Text = ObjReader["Stud_Name"].ToString();
                            TxtDepartment.Text = ObjReader["Dept_Code"].ToString();
                            TxtAddress.Text = ObjReader["Address"].ToString();
                            //TxtSocialSecurityNo.Text = reader["cSocialSecurityNo"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("No Record");
                            this.clearText();
                        }
                    }
                }
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            this.clearText();
        }
        public void clearText()
        {
            TxtStudentCode.Text = "";
            TxtStudentName.Text = "";
            TxtDepartment.Text = "";
            TxtAddress.Text = "";
            TxtStudentCode.Focus();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            using (objconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Training"].ConnectionString))
            {
                using (objcommand = new SqlCommand("std_AddNewStudent", objconnection))
                {
                    objcommand.CommandType = CommandType.StoredProcedure;
                    objcommand.Parameters.AddWithValue("@Stud_Code", TxtStudentCode.Text);
                    objcommand.Parameters.AddWithValue("@Stud_Name", TxtStudentName.Text);
                    objcommand.Parameters.AddWithValue("@Dept_Code", TxtDepartment.Text);
                    objcommand.Parameters.AddWithValue("@Address", TxtAddress.Text);
                   // cmd.Parameters.AddWithValue("@SocialSecurityNo", TxtSocialSecurityNo.Text);

                    if (objconnection.State == ConnectionState.Closed)
                    {
                        objconnection.Open();
                    }

                    objcommand.ExecuteNonQuery(); //used for DML operation
                }
            }
            MessageBox.Show("Added new Student");

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            using (objconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Training"].ConnectionString))
            {
                using (objcommand = new SqlCommand("std_UpdateStudent", objconnection))
                {
                    objcommand.CommandType = CommandType.StoredProcedure;
                    objcommand.Parameters.AddWithValue("@Stud_Name", TxtStudentName.Text);
                    objcommand.Parameters.AddWithValue("@Dept_Code", TxtDepartment.Text);
                    objcommand.Parameters.AddWithValue("@Address", TxtAddress.Text);
                    objcommand.Parameters.AddWithValue("@Stud_Code", TxtStudentCode.Text);
                    
                    if (objconnection.State == ConnectionState.Closed)
                    {
                        objconnection.Open();
                    }

                    objcommand.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Student updated successfully");
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            using (objconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Training"].ConnectionString))
            {
                using (objcommand = new SqlCommand("std_DeleteStudent", objconnection))
                {
                    objcommand.CommandType = CommandType.StoredProcedure;
                    objcommand.Parameters.AddWithValue("@Stud_Name", TxtStudentName.Text);
                    objcommand.Parameters.AddWithValue("@Dept_Code", TxtDepartment.Text);
                    objcommand.Parameters.AddWithValue("@Address", TxtAddress.Text);
                    objcommand.Parameters.AddWithValue("@Stud_Code", TxtStudentCode.Text);

                    if (objconnection.State == ConnectionState.Closed)
                    {
                        objconnection.Open();
                    }

                    objcommand.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Student Deleted successfully");

        }
    }
}
