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
    internal class StudentDal
    {
        string connString = ConfigurationManager.ConnectionStrings["MyDbConnection"]?.ConnectionString ?? string.Empty;
        public async Task<DataTable>GetAll()
        {
           
            DataTable dt = new DataTable();

            try
            {
                await using MySqlConnection conn = new MySqlConnection(connString);
                await conn.OpenAsync();

                await using MySqlCommand cmd = new MySqlCommand(@"
            SELECT 
                students.id,
                students.admission_number,
                students.first_name,
                students.last_name,
                students.gender,
                students.date_of_birth,
                students.nic_number,
                students.birth_certificate_number,
                students.tele_number,
                students.per_address,

                grades.grade_name AS grade_name,
                houses.house_name AS house_name,
                families.mobile_number AS family_mobile,

                students.medium,
                students.date_of_admission

            FROM students

            LEFT JOIN grades
                ON students.grade_id = grades.id

            LEFT JOIN houses
                ON students.house_id = houses.id

            LEFT JOIN families
                ON students.family_id = families.id
        ", conn);

                await using MySqlDataReader reader = await cmd.ExecuteReaderAsync();
                dt.Load(reader);

                return dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(
                    "Error occurred while fetching student data.\n" + ex.Message,
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

                MySqlCommand cmd = new MySqlCommand(@"
            SELECT 
                students.*,
                grades.grade_name AS grade_name,
                houses.house_name AS house_name,
                families.mobile_number AS family_mobile
            FROM students
            LEFT JOIN grades 
                ON students.grade_id = grades.id
            LEFT JOIN houses 
                ON students.house_id = houses.id
            LEFT JOIN families 
                ON students.family_id = families.id
            WHERE students.id = @id", conn);

                cmd.Parameters.AddWithValue("@id", id);

               await using MySqlDataReader reader = await cmd.ExecuteReaderAsync();

                dt.Load(reader);

                return dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(
                    "Error occurred while fetching student data.\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return dt;
            }
           
        }

        public async Task<bool>Delete(string id)
        {
            try
            {
                await using MySqlConnection conn = new MySqlConnection(connString);
                await conn.OpenAsync();

                MySqlCommand cmd = new MySqlCommand(
                    "DELETE FROM students WHERE id = @id", conn);

                cmd.Parameters.AddWithValue("@id", id);

                int result = cmd.ExecuteNonQuery();

                return result > 0;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(
                    "Error occurred while deleting student.\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
        }

        public async Task<bool> Insert(
                    string admissionNumber,
                    string firstName,
                    string lastName,
                    string gender,
                    DateTime dateOfBirth,
                    string nicNumber,
                    string birthCertificateNumber,
                    string telephone,
                    string address,
                    string gradeId,
                    string houseName,
                    string medium,
                    string familyMobile,
                    DateTime dateOfAdmission)
        {
            try
            {
                await using MySqlConnection conn = new MySqlConnection(connString);
                await conn.OpenAsync();

                // Check House
                string houseId = "";

                MySqlCommand houseCheckCmd = new MySqlCommand(
                    "SELECT id FROM houses WHERE house_name = @house_name LIMIT 1",
                    conn);

                houseCheckCmd.Parameters.AddWithValue("@house_name", houseName);

                object houseResult = houseCheckCmd.ExecuteScalar();

                if (houseResult != null)
                {
                    houseId = houseResult.ToString();
                }
                else
                {
                    MySqlCommand houseCmd = new MySqlCommand(
                        "INSERT INTO houses (house_name) VALUES (@house_name)",
                        conn);

                    houseCmd.Parameters.AddWithValue("@house_name", houseName);
                    houseCmd.ExecuteNonQuery();

                    houseId = houseCmd.LastInsertedId.ToString();
                }


                // Check Family
                string familyId = "";

                MySqlCommand familyCheckCmd = new MySqlCommand(
                    "SELECT id FROM families WHERE mobile_number = @mobile_number LIMIT 1",
                    conn);

                familyCheckCmd.Parameters.AddWithValue("@mobile_number", familyMobile);

                object familyResult = familyCheckCmd.ExecuteScalar();

                if (familyResult != null)
                {
                    familyId = familyResult.ToString();
                }
                else
                {
                    MySqlCommand familyCmd = new MySqlCommand(
                        "INSERT INTO families (mobile_number) VALUES (@mobile_number)",
                        conn);

                    familyCmd.Parameters.AddWithValue("@mobile_number", familyMobile);
                    familyCmd.ExecuteNonQuery();

                    familyId = familyCmd.LastInsertedId.ToString();
                }


                // Insert Student
                MySqlCommand cmd = new MySqlCommand(@"
                        INSERT INTO students
                        (
                            admission_number,
                            first_name,
                            last_name,
                            gender,
                            date_of_birth,
                            nic_number,
                            birth_certificate_number,
                            tele_number,
                            per_address,
                            grade_id,
                            house_id,
                            medium,
                            date_of_admission,
                            family_id
                        )
                        VALUES
                        (
                            @admission_number,
                            @first_name,
                            @last_name,
                            @gender,
                            @date_of_birth,
                            @nic_number,
                            @birth_certificate_number,
                            @tele_number,
                            @per_address,
                            @grade_id,
                            @house_id,
                            @medium,
                            @date_of_admission,
                            @family_id
                        )",
                                conn);

                cmd.Parameters.AddWithValue("@admission_number", admissionNumber);
                cmd.Parameters.AddWithValue("@first_name", firstName);
                cmd.Parameters.AddWithValue("@last_name", lastName);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@date_of_birth", dateOfBirth);
                cmd.Parameters.AddWithValue("@nic_number", nicNumber);
                cmd.Parameters.AddWithValue("@birth_certificate_number", birthCertificateNumber);
                cmd.Parameters.AddWithValue("@tele_number", telephone);
                cmd.Parameters.AddWithValue("@per_address", address);
                cmd.Parameters.AddWithValue("@grade_id", gradeId);
                cmd.Parameters.AddWithValue("@house_id", houseId);
                cmd.Parameters.AddWithValue("@medium", medium);
                cmd.Parameters.AddWithValue("@date_of_admission", dateOfAdmission);
                cmd.Parameters.AddWithValue("@family_id", familyId);

                int result = cmd.ExecuteNonQuery();

                return result > 0;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(
                    "Error occurred while inserting student.\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
        }

        public async Task<bool> Update(
                    string id,
                    string admissionNumber,
                    string firstName,
                    string lastName,
                    string gender,
                    string nicNumber,
                    string birthCertificateNumber,
                    string telephone,
                    string address,
                    string gradeId,
                    string houseName,
                    string medium,
                    string familyMobile,
                    DateTime dateOfBirth,
                    DateTime dateOfAdmission)
        {
           

            try
            {
                await using MySqlConnection conn = new MySqlConnection(connString);
                await conn.OpenAsync();

                // Get existing house_id and family_id
                MySqlCommand getIdCmd = new MySqlCommand(@"
            SELECT house_id, family_id
            FROM students
            WHERE id = @id
        ", conn);

                getIdCmd.Parameters.AddWithValue("@id", id);

                int houseId = 0;
                int familyId = 0;

                using (MySqlDataReader reader = getIdCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        if (reader["house_id"] != DBNull.Value)
                            houseId = Convert.ToInt32(reader["house_id"]);

                        if (reader["family_id"] != DBNull.Value)
                            familyId = Convert.ToInt32(reader["family_id"]);
                    }
                }

                // Update House
                if (houseId > 0)
                {
                    MySqlCommand houseCmd = new MySqlCommand(@"
                            UPDATE houses
                            SET house_name = @house_name
                            WHERE id = @house_id
                        ", conn);

                    houseCmd.Parameters.AddWithValue("@house_name", houseName);
                    houseCmd.Parameters.AddWithValue("@house_id", houseId);

                    houseCmd.ExecuteNonQuery();
                }

                // Update Family
                if (familyId > 0)
                {
                    MySqlCommand familyCmd = new MySqlCommand(@"
                UPDATE families
                SET mobile_number = @mobile_number
                WHERE id = @family_id
            ", conn);

                    familyCmd.Parameters.AddWithValue("@mobile_number", familyMobile);
                    familyCmd.Parameters.AddWithValue("@family_id", familyId);

                    familyCmd.ExecuteNonQuery();
                }

                // Update Student
                MySqlCommand cmd = new MySqlCommand(@"
            UPDATE students
            SET
                admission_number = @admission_number,
                first_name = @first_name,
                last_name = @last_name,
                gender = @gender,
                nic_number = @nic_number,
                birth_certificate_number = @birth_certificate_number,
                tele_number = @tele_number,
                per_address = @per_address,
                grade_id = @grade_id,
                medium = @medium,
                date_of_birth = @date_of_birth,
                date_of_admission = @date_of_admission
            WHERE id = @id
        ", conn);

                cmd.Parameters.AddWithValue("@admission_number", admissionNumber);
                cmd.Parameters.AddWithValue("@first_name", firstName);
                cmd.Parameters.AddWithValue("@last_name", lastName);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@nic_number", nicNumber);
                cmd.Parameters.AddWithValue("@birth_certificate_number", birthCertificateNumber);
                cmd.Parameters.AddWithValue("@tele_number", telephone);
                cmd.Parameters.AddWithValue("@per_address", address);
                cmd.Parameters.AddWithValue("@grade_id", gradeId);
                cmd.Parameters.AddWithValue("@medium", medium);
                cmd.Parameters.AddWithValue("@date_of_birth", dateOfBirth);
                cmd.Parameters.AddWithValue("@date_of_admission", dateOfAdmission);
                cmd.Parameters.AddWithValue("@id", id);

                int result = cmd.ExecuteNonQuery();

                return result > 0;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(
                    "Error occurred while updating student.\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
        }

    }
}