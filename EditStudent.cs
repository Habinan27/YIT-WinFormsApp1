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
    public partial class EditStudent : Form
    {
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
        public EditStudent(string studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
            this.Load += Editstudent_load;
        }

        private void Editstudent_load(object sender, EventArgs e)
        {
  
            //txt_fname.Text = studentId;



            string connectionString = "Server=localhost;Database=school;Uid=root;Pwd=root;";
            MySqlConnection conn = new MySqlConnection(connectionString);

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

                string familyQuery = "SELECT id, fa_first_name FROM families";

                MySqlDataAdapter familyAdapter = new MySqlDataAdapter(familyQuery, conn);

                DataTable familyTable = new DataTable();
                familyAdapter.Fill(familyTable);

                cmbFamily.DataSource = familyTable;
                cmbFamily.DisplayMember = "fa_first_name";
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=school;Uid=root;Pwd=root;";
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand($"update students set admission_number='{txtAdmissionNo.Text}',first_name='{txtFirstName.Text}',last_name='{txtLastName.Text}',per_address='{txtAddress.Text}',nic_number='{txtNIC.Text}',tele_number='{txtTel.Text}',birth_certificate_number='{txtBirthNo.Text}',grade_id='{cmbGrade.SelectedValue}',house_id='{cmbHouse.SelectedValue}',medium='{cmbMedium.Text}',family_id='{cmbFamily.SelectedValue}' where id={this.studentId}",conn);

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
    }
}
