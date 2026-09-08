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
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    public partial class databaseconnect : Form
    {
        private object studentId;

        string connString = ConfigurationManager.ConnectionStrings["MyDbConnection"]?.ConnectionString ?? string.Empty;

        public databaseconnect()
        {
            InitializeComponent();

            if (string.IsNullOrWhiteSpace(connString))
            {
                MessageBox.Show("Datebase connection string is missing. Please cheak your configuration","Configuration Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
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

        private void btnAllStudent_Click(object sender, EventArgs e)
        {
            //string connString = "Server=localhost;Port=3306;Database=school;Uid=root;Pwd=root;";
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                conn.Open();
                //MySqlCommand cmd = new MySqlCommand("SELECT * FROM students", conn);
                MySqlCommand cmd = new MySqlCommand(@"
            SELECT 
                s.id,
                s.admission_number,
                s.first_name,
                s.last_name,
                s.gender,
                s.date_of_birth,
                s.nic_number,
                s.birth_certificate_number,
                s.tele_number,
                h.house_name AS house_name,
                g.grade_name AS grade_name,
                s.medium,
                s.date_of_admission,
                s.per_address,
                f.mobile_number AS family_mobile
            FROM students s
            LEFT JOIN houses h ON s.house_id = h.id
            LEFT JOIN grades g ON s.grade_id = g.id
            LEFT JOIN families f ON s.family_id = f.id
        ", conn);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dcvAllStudent.DataSource = dt;
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

        private void dcvAllStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                if (dcvAllStudent.Rows.Count == 0)
                {
                    MessageBox.Show("No data not fount", "information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string admissionNumber = dcvAllStudent.CurrentRow.Cells["admission_number"].Value.ToString();
                string fname = dcvAllStudent.CurrentRow.Cells["first_name"].Value.ToString();
                string lname = dcvAllStudent.CurrentRow.Cells["last_name"].Value.ToString();
                string gender = dcvAllStudent.CurrentRow.Cells["gender"].Value.ToString();
                string dob = dcvAllStudent.CurrentRow.Cells["date_of_birth"].Value.ToString();
                string nic = dcvAllStudent.CurrentRow.Cells["nic_number"].Value.ToString();
                string birthCertificate = dcvAllStudent.CurrentRow.Cells["birth_certificate_number"].Value.ToString();
                string telephone = dcvAllStudent.CurrentRow.Cells["tele_number"].Value.ToString();
                string house = dcvAllStudent.CurrentRow.Cells["house_id"].Value.ToString();
                string grade = dcvAllStudent.CurrentRow.Cells["grade_id"].Value.ToString();
                string medium = dcvAllStudent.CurrentRow.Cells["medium"].Value.ToString();
                string admissionDate = dcvAllStudent.CurrentRow.Cells["date_of_admission"].Value.ToString();
                string address = dcvAllStudent.CurrentRow.Cells["per_address"].Value.ToString();
                string family = dcvAllStudent.CurrentRow.Cells["family_id"].Value.ToString();

                ShowInformation showInformation = new ShowInformation(
                    admissionNumber,
                    fname,
                    lname,
                    gender,
                    dob,
                    nic,
                    birthCertificate,
                    telephone,
                    house,
                    grade,
                    medium,
                    admissionDate,
                    address,
                    family
                );

                showInformation.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


















            //try
            //{
            //    if (dcvAllStudent.Rows.Count == 0)
            //    {
            //        MessageBox.Show("No data not fount", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        return;
            //    }
            //    string fname = dcvAllStudent.CurrentRow.Cells["first_name"].Value.ToString();
            //    txtFname.Text = fname;

            //    string lname = dcvAllStudent.CurrentRow.Cells["last_name"].Value.ToString();
            //    txtLname.Text = lname;

            //    string address = dcvAllStudent.CurrentRow.Cells["per_address"].Value.ToString();
            //    txtAddress.Text = address;

            //    string grade = dcvAllStudent.CurrentRow.Cells["grade_id"].Value.ToString();
            //    cmbGrade.Text = grade;

            //    string gender = dcvAllStudent.CurrentRow.Cells["gender"].Value.ToString();

            //    if (gender == "M")
            //    {
            //        rdoMale.Checked = true;
            //    }
            //    else if (gender == "F")
            //    {
            //        rdoFemale.Checked = true;
            //    }


            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Please select a row first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            //try
            //{
            //    string fname = dcvAllStudent.CurrentRow.Cells["first_name"].Value.ToString();

            //    string lname = dcvAllStudent.CurrentRow.Cells["last_name"].Value.ToString();

            //    string address = dcvAllStudent.CurrentRow.Cells["address"].Value.ToString();

            //    showStudent show = new showStudent(fname, lname, address);
            //    f.showDailog();

            //}
            //catch
            //{

            //}

            //try
            //{
            //    if (dcvAllStudent.Rows.Count == 0)
            //    {
            //        MessageBox.Show("No data not fount", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        return;
            //    }



            //string fname = dcvAllStudent.CurrentRow.Cells["first_name"].Value.ToString();

            //string lname = dcvAllStudent.CurrentRow.Cells["last_name"].Value.ToString();

            //string address = dcvAllStudent.CurrentRow.Cells["address"].Value.ToString();

            //showStudent show = new showStudent(fname, lname, address);
            //show.Show();

            //this.Hide();


            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Please select a row first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            //try
            //{
            //    string fname = dcvAllStudent.CurrentRow.Cells["first_name"].Value.ToString();

            //    string lname = dcvAllStudent.CurrentRow.Cells["last_name"].Value.ToString();

            //    string address = dcvAllStudent.CurrentRow.Cells["address"].Value.ToString();

            //    showStudent show = new showStudent(fname, lname, address);
            //    show.ShowDialog();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Please select a row first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    throw;
            //}
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    //string connectionString = "Server=localhost;Database=school;Uid=root;Pwd=root;";
        //    MySqlConnection conn = new MySqlConnection(connString);

        //    try
        //    {
        //        conn.Open();
        //        MySqlCommand cmd = new MySqlCommand("SELECT * FROM grades", conn);

        //        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        //        DataTable dt = new DataTable();
        //        da.Fill(dt);
        //        cmbGrade.DataSource = dt;
        //        cmbGrade.DisplayMember = "grade_name";
        //        cmbGrade.ValueMember = "id";
        //    }
        //    catch (MySqlException ex)
        //    {
        //        MessageBox.Show("Error occurred while fetching student data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show(cmbGrade.SelectedIndex.ToString());
        //}

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    cmbGrade.SelectedIndex = 0;
        //}

        private void rdoMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnDBShow_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dcvAllStudent.CurrentRow.Cells["id"].Value.ToString();
                frmshowstudent f = new frmshowstudent(id);
                f.ShowDialog();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                throw;
            }
        }

        private void databaseconnect_Load(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string id = dcvAllStudent.CurrentRow.Cells["id"].Value.ToString();

            EditStudent f = new EditStudent(id);

            f.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Do you want to delete this student?",
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
                string id = dcvAllStudent.CurrentRow.Cells["id"].Value.ToString();

                conn.Open();

                MySqlCommand cmd = new MySqlCommand($"DELETE FROM students WHERE id={id}", conn);

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
            frmStudent student = new frmStudent();
            student.ShowDialog();
        }
    }
}
