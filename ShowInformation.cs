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

namespace WinFormsApp1
{
    public partial class ShowInformation : Form
    {
        private int studentITd;

        string connString = ConfigurationManager.ConnectionStrings["MyDbConnection"]?.ConnectionString ?? string.Empty;
        public ShowInformation(
            string admissionNumber,
            string fname,
            string lname,
            string gender,
            string dob,
            string nic,
            string birthCertificate,
            string telephone,
            string house,
            string grade,
            string medium,
            string admissionDate,
            string address,
            string family)
        {
            InitializeComponent();
            string studentId;
            txtAdmissionNo.Text = admissionNumber;

            txtFirstName.Text = fname;

            txtLastName.Text = lname;

            txtAddress.Text = address;

            txtNIC.Text = nic;

            txtBirthNo.Text = birthCertificate;

            txtTel.Text = telephone;


            // GRADE ID
            if (grade != "")
            {
                //string connectionString = "Server=localhost;Database=school;Uid=root;Pwd=root;";
                MySqlConnection conn = new MySqlConnection(connString);

                try
                {
                   
                    MySqlCommand gradecmd = new MySqlCommand("SELECT * FROM grades", conn);
                    conn.Open();
                    MySqlDataReader da = gradecmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(da);
                    cmbGrade.DataSource = dt;
                    cmbGrade.DisplayMember = "grade_name";
                    cmbGrade.ValueMember = "id";
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error occurred while fetching student data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }


            // HOUSE ID
            if (house != "")
            {
                cmbHouse.SelectedValue = Convert.ToInt32(house);
            }

            // FAMILY ID
            if (family != "")
            {
                cmbFamily.SelectedValue = Convert.ToInt32(family);
            }


            // MEDIUM
            cmbMedium.Text = medium;


            // DATE OF BIRTH
            if (dob != "")
            {
                dtpDOB.Value = Convert.ToDateTime(dob);
            }


            // DATE OF ADMISSION

            if (admissionDate != "")
            {
                dtpAdmission.Value = Convert.ToDateTime(admissionDate);
            }

            // GENDER
            if (gender == "M")
            {
                rdoMale.Checked = true;
            }
            else if (gender == "F")
            {
                rdoFemale.Checked = true;
            }
        }

        private async void ShowInformation_Load(object sender, EventArgs e)
        {
            try
            {
                await using MySqlConnection conn = new MySqlConnection(connString);
                await conn.OpenAsync();

                //Load grades into ComboBox
                string gradeQuery = "SELECT id, grade_name FROM grades";

                MySqlCommand gradecmd = new MySqlCommand(gradeQuery, conn);
                await using MySqlDataReader gradereader = await gradecmd.ExecuteReaderAsync();

                DataTable gradeTable = new DataTable();
                gradeTable.Load(gradereader);

                cmbGrade.DataSource = gradeTable;
                cmbGrade.DisplayMember = "grade_name";
                cmbGrade.ValueMember = "id";

                //Load Houses into ComboBox
                string houseQuery = "SELECT id, house_name FROM houses";

                MySqlCommand housecmd = new MySqlCommand(houseQuery, conn);
                await using MySqlDataReader housereader = await housecmd.ExecuteReaderAsync();
                DataTable houseTable = new DataTable();
                houseTable.Load(housereader);

                cmbHouse.DataSource = houseTable;
                cmbHouse.DisplayMember = "house_name";
                cmbHouse.ValueMember = "id";

                //Load Families into ComboBox

                string familyQuery = "SELECT id, mobile_number FROM families";

                MySqlCommand familycmd = new MySqlCommand(familyQuery, conn);
                await using MySqlDataReader familyreader = await familycmd.ExecuteReaderAsync();

                DataTable familyTable = new DataTable();
                familyTable.Load(familyreader);

                cmbFamily.DataSource = familyTable;
                cmbFamily.DisplayMember = "mobile_number";
                cmbFamily.ValueMember = "id";


                //Load Student Data into Form Controls
                MySqlCommand studentCmd =
            new MySqlCommand(
                "SELECT * FROM students WHERE id = @id",
                conn);

                studentCmd.Parameters.AddWithValue(
                    "@id",
                    this.studentITd);

                await using MySqlDataReader studentReader =
                    await studentCmd.ExecuteReaderAsync();

                DataTable dt = new DataTable();

                dt.Load(studentReader);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Student not found.");
                    return;
                }

                DataRow dr = dt.Rows[0];


                // TextBoxes
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

                txtBirthNo.Text =
                    dr["birth_certificate_number"].ToString();

                txtTel.Text =
                    dr["tele_number"].ToString();


                // Gender
                string gender =
                    dr["gender"].ToString();

                rdoMale.Checked = gender == "M";
                rdoFemale.Checked = gender == "F";


                // Grade
                if (dr["grade_id"] != DBNull.Value)
                {
                    cmbGrade.SelectedValue =
                        dr["grade_id"];
                }
                else
                {
                    cmbGrade.SelectedIndex = -1;
                    cmbGrade.Text = "N/A";
                }


                // Date of Birth
                if (dr["date_of_birth"] != DBNull.Value)
                {
                    dtpDOB.Value =
                        Convert.ToDateTime(
                            dr["date_of_birth"]);
                }
                else
                {
                    dtpDOB.Value = DateTime.Now;
                }


                // House
                if (dr["house_id"] != DBNull.Value)
                {
                    cmbHouse.SelectedValue =
                        Convert.ToInt32(dr["house_id"]);
                }
                else
                {
                    cmbHouse.SelectedIndex = -1;
                    cmbHouse.Text = "N/A";
                }


                // Medium
                if (dr["medium"] != DBNull.Value)
                {
                    cmbMedium.Text =
                        dr["medium"].ToString();
                }
                else
                {
                    cmbMedium.Text = "N/A";
                }


                // Family
                if (dr["family_id"] != DBNull.Value)
                {
                    cmbFamily.SelectedValue =
                        Convert.ToInt32(dr["family_id"]);
                }
                else
                {
                    cmbFamily.SelectedIndex = -1;
                    cmbFamily.Text = "N/A";
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(
                    "Database error:\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
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

        private void lblFamily_Click(object sender, EventArgs e)
        {

        }
    }
}
