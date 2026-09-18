using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.DAL
{
    internal class StudentSubjectsDAL
    {
        string connString =
            ConfigurationManager.ConnectionStrings["MyDbConnection"]?.ConnectionString
            ?? string.Empty;
        public bool Insert(int studentId, int subjectId)
        {
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                conn.Open();

                // Check duplicate
                MySqlCommand checkCmd = new MySqlCommand(@"
            SELECT COUNT(*)
            FROM student_subjects
            WHERE student_id = @student_id
            AND subject_id = @subject_id
        ", conn);

                checkCmd.Parameters.AddWithValue("@student_id", studentId);
                checkCmd.Parameters.AddWithValue("@subject_id", subjectId);

                int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (count > 0)
                {
                    return true;
                }

                // Insert
                MySqlCommand cmd = new MySqlCommand(@"
            INSERT INTO student_subjects
            (
                student_id,
                subject_id
            )
            VALUES
            (
                @student_id,
                @subject_id
            )
        ", conn);

                cmd.Parameters.AddWithValue("@student_id", studentId);
                cmd.Parameters.AddWithValue("@subject_id", subjectId);

                int result = cmd.ExecuteNonQuery();

                return result > 0;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(
                    "Error inserting student subject: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool Delete(int studentId, int subjectId)
        {
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(@"
            DELETE FROM student_subjects
            WHERE student_id = @student_id
            AND subject_id = @subject_id
        ", conn);

                cmd.Parameters.AddWithValue("@student_id", studentId);
                cmd.Parameters.AddWithValue("@subject_id", subjectId);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(
                    "Error deleting student subject: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
