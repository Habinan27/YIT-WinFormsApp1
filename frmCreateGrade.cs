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
    public partial class frmCreateGrade : Form
    {
        public frmCreateGrade()
        {
            InitializeComponent();
        }

        private void frmCreateGrade_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=school;Uid=root;Pwd=root;";
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                // Validation

                if (txtGradeName.Text == "")
                {
                    MessageBox.Show("Please enter Grade Name");
                    txtGradeName.Focus();
                    return;
                }

                if (txtGradeGroup.Text == "")
                {
                    MessageBox.Show("Please enter Grade Group");
                    txtGradeGroup.Focus();
                    return;
                }

                if (txtGradeOrder.Text == "")
                {
                    MessageBox.Show("Please enter Grade Order");
                    txtGradeOrder.Focus();
                    return;
                }

                if (txtGradeColour.Text == "")
                {
                    MessageBox.Show("Please enter Grade Colour");
                    txtGradeColour.Focus();
                    return;
                }

                conn.Open();

                MySqlCommand cmd = new MySqlCommand(
                    $"INSERT INTO grades (grade_name,grade_group,grade_order,colour) VALUES ('{txtGradeName.Text}','{txtGradeGroup.Text}','{txtGradeOrder.Text}','{txtGradeColour.Text}')",
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
