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
using WinFormsApp1.DAL;

namespace WinFormsApp1
{
    public partial class frmEditGrade : Form
    {
        string gradeId;
        string gradeColour;

        string connString = ConfigurationManager.ConnectionStrings["MyDbConnection"]?.ConnectionString ?? string.Empty;
        public frmEditGrade(string? id)
        {
            InitializeComponent();
            this.gradeId = id;

        }
        private void UpdateGrade()
        {
            string gradeColour = ColorTranslator.ToHtml(
                btnChooseColour.BackColor);

            GradeDAL gradeDAL = new GradeDAL();

            bool updated = gradeDAL.Update(
                gradeId,
                txtGradeName.Text,
                txtGradeGroup.Text,
                txtGradeOrder.Text,
                gradeColour
            );

            if (updated)
            {
                MessageBox.Show(
                    "Grade updated successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.Close();
            }
        }
        private void frmLoadGrade()
        {
            GradeDAL gradeDAL = new GradeDAL();

            DataTable dt = gradeDAL.GetById(gradeId);

            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];

                txtGradeName.Text = dr["grade_name"].ToString();
                txtGradeGroup.Text = dr["grade_group"].ToString();
                txtGradeOrder.Text = dr["grade_order"].ToString();

                string gradeColour = dr["colour"].ToString();

                if (gradeColour != "")
                {
                    btnChooseColour.BackColor =
                        ColorTranslator.FromHtml(gradeColour);
                }
                else
                {
                    btnChooseColour.BackColor = SystemColors.Control;
                }
            }
            else
            {
                MessageBox.Show(
                    "Grade not found.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void frmEditGrade_Load(object sender, EventArgs e)
        {
            
            try
            {
                frmLoadGrade();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateGrade();
                frmLoadGrade();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An ereor occurred while connection to the database" + ex.Message);

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
    }
}