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
    public partial class frmShowGrade : Form
    {
        string gradeId;
        string gradeColour;
        string connString = ConfigurationManager.ConnectionStrings["MyDbConnection"]?.ConnectionString ?? string.Empty;
        public frmShowGrade(string? id)
        {
            InitializeComponent();
            this.gradeId = id;

        }

        private void frmShowGrade_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                

                GradeDAL gradeDAL = new GradeDAL();
                DataTable dt = gradeDAL.GetById(gradeId);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "Grade not found",
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    return;
                }

                DataRow dr = dt.Rows[0];

                txtGradeName.Text = dr["grade_name"].ToString();
                txtGradeGroup.Text = dr["grade_group"].ToString();
                txtGradeOrder.Text = dr["grade_order"].ToString();
                gradeColour = dr["colour"].ToString();
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                conn.Close();
            }
        }
    }
}