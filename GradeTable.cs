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

        private async Task ShowGrade()
        {
            string id = dgvAllGrades.CurrentRow.Cells["id"].Value.ToString();

            frmShowGrade frm = new frmShowGrade(id);

            frm.ShowDialog();
        }
        private async Task DeleteGrade()
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

                bool deleted = await gradeDAL.Delete(id);

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

        private async Task LoadGrade()
        {
            GradeDAL gradeDAL = new GradeDAL();

            DataTable dt = await gradeDAL.GetAll();

            dgvAllGrades.DataSource = dt;
        }

        private async Task EditGrade()
        {
            string id = dgvAllGrades.CurrentRow.Cells["id"].Value.ToString();

            frmEditGrade frm = new frmEditGrade(id);

            frm.ShowDialog();

            await LoadGrade();
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

        private async void btnAllGrades_Click(object sender, EventArgs e)
        {
            try 
            {
                await LoadGrade();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                throw;
            }
        }

        private async void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                await ShowGrade();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                throw;
            }
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
               await EditGrade();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                throw;
            }
        }

        private async void btnDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                await DeleteGrade();
                await LoadGrade();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                throw;
            }
        }

        private async void btnInsert_Click(object sender, EventArgs e)
        {
            frmCreateGrade student = new frmCreateGrade();
            student.ShowDialog();
            await LoadGrade();
        }
    }
}
