using MySqlConnector;
using System;
using System.Configuration;
using System.Data;

namespace WinFormsApp1.DAL
{
    internal class GradeDAL
    {
        string connString =
            ConfigurationManager.ConnectionStrings["MyDbConnection"]?.ConnectionString
            ?? string.Empty;

        public async Task<DataTable> GetAll()
        {
            DataTable dt = new DataTable();

            try
            {
                await using MySqlConnection conn = new MySqlConnection(connString);
                await conn.OpenAsync();

                await using MySqlCommand cmd = new MySqlCommand(
                    "SELECT * FROM grades",
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


        
        public async Task<DataTable> GetById(string id)
        {
            DataTable dt = new DataTable();

            try
            {
                await using MySqlConnection conn = new MySqlConnection(connString);
                await conn.OpenAsync();

                MySqlCommand cmd = new MySqlCommand(
                    "SELECT * FROM grades WHERE id = @id",
                    conn);

                cmd.Parameters.AddWithValue("@id", id);

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
            
        }


        public async Task <bool> Insert(
            string gradeName,
            string gradeGroup,
            string gradeOrder,
            string colour)
        {
            

            try
            {
                await using MySqlConnection conn = new MySqlConnection(connString);
                await conn.OpenAsync();

                MySqlCommand cmd = new MySqlCommand(@"
                    INSERT INTO grades
                    (
                        grade_name,
                        grade_group,
                        grade_order,
                        colour
                    )
                    VALUES
                    (
                        @grade_name,
                        @grade_group,
                        @grade_order,
                        @colour
                    )
                ", conn);

                cmd.Parameters.AddWithValue("@grade_name", gradeName);
                cmd.Parameters.AddWithValue("@grade_group", gradeGroup);
                cmd.Parameters.AddWithValue("@grade_order", gradeOrder);
                cmd.Parameters.AddWithValue("@colour", colour);

                int result = cmd.ExecuteNonQuery();

                return result > 0;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(
                    $"Error inserting grade: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
            
        }


    
        public async Task<bool> Update(
            string id,
            string gradeName,
            string gradeGroup,
            string gradeOrder,
            string colour)
        {
            

            try
            {
                await using MySqlConnection conn = new MySqlConnection(connString);
                await conn.OpenAsync();

                MySqlCommand cmd = new MySqlCommand(@"
                    UPDATE grades
                    SET
                        grade_name = @grade_name,
                        grade_group = @grade_group,
                        grade_order = @grade_order,
                        colour = @colour
                    WHERE id = @id
                ", conn);

                cmd.Parameters.AddWithValue("@grade_name", gradeName);
                cmd.Parameters.AddWithValue("@grade_group", gradeGroup);
                cmd.Parameters.AddWithValue("@grade_order", gradeOrder);
                cmd.Parameters.AddWithValue("@colour", colour);
                cmd.Parameters.AddWithValue("@id", id);

                int result = cmd.ExecuteNonQuery();

                return result > 0;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(
                    $"Error updating grade: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
           
        }


        // =========================
        // DELETE GRADE
        // =========================
        public async Task<bool> Delete(string id)
        {
            

            try
            {
                await using MySqlConnection conn = new MySqlConnection(connString);
                await conn.OpenAsync();

                MySqlCommand cmd = new MySqlCommand(
                    "DELETE FROM grades WHERE id = @id",
                    conn);

                cmd.Parameters.AddWithValue("@id", id);

                int result = cmd.ExecuteNonQuery();

                return result > 0;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(
                    $"Error deleting grade: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
        }
    }
}