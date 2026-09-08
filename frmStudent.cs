using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();

        }

        string studentId;
        public frmStudent(string studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
        }

        private void Frmdbshow_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=school;Uid=root;Pwd=root;";
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();

                //Load grades into ComboBox
                string gradeQuery = "SELECT id, grade_name FROM grades";
                MySqlDataAdapter gradeAdapter = new MySqlDataAdapter(gradeQuery, conn);
                DataTable gradeTable = new DataTable();
                gradeAdapter.Fill(gradeTable);

                cmbGrade.DataSource = gradeTable;
                cmbGrade.DisplayMember = "grade_name";
                cmbGrade.ValueMember = "id";


                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            finally
            {
                conn.Close();
            }
        }

        private void lbl_familyid_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=school;Uid=root;Pwd=root;";
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                // Validation
                if (txtAdmissionNo.Text == "")
                {
                    MessageBox.Show("Please enter Admission Number");
                    txtAdmissionNo.Focus();
                    return;
                }

                if (txtFirstName.Text == "")
                {
                    MessageBox.Show("Please enter First Name");
                    txtFirstName.Focus();
                    return;
                }

                if (txtLastName.Text == "")
                {
                    MessageBox.Show("Please enter Last Name");
                    txtLastName.Focus();
                    return;
                }

                if (!rdoMale.Checked && !rdoFemale.Checked)
                {
                    MessageBox.Show("Please select Gender");
                    return;
                }

                if (txtNIC.Text == "")
                {
                    MessageBox.Show("Please enter NIC Number");
                    txtNIC.Focus();
                    return;
                }

                if (txtBirthNo.Text == "")
                {
                    MessageBox.Show("Please enter Birth Certificate Number");
                    txtBirthNo.Focus();
                    return;
                }

                if (txtTel.Text == "")
                {
                    MessageBox.Show("Please enter Telephone Number");
                    txtTel.Focus();
                    return;
                }

                if (txtAddress.Text == "")
                {
                    MessageBox.Show("Please enter Address");
                    txtAddress.Focus();
                    return;
                }

                if (cmbGrade.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select Grade");
                    cmbGrade.Focus();
                    return;
                }

                if (txtHouse.Text == "")
                {
                    MessageBox.Show("Please enter House");
                    txtHouse.Focus();
                    return;
                }

                if (cmbMedium.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select Medium");
                    cmbMedium.Focus();
                    return;
                }

                if (txtFamily.Text == "")
                {
                    MessageBox.Show("Please enter Family");
                    txtFamily.Focus();
                    return;
                }

                conn.Open();

                string gender = rdoMale.Checked ? "M" : "F";

                // Create new House
                string houseName = txtHouse.Text;

                MySqlCommand houseCmd = new MySqlCommand(
                    $"INSERT INTO houses (house_name) VALUES ('{houseName}')",
                    conn);

                houseCmd.ExecuteNonQuery();

                string houseId = houseCmd.LastInsertedId.ToString();

                // Create new Family
                string mobile_number = txtFamily.Text;

                MySqlCommand familyCmd = new MySqlCommand(
                    $"INSERT INTO families (mobile_number) VALUES ('{mobile_number}')",
                    conn);

                familyCmd.ExecuteNonQuery();

                string familyId = familyCmd.LastInsertedId.ToString();

                // Insert Student
                MySqlCommand cmd = new MySqlCommand(
                    $"INSERT INTO students (admission_number,first_name,last_name,gender,date_of_birth,nic_number,birth_certificate_number,tele_number,per_address,grade_id,house_id,medium,date_of_admission,family_id) VALUES ('{txtAdmissionNo.Text}','{txtFirstName.Text}','{txtLastName.Text}','{gender}','{dtpDOB.Value.ToString("yyyy-MM-dd")}','{txtNIC.Text}','{txtBirthNo.Text}','{txtTel.Text}','{txtAddress.Text}','{cmbGrade.SelectedValue}','{houseId}','{cmbMedium.Text}','{dtpAdmission.Value.ToString("yyyy-MM-dd")}','{familyId}')",
                    conn);

                string affectedRows = cmd.ExecuteNonQuery().ToString();

                MessageBox.Show("Create Successfully.Row affected" + affectedRows,
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occurred while connection to the database" + ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }
    }
}
