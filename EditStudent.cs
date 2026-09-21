using MySqlConnector;
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
    public partial class EditStudent : Form
    {
        string connString = ConfigurationManager.ConnectionStrings["MyDbConnection"]?.ConnectionString ?? string.Empty;
        
        string studentId;
        public EditStudent(string studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
            this.Load += async (s, e) => await Editstudent_load(s, e);
        }

        

        private async Task Editstudent_load(object sender, EventArgs e)
        {

            try
            {
               await using  MySqlConnection conn = new MySqlConnection(connString);
                await conn.OpenAsync();

                // Load Grades
                string gradeQuery = "SELECT id, grade_name FROM grades";

                await using MySqlDataReader gradeReader =
                    await new MySqlCommand(gradeQuery, conn).ExecuteReaderAsync();

                DataTable gradeTable = new DataTable();

                gradeTable.Load(gradeReader);

                cmbGrade.DataSource = gradeTable;
                cmbGrade.DisplayMember = "grade_name";
                cmbGrade.ValueMember = "id";


                // Load Student + House + Family
                MySqlCommand cmd = new MySqlCommand(@"
                    SELECT
                        students.*,
                        houses.house_name,
                        families.mobile_number
                    FROM students

                    LEFT JOIN houses
                        ON students.house_id = houses.id

                    LEFT JOIN families
                        ON students.family_id = families.id

                    WHERE students.id = @id
                ", conn);

                cmd.Parameters.AddWithValue("@id", studentId);

                await using MySqlDataReader reader = await cmd.ExecuteReaderAsync();

                DataTable dt = new DataTable();

                dt.Load(reader);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "Student not found.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    this.Close();
                    return;
                }

                DataRow dr = dt.Rows[0];


                // ---------------- Student Details ----------------

                txtFirstName.Text =
                    dr["first_name"].ToString();

                txtLastName.Text =
                    dr["last_name"].ToString();

                txtAddress.Text =
                    dr["per_address"].ToString();

                txtAdmissionNo.Text =
                    dr["admission_number"].ToString();

                txtNIC.Text =
                    dr["nic_number"].ToString();

                txtTel.Text =
                    dr["tele_number"].ToString();

                txtBirthNo.Text =
                    dr["birth_certificate_number"].ToString();


                // ---------------- Gender ----------------

                string gender =
                    dr["gender"].ToString();

                rdoMale.Checked = gender == "M";
                rdoFemale.Checked = gender == "F";


                // ---------------- Grade ----------------

                if (dr["grade_id"] != DBNull.Value)
                {
                    cmbGrade.SelectedValue =
                        dr["grade_id"];
                }
                else
                {
                    cmbGrade.SelectedIndex = -1;
                }


                // ---------------- Date of Birth ----------------

                if (dr["date_of_birth"] != DBNull.Value)
                {
                    dtpDOB.Value =
                        Convert.ToDateTime(dr["date_of_birth"]);
                }
                else
                {
                    dtpDOB.Value = DateTime.Now;
                }


                // ---------------- Admission Date ----------------

                if (dr["date_of_admission"] != DBNull.Value)
                {
                    dtpAdmission.Value =
                        Convert.ToDateTime(dr["date_of_admission"]);
                }
                else
                {
                    dtpAdmission.Value = DateTime.Now;
                }


                // ---------------- House ----------------

                if (dr["house_name"] != DBNull.Value)
                {
                    txtHouse.Text =
                        dr["house_name"].ToString();
                }
                else
                {
                    txtHouse.Text = "N/A";
                }


                // ---------------- Medium ----------------

                if (dr["medium"] != DBNull.Value)
                {
                    cmbMedium.Text =
                        dr["medium"].ToString();
                }
                else
                {
                    cmbMedium.Text = "N/A";
                }


                // ---------------- Family ----------------

                if (dr["mobile_number"] != DBNull.Value)
                {
                    txtFamily.Text =
                        dr["mobile_number"].ToString();
                }
                else
                {
                    txtFamily.Text = "N/A";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            
        }

        private void lbl_familyid_Click(object sender, EventArgs e)
        {

        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string gender = rdoMale.Checked ? "M" : "F";
                StudentDal studentDal = new StudentDal();
                bool updated = await studentDal.Update(
                    studentId,
                    txtAdmissionNo.Text,
                    txtFirstName.Text,
                    txtLastName.Text,
                    gender,
                    txtNIC.Text,
                    txtBirthNo.Text,
                    txtTel.Text,
                    txtAddress.Text,
                    cmbGrade.SelectedValue.ToString(),
                    txtHouse.Text,
                    cmbMedium.Text,
                    txtFamily.Text,
                    dtpDOB.Value,
                    dtpAdmission.Value
                );

                if (updated)
                {
                    MessageBox.Show(
                        "Student updated successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
