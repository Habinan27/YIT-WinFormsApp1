using MySqlConnector;
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
        string connString =ConfigurationManager.ConnectionStrings["MyDbConnection"]?.ConnectionString ?? string.Empty;

        public async Task <DataTable> GetAll()
        {
            DataTable dt = new DataTable();
            try
            {
                await using MySqlConnection conn = new MySqlConnection(connString);
                await conn.OpenAsync();

                await using MySqlCommand cmd = new MySqlCommand(
                    "SELECT * FROM subjects",
                    conn);

                await using MySqlDataReader reader = await cmd.ExecuteReaderAsync();
                dt.Load(reader);

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
           
        }

        

        public async Task<DataTable> GetSelectedSubjects(int studentId)
        {
            await using MySqlConnection conn = new MySqlConnection(connString);
            DataTable dt = new DataTable();

            try
            {
                await conn.OpenAsync();

                await using MySqlCommand cmd = new MySqlCommand(@"
            SELECT subject_id
            FROM student_subjects
            WHERE student_id = @student_id
        ", conn);

                cmd.Parameters.AddWithValue("@student_id", studentId);

                await using MySqlDataReader reader = await cmd.ExecuteReaderAsync();

                dt.Load(reader);

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
            
        }
    }
}
