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
using WinFormsApp1.DAL;

namespace WinFormsApp1
{
    public partial class frmAddSubject : Form
    {
        private int studentId;

        public frmAddSubject(int id)
        {
            InitializeComponent();

            studentId = id;
        }

        private void frmAddSubject_Load(object sender, EventArgs e)
        {
            StudentDal studentDal = new StudentDal();

            // Get selected student
            DataTable dtStudent =studentDal.GetById(studentId.ToString());

            DataRow studentRow = dtStudent.Rows[0];

            // Show student information
            txtStudentID.Text =studentRow["id"].ToString();

            txtStudentName.Text =studentRow["first_name"].ToString() + " " + studentRow["last_name"].ToString();

            txtAdmissionNo.Text =studentRow["admission_number"].ToString();


            // Get all subjects
            SubjectDAL subjectDAL = new SubjectDAL();

            DataTable dtSubjects =subjectDAL.GetAll();

            clbSubjects.DataSource = dtSubjects;
            clbSubjects.DisplayMember = "subject_name";
            clbSubjects.ValueMember = "id";

            DataTable dtSelectedSubjects = subjectDAL.GetSelectedSubjects(studentId);

            for (int i = 0; i < clbSubjects.Items.Count; i++)
            {
                DataRowView item =
                    (DataRowView)clbSubjects.Items[i];

                int subjectId =
                    Convert.ToInt32(item["id"]);

                foreach (DataRow row in dtSelectedSubjects.Rows)
                {
                    int selectedSubjectId =
                        Convert.ToInt32(row["subject_id"]);

                    if (subjectId == selectedSubjectId)
                    {
                        clbSubjects.SetItemChecked(i, true);
                        break;
                    }
                }

            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            StudentSubjectsDAL studentSubjectsDAL = new StudentSubjectsDAL();

            for (int i = 0; i < clbSubjects.Items.Count; i++)
            {
                DataRowView item = (DataRowView)clbSubjects.Items[i];

                int subjectId = Convert.ToInt32(item["id"]);

                if (clbSubjects.GetItemChecked(i))
                {
                    studentSubjectsDAL.Insert(studentId, subjectId);
                }
                else
                {
                    studentSubjectsDAL.Delete(studentId, subjectId);
                }
            }

            MessageBox.Show("Subjects updated successfully.");

            this.Close();
        }
    }
}
