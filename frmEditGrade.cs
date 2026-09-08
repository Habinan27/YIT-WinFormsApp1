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

        private void frmEditGrade_Load(object sender, EventArgs e)
        {
            //string connectionString = "Server=localhost;Database=school;Uid=root;Pwd=root;";
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand($"select * from grades where id={this.gradeId}", conn);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //string connectionString = "Server=localhost;Database=school;Uid=root;Pwd=root;";
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand($"update grades set grade_name='{txtGradeName.Text}',grade_group='{txtGradeGroup.Text}',grade_order='{txtGradeOrder.Text}',colour='{gradeColour}' where id={this.gradeId}", conn);

                string affectedRows = cmd.ExecuteNonQuery().ToString();
                MessageBox.Show("Update Successfully.Row affected" + affectedRows, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
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