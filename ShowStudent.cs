using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.DAL;

namespace WinFormsApp1
{
    public partial class frmshowstudent : Form
    {
        
        string studentId;
        public frmshowstudent(string studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
        }

        private void Frmdbshow_Load(object sender, EventArgs e)
        {

            StudentDal studentDal = new StudentDal();

            DataTable dt = studentDal.GetById(this.studentId.ToString());

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show(
                    "Student not found",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            DataRow dr = dt.Rows[0];

            // Load Student Data
            txtFirstName.Text = dr["first_name"].ToString();
            txtLastName.Text = dr["last_name"].ToString();
            txtAddress.Text = dr["per_address"].ToString();
            txtAdmissionNo.Text = dr["admission_number"].ToString();
            txtNIC.Text = dr["nic_number"].ToString();
            txtTel.Text = dr["tele_number"].ToString();
            txtBirthNo.Text = dr["birth_certificate_number"].ToString();

            // Load Gender
            string gender = dr["gender"].ToString();

            rdoMale.Checked = gender == "M";
            rdoFemale.Checked = gender == "F";

            // Load Grade
            if (dr["grade_name"] != DBNull.Value)
            {
                txtGrade.Text = dr["grade_name"].ToString();
            }
            else
            {
                txtGrade.Text = "N/A";
            }

            // Load Date of Birth
            if (dr["date_of_birth"] != DBNull.Value)
            {
                dtpDOB.Value = Convert.ToDateTime(dr["date_of_birth"]);
            }
            else
            {
                dtpDOB.Value = DateTime.Now;
            }

            // Load Date of Admission
            if (dr["date_of_admission"] != DBNull.Value)
            {
                dtpAdmission.Value =
                    Convert.ToDateTime(dr["date_of_admission"]);
            }
            else
            {
                dtpAdmission.Value = DateTime.Now;
            }

            // Load House
            if (dr["house_name"] != DBNull.Value)
            {
                txtHouse.Text = dr["house_name"].ToString();
            }
            else
            {
                txtHouse.Text = "N/A";
            }

            // Load Medium
            if (dr["medium"] != DBNull.Value)
            {
                txtMedium.Text = dr["medium"].ToString();
            }
            else
            {
                txtMedium.Text = "N/A";
            }

            // Load Family Mobile
            if (dr["family_mobile"] != DBNull.Value)
            {
                txtFamily.Text = dr["family_mobile"].ToString();
            }
            else
            {
                txtFamily.Text = "N/A";
            }
            
        }

        private void lbl_familyid_Click(object sender, EventArgs e)
        {

        }


    }
}
