using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QUANLYDETAI.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;
        private string connectionStr = @"Data Source=DESKTOP-3E1USBR\SQLEXPRESS;Initial Catalog=QuanLyDeTai;Integrated Security=True";
        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return instance; }
            private set => instance = value;
        }
        private DataProvider() { }
        private void AddParameter(string query, object[] parameter, SqlCommand command)
        {
            if (parameter != null)
            {
                string[] listParameter = query.Split(' ');
                int i = 0;
                foreach (string item in listParameter)
                {
                    if (item.Contains("@"))
                    {
                        command.Parameters.AddWithValue(item, parameter[i]);
                        ++i;
                    }
                }
            }
        }
        public DataTable ExcuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(connectionStr))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                AddParameter(query, parameter, sqlCommand);
                //trung gian lay du lieu
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(data);
                sqlConnection.Close();
            }
            return data;
        }
        public int ExcuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection sqlConnection = new SqlConnection(connectionStr))
            {
                sqlConnection.Open();
                //cau try van se thuc thi
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                AddParameter(query, parameter, sqlCommand);
                data = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            return data;
        }
        public object ExcuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection sqlConnection = new SqlConnection(connectionStr))
            {
                sqlConnection.Open();
                //cau try van se thuc thi
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                AddParameter(query, parameter, sqlCommand);
                data = sqlCommand.ExecuteScalar();
                sqlConnection.Close();
            }
            return data;
        }
    }
}
