using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace KutuphaneYonetimSistemi1.DAL
{
    public class DbHelper
    {
        private string connectionString = "Server=172.21.54.253; Database=26_132430022; Uid=26_132430022; Pwd=İnif123.;";
        private MySqlConnection connection;

        public DbHelper()
        {
            connection = new MySqlConnection(connectionString);
        }

        public void OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
        }

        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }

        public DataTable GetDataTable(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                OpenConnection();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return dt;
        }

        public int ExecuteQuery(string query)
        {
            int result = 0;
            try
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return result;
        }

        // ✅ BUNU EKLİYORUZ
        public object ExecuteScalar(string query)
        {
            object result = null;
            try
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                result = cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return result;
        }




    }
}
