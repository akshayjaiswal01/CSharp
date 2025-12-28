using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp.Dal
{
    public class LoginDBContext
    {
        String connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=dac01;Integrated Security=True";

        internal bool checkUsername(string? username)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            String selectQuery = "SELECT COUNT(1) FROM users WHERE username = @username";

            SqlCommand cmd = new SqlCommand(selectQuery, conn);

            cmd.Parameters.AddWithValue("@username", username);

            conn.Open();

            int count = (int)cmd.ExecuteScalar();

            conn.Close();

            return count > 0;

        }

        internal bool registerUser(string? registerusername, string? registerpassword)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            String insertQuery = "INSERT INTO users(username, password) VALUES(@username, @password)";

            SqlCommand cmd = new SqlCommand(insertQuery, conn);

            cmd.Parameters.AddWithValue("@username", registerusername);
            cmd.Parameters.AddWithValue("@password", registerpassword);

            conn.Open();

            int rowAffected = cmd.ExecuteNonQuery();

            conn.Close();

            return rowAffected > 0;
        }

        internal bool updatePassword(string? username, string? newPassword)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            String updateQuery = "UPDATE users SET password = @password WHERE username = @username";

            SqlCommand cmd = new SqlCommand(updateQuery, conn);

            cmd.Parameters.AddWithValue("@password", newPassword);
            cmd.Parameters.AddWithValue("@username", username);

            conn.Open();

            int rowAffected = cmd.ExecuteNonQuery();

            conn.Close();

            return rowAffected > 0;
        }

        internal bool validateUser(string? username, string? password)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            String selectQuery = "SELECT COUNT(1) FROM users WHERE username = @username AND password = @password";

            SqlCommand cmd = new SqlCommand(selectQuery, conn);

            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            conn.Open();

            int count = (int)cmd.ExecuteScalar();

            conn.Close();   

            return count > 0;
        }
    }
}
