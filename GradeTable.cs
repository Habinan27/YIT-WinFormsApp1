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

namespace WinFormsApp1
{
    public partial class GradeTable : Form
    {

        string connString = ConfigurationManager.ConnectionStrings["MyDbConnection"]?.ConnectionString ?? string.Empty;
        public GradeTable()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnConnection_Click(object sender, EventArgs e)
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

        private void btnAllGrades_Click(object sender, EventArgs e)
        {
            //string connString = "Server=localhost;Port=3306;Database=school;Uid=root;Pwd=root;";
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM grades", conn);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvAllGrades.DataSource = dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error retrieving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dgvAllGrades.CurrentRow.Cells["id"].Value.ToString();
                frmShowGrade f = new frmShowGrade(id);
                f.ShowDialog();
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
                string id = dgvAllGrades.CurrentRow.Cells["id"].Value.ToString();
                frmEditGrade f = new frmEditGrade(id);
                f.ShowDialog();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                throw;
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Do you want to delete this grade?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return;
            }
            string connectionString = "Server=localhost;Database=school;Uid=root;Pwd=root;";
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                string id = dgvAllGrades.CurrentRow.Cells["id"].Value.ToString();

                conn.Open();

                MySqlCommand cmd = new MySqlCommand($"DELETE FROM grades WHERE id={id}", conn);

                string affectedRows = cmd.ExecuteNonQuery().ToString();

                MessageBox.Show("Delete Successfully.Row affected" + affectedRows,
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An ereor occurred while connection to the database" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmCreateGrade student = new frmCreateGrade();
            student.ShowDialog();
        }
    }
}
