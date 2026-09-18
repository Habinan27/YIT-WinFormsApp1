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
    public partial class GradeTable : Form
    {

        string connString = ConfigurationManager.ConnectionStrings["MyDbConnection"]?.ConnectionString ?? string.Empty;
        public GradeTable()
        {
            InitializeComponent();
        }

        private void ShowGrade()
        {
            string id = dgvAllGrades.CurrentRow.Cells["id"].Value.ToString();

            frmShowGrade frm = new frmShowGrade(id);

            frm.ShowDialog();
        }
        private void DeleteGrade()
        {
            string id = dgvAllGrades.CurrentRow.Cells["id"].Value.ToString();

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this grade?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                GradeDAL gradeDAL = new GradeDAL();

                bool deleted = gradeDAL.Delete(id);

                if (deleted)
                {
                    MessageBox.Show(
                        "Grade deleted successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                }
            }
        }

        private void LoadGrade()
        {
            GradeDAL gradeDAL = new GradeDAL();

            DataTable dt = gradeDAL.GetAll();

            dgvAllGrades.DataSource = dt;
        }

        private void EditGrade()
        {
            string id = dgvAllGrades.CurrentRow.Cells["id"].Value.ToString();

            frmEditGrade frm = new frmEditGrade(id);

            frm.ShowDialog();

            LoadGrade();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
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

        private void btnAllGrades_Click(object sender, EventArgs e)
        {
            try 
            {
                LoadGrade();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                throw;
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                ShowGrade();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                throw;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                EditGrade();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                throw;
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                DeleteGrade();
                LoadGrade();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                throw;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmCreateGrade student = new frmCreateGrade();
            student.ShowDialog();
            LoadGrade();
        }
    }
}
