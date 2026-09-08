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
    public partial class frmshowstudent : Form
    {
        string connString = ConfigurationManager.ConnectionStrings["MyDbConnection"]?.ConnectionString ?? string.Empty;
        //private int studentITd;
        //public frmshowstudent()
        //{
        //    InitializeComponent();

        //}



        //private void ShowStudent_Load(object sender, EventArgs e)
        //{
        //    string connectionString = "Server=localhost;Database=school;Uid=root;Pwd=root;";
        //    MySqlConnection conn = new MySqlConnection(connectionString);

        //    try
        //    {
        //        conn.Open();

        //        //--------------------------Load grades into ComboBox-------------------------------
        //        string gradeQuery = "SELECT id, grade_name FROM grades";
        //        MySqlDataAdapter gradeAdapter = new MySqlDataAdapter(gradeQuery, conn);
        //        DataTable gradeTable = new DataTable();
        //        gradeAdapter.Fill(gradeTable);

        //        cmbGrade.DataSource = gradeTable;
        //        cmbGrade.DisplayMember = "grade_name";
        //        cmbGrade.ValueMember = "id";

        //        //-------------------------------Load Houses into ComboBox----------------------------
        //        string houseQuery = "SELECT id, house_name FROM houses";

        //        MySqlDataAdapter houseAdapter = new MySqlDataAdapter(houseQuery, conn);
        //        DataTable houseTable = new DataTable();
        //        houseAdapter.Fill(houseTable);

        //        cmbHouse.DataSource = houseTable;
        //        cmbHouse.DisplayMember = "house_name";
        //        cmbHouse.ValueMember = "id";

        //        //-------------------------------Load Families into ComboBox----------------------------

        //        string familyQuery = "SELECT id FROM families";

        //        MySqlDataAdapter familyAdapter =
        //            new MySqlDataAdapter(familyQuery, conn);

        //        DataTable familyTable = new DataTable();
        //        familyAdapter.Fill(familyTable);

        //        cmbFamily.DataSource = familyTable;
        //        cmbFamily.DisplayMember = "id";
        //        cmbFamily.ValueMember = "id";


        //        //-------------------------------Load Student Data into Form Controls--------------------------------
        //        MySqlCommand cmd = new MySqlCommand($"select * from students where id={this.studentITd}", conn);

        //        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        //        DataTable dt = new DataTable();

        //        da.Fill(dt);

        //        DataRow dr = dt.Rows[0];

        //        //-------------------------------Load Student Data into TextBoxes--------------------------------
        //        txtFirstName.Text = dr["first_name"].ToString();
        //        txtLastName.Text = dr["last_name"].ToString();
        //        txtAddress.Text = dr["per_address"].ToString();
        //        txtAdmissionNo.Text = dr["admission_number"].ToString();
        //        txtNIC.Text = dr["nic_number"].ToString();
        //        txtTel.Text = dr["tele_number"].ToString();

        //        //-------------------------------Load Gender---------------------------------
        //        string gender = dr["gender"].ToString();

        //        rdoMale.Checked = gender == "M";
        //        rdoFemale.Checked = gender == "F";

        //        //-------------------------------Load Grade into ComboBoxes--------------------------------
        //        if (dr["grade_id"] != DBNull.Value)
        //        {
        //            cmbGrade.SelectedValue = dr["grade_id"];
        //        }
        //        else
        //        {
        //            cmbGrade.SelectedIndex = -1;
        //            cmbGrade.Text = "N/A";
        //        }

        //        //-------------------------------Load Date of Birth into DateTimePicker--------------------------------
        //        if (dr["date_of_birth"] != DBNull.Value)

        //        {
        //            dtpDOB.Value =
        //                Convert.ToDateTime(dr["date_of_birth"]);
        //        }

        //        else
        //        {
        //            dtpDOB.Value = DateTime.Now;
        //        }


        //        //--------------------------------Load House into ComboBoxes--------------------------------
        //        if (dr["house_id"] != DBNull.Value)
        //        {
        //            int houseId = Convert.ToInt32(dr["house_id"]);

        //            cmbHouse.SelectedValue = houseId;
        //        }
        //        else
        //        {
        //            cmbHouse.SelectedIndex = -1;
        //            cmbHouse.Text = "N/A";
        //        }

        //        //-------------------------------Load Medium into ComboBoxes--------------------------------        
        //        if (dr["medium"] != DBNull.Value)
        //        {
        //            cmbMedium.Text =
        //                dr["medium"].ToString();
        //        }
        //        else
        //        {
        //            cmbMedium.Text = "N/A";
        //        }

        //        //---------------------Family ID-------------------------------------

        //        if (dr["family_id"] != DBNull.Value)
        //        {
        //            cmbFamily.SelectedValue = dr["family_id"].ToString();
        //        }
        //        else
        //        {
        //            cmbFamily.SelectedIndex = -1;
        //            cmbFamily.Text = "N/A";
        //        }


        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message.ToString());
        //    }

        //    finally
        //    {
        //        conn.Close();
        //    }
        //}
        string studentId;
        public frmshowstudent(string studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
        }

        private void Frmdbshow_Load(object sender, EventArgs e)
        {
            //txt_fname.Text = studentId;



            //string connectionString = "Server=localhost;Database=school;Uid=root;Pwd=root;";
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                conn.Open();

                //Load grades into ComboBox
                string gradeQuery = "SELECT id, grade_name FROM grades";
                MySqlDataAdapter gradeAdapter = new MySqlDataAdapter(gradeQuery, conn);
                DataTable gradeTable = new DataTable();
                gradeAdapter.Fill(gradeTable);

                cmbGrade.DataSource = gradeTable;
                cmbGrade.DisplayMember = "grade_name";
                cmbGrade.ValueMember = "id";

                //Load Houses into ComboBox
                string houseQuery = "SELECT id, house_name FROM houses";

                MySqlDataAdapter houseAdapter = new MySqlDataAdapter(houseQuery, conn);
                DataTable houseTable = new DataTable();
                houseAdapter.Fill(houseTable);

                cmbHouse.DataSource = houseTable;
                cmbHouse.DisplayMember = "house_name";
                cmbHouse.ValueMember = "id";

                //Load Families into ComboBox

                string familyQuery = "SELECT id FROM families";

                MySqlDataAdapter familyAdapter = new MySqlDataAdapter(familyQuery, conn);
                
                DataTable familyTable = new DataTable();
                familyAdapter.Fill(familyTable);

                cmbFamily.DataSource = familyTable;
                cmbFamily.DisplayMember = "id";
                cmbFamily.ValueMember = "id";


                //Load Student Data into Form Controls
                MySqlCommand cmd = new MySqlCommand($"select * from students where id={this.studentId}", conn);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);

                DataRow dr = dt.Rows[0];

                //Load Student Data into TextBoxes
                txtFirstName.Text = dr["first_name"].ToString();
                txtLastName.Text = dr["last_name"].ToString();
                txtAddress.Text = dr["per_address"].ToString();
                txtAdmissionNo.Text = dr["admission_number"].ToString();
                txtNIC.Text = dr["nic_number"].ToString();
                txtTel.Text = dr["tele_number"].ToString();
                txtBirthNo.Text = dr["birth_certificate_number"].ToString();

                //Load Gender
                string gender = dr["gender"].ToString();

                rdoMale.Checked = gender == "M";
                rdoFemale.Checked = gender == "F";

                //Load Grade into ComboBoxes
                if (dr["grade_id"] != DBNull.Value)
                {
                    cmbGrade.SelectedValue = dr["grade_id"];
                }
                else
                {
                    cmbGrade.SelectedIndex = -1;
                    cmbGrade.Text = "N/A";
                }

                //Load Date of Birth into DateTimePicker
                if (dr["date_of_birth"] != DBNull.Value)

                {
                    dtpDOB.Value =
                        Convert.ToDateTime(dr["date_of_birth"]);
                }

                else
                {
                    dtpDOB.Value = DateTime.Now;
                }

                //load Date of Admission into DateTimePicker
                if (dr["date_of_admission"] != DBNull.Value)

                {
                    dtpAdmission.Value =
                        Convert.ToDateTime(dr["date_of_birth"]);
                }

                else
                {
                    dtpAdmission.Value = DateTime.Now;
                }


                //Load House into ComboBoxes
                if (dr["house_id"] != DBNull.Value)
                {
                    int houseId = Convert.ToInt32(dr["house_id"]);

                    cmbHouse.SelectedValue = houseId;
                }
                else
                {
                    cmbHouse.SelectedIndex = -1;
                    cmbHouse.Text = "N/A";
                }

                //Load Medium into ComboBoxes
                if (dr["medium"] != DBNull.Value)
                {
                    cmbMedium.Text =
                        dr["medium"].ToString();
                }
                else
                {
                    cmbMedium.Text = "N/A";
                }

                //Family ID

                if (dr["family_id"] != DBNull.Value)
                {
                    cmbFamily.SelectedValue = dr["family_id"].ToString();
                }
                else
                {
                    cmbFamily.SelectedIndex = -1;
                    cmbFamily.Text = "N/A";
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

        private void lbl_familyid_Click(object sender, EventArgs e)
        {

        }


    }
}
