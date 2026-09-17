using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.DAL
{
    internal class SubjectDAL
    {
        string connString =
            ConfigurationManager.ConnectionStrings["MyDbConnection"]?.ConnectionString
            ?? string.Empty;

        public DataTable GetAll()
        {
            MySqlConnection conn = new MySqlConnection(connString);
            DataTable dt = new DataTable();

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(
                    "SELECT * FROM subjects",
                    conn);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);

                return dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(
                    $"Error retrieving grade data: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return dt;
            }
            finally
            {
                conn.Close();
            }
        }

        

        public DataTable GetSelectedSubjects(int studentId)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            DataTable dt = new DataTable();

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(@"
            SELECT subject_id
            FROM student_subjects
            WHERE student_id = @student_id
        ", conn);

                cmd.Parameters.AddWithValue("@student_id", studentId);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);

                return dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(
                    "Error occurred while fetching selected subjects.\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return dt;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
