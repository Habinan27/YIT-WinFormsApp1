using Microsoft.VisualBasic;
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
    public partial class databaseconnect : Form
    {
        private object studentId;

        string connString = ConfigurationManager.ConnectionStrings["MyDbConnection"]?.ConnectionString ?? string.Empty;

        // student or grade
        private string currentView = "student";

        public databaseconnect()
        {
            InitializeComponent();

            if (string.IsNullOrWhiteSpace(connString))
            {
                MessageBox.Show(
                    "Database connection string is missing. Please check your configuration",
                    "Configuration Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================
        // LOAD STUDENTS
        // =========================
        private async Task LoadStudents()
        {
            StudentDal studentDal = new StudentDal();

            DataTable dt = await studentDal.GetAll();

            dcvAllStudent.DataSource = dt;

            currentView = "student";
        }

        // =========================
        // DELETE STUDENT
        // =========================
        private async Task DeleteStudent()
        {
            if (dcvAllStudent.CurrentRow == null)
            {
                MessageBox.Show("Please select a student.");
                return;
            }

            string id = dcvAllStudent.CurrentRow.Cells["id"].Value.ToString();

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this student?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                StudentDal studentDal = new StudentDal();

                bool deleted = await studentDal.Delete(id);

                if (deleted)
                {
                    MessageBox.Show(
                        "Student deleted successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    await LoadStudents();
                }
            }
        }

        // =========================
        // CONNECTION
        // =========================
        private void btnConnect_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                conn.Open();

                MessageBox.Show(
                    "Connection successfully",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(
                    $"Error connecting to database: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        // =========================
        // ALL STUDENTS
        // =========================
        private async void btnAllStudent_Click(object sender, EventArgs e)
        {
            try
            {
                StudentDal studentDal = new StudentDal();

                DataTable dt = await studentDal.GetAll();

                dcvAllStudent.DataSource = dt;

                currentView = "student";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // =========================
        // ALL GRADES
        // =========================
        private async void btnGrades_Click(object sender, EventArgs e)
        {
            try
            {
                GradeDAL gradeDal = new GradeDAL();

                DataTable dt = await gradeDal.GetAll();

                dcvAllStudent.DataSource = dt;

                currentView = "grade";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // =========================
        // SHOW
        // =========================
        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                if (dcvAllStudent.CurrentRow == null)
                {
                    MessageBox.Show("Please select a record.");
                    return;
                }

                string id = dcvAllStudent.CurrentRow.Cells["id"].Value.ToString();

                // STUDENT SHOW
                if (currentView == "student")
                {
                    frmshowstudent frm = new frmshowstudent(id);

                    frm.ShowDialog();
                }

                // GRADE SHOW
                else if (currentView == "grade")
                {
                    frmShowGrade frm = new frmShowGrade(id);

                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // =========================
        // EDIT
        // =========================
        private async void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dcvAllStudent.CurrentRow == null)
                {
                    MessageBox.Show("Please select a record.");
                    return;
                }

                string id = dcvAllStudent.CurrentRow.Cells["id"].Value.ToString();

                // STUDENT EDIT
                if (currentView == "student")
                {
                    EditStudent student = new EditStudent(id);

                    student.ShowDialog();

                    await LoadStudents();
                }

                // GRADE EDIT
                else if (currentView == "grade")
                {
                    frmEditGrade grade = new frmEditGrade(id);

                    grade.ShowDialog();

                    await LoadGrades();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // =========================
        // LOAD GRADES
        // =========================
        private async Task LoadGrades()
        {
            GradeDAL gradeDal = new GradeDAL();

            DataTable dt = await gradeDal.GetAll();

            dcvAllStudent.DataSource = dt;

            currentView = "grade";
        }

        // =========================
        // DELETE
        // =========================
        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dcvAllStudent.CurrentRow == null)
                {
                    MessageBox.Show("Please select a record.");
                    return;
                }

                string id = dcvAllStudent.CurrentRow.Cells["id"].Value.ToString();

                // =========================
                // DELETE STUDENT
                // =========================
                if (currentView == "student")
                {
                    await DeleteStudent();
                }

                // =========================
                // DELETE GRADE
                // =========================
                else if (currentView == "grade")
                {
                    DialogResult result = MessageBox.Show(
                        "Are you sure you want to delete this grade?",
                        "Confirm Delete",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        GradeDAL gradeDal = new GradeDAL();

                        bool deleted = await gradeDal.Delete(id);

                        if (deleted)
                        {
                            MessageBox.Show(
                                "Grade deleted successfully.",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            await LoadGrades();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // =========================
        // INSERT STUDENT
        // =========================
        private async void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                frmStudent student = new frmStudent();

                student.ShowDialog();

                await LoadStudents();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // =========================
        // ADD SUBJECT
        // =========================
        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentView != "student")
                {
                    MessageBox.Show("Please select a student.");
                    return;
                }

                if (dcvAllStudent.CurrentRow == null)
                {
                    MessageBox.Show("Please select a student.");
                    return;
                }

                int studentId = Convert.ToInt32(
                    dcvAllStudent.CurrentRow.Cells["id"].Value
                );

                frmAddSubject frm = new frmAddSubject(studentId);

                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dcvAllStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void rdoMale_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void databaseconnect_Load(object sender, EventArgs e)
        {
        }

        private void btnDBShow_Click(object sender, EventArgs e)
        {
            btnShow_Click(sender, e);
        }
    }
}