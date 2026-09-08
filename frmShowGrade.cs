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
    }
}