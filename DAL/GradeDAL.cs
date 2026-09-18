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

        public DataTable GetAll()
        {
            MySqlConnection conn = new MySqlConnection(connString);
            DataTable dt = new DataTable();

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(
                    "SELECT * FROM grades",
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


        
        public DataTable GetById(string id)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            DataTable dt = new DataTable();

            try
            {
                conn.Open();

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
            finally
            {
                conn.Close();
            }
        }


        public bool Insert(
            string gradeName,
            string gradeGroup,
            string gradeOrder,
            string colour)
        {
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                conn.Open();

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
            finally
            {
                conn.Close();
            }
        }


    
        public bool Update(
            string id,
            string gradeName,
            string gradeGroup,
            string gradeOrder,
            string colour)
        {
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                conn.Open();

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
            finally
            {
                conn.Close();
            }
        }


        // =========================
        // DELETE GRADE
        // =========================
        public bool Delete(string id)
        {
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                conn.Open();

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
            finally
            {
                conn.Close();
            }
        }
    }
}