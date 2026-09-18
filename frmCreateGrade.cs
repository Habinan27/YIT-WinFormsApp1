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
    public partial class frmCreateGrade : Form
    {
        string connString = ConfigurationManager.ConnectionStrings["MyDbConnection"]?.ConnectionString ?? string.Empty;
        string gradeColour = "";
        public frmCreateGrade()
        {
            InitializeComponent();
        }
        private void InsertGrade()
        {
            GradeDAL gradeDAL = new GradeDAL();

            bool inserted = gradeDAL.Insert(
                txtGradeName.Text,
                txtGradeGroup.Text,
                txtGradeOrder.Text,
                gradeColour
            );

            if (inserted)
            {
                MessageBox.Show(
                    "Grade inserted successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.Close();
            }
        }

        private void frmCreateGrade_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //string connectionString = "Server=localhost;Database=school;Uid=root;Pwd=root;";
            MySqlConnection conn = new MySqlConnection(connString);

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

                if (gradeColour == "")
                {
                    MessageBox.Show("Please select a colour.");
                    return;
                }

                InsertGrade();
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

        private void btnChooseColour_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                gradeColour = ColorTranslator.ToHtml(colorDialog1.Color);
                btnChooseColour.BackColor = colorDialog1.Color;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
