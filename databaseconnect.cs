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
        //private object dgvAllStudent;

        public databaseconnect()
        {
            InitializeComponent();

            if (string.IsNullOrWhiteSpace(connString))
            {
                MessageBox.Show("Datebase connection string is missing. Please cheak your configuration", "Configuration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private async void LoadStudents()
        {
            StudentDal studentDal = new StudentDal();

            DataTable dt = await studentDal.GetAll();

            dcvAllStudent.DataSource = dt;
        }

        private void DeleteStudent()
        {
            string id = dcvAllStudent.CurrentRow.Cells["id"].Value.ToString();

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this student?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                StudentDal studentDal = new StudentDal();

                bool deleted = studentDal.Delete(id);

                if (deleted)
                {
                    MessageBox.Show(
                        "Student deleted successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LoadStudents();
                }
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            //string connString = "Server=localhost;Port=3306;Database=school;Uid=root;Pwd=root;";
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                conn.Open();
                MessageBox.Show("Connection successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error connecting to database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private async void btnAllStudent_Click(object sender, EventArgs e)
        {
            StudentDal studentDal = new StudentDal();
            DataTable dt = await studentDal.GetAll();
            dcvAllStudent.DataSource = dt;
        }



        private void dcvAllStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dcvAllStudent.CurrentRow.Cells["id"].Value.ToString();

                frmshowstudent frm = new frmshowstudent(id);

                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void rdoMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnDBShow_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dcvAllStudent.CurrentRow.Cells["id"].Value.ToString();

                frmshowstudent frm = new frmshowstudent(id);

                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void databaseconnect_Load(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string id = dcvAllStudent.CurrentRow.Cells["id"].Value.ToString();

            EditStudent f = new EditStudent(id);

            f.ShowDialog();

            LoadStudents();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteStudent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmStudent student = new frmStudent();
            student.ShowDialog();
            LoadStudents();
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            int studentId = Convert.ToInt32(
                dcvAllStudent.CurrentRow.Cells["id"].Value
            );

            frmAddSubject frm = new frmAddSubject(studentId);

            frm.ShowDialog();
        }
    }
}
