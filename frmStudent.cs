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
using WinFormsApp1.DAL;

namespace WinFormsApp1
{
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();

        }


        private void InsertStudent()
        {
            string gender = rdoMale.Checked ? "M" : "F";

            StudentDal studentDal = new StudentDal();

            bool inserted = studentDal.Insert(
                txtAdmissionNo.Text,
                txtFirstName.Text,
                txtLastName.Text,
                gender,
                dtpDOB.Value,
                txtNIC.Text,
                txtBirthNo.Text,
                txtTel.Text,
                txtAddress.Text,
                cmbGrade.SelectedValue.ToString(),
                txtHouse.Text,
                cmbMedium.Text,
                txtFamily.Text,
                dtpAdmission.Value
            );

            if (inserted)
            {
                MessageBox.Show(
                    "Student inserted successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.Close();
            }
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

                InsertStudent();
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
