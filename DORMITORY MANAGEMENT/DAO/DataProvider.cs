using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DORMITORY_MANAGEMENT.DAO
{
    public class DataProvider
    {

        private static DataProvider instance;

        private string connectionString = @"Data Source=vandunxg;Initial Catalog=DormitoryManagement;Integrated Security=True";

        private DataProvider() { }

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { instance = value; }

        }

        public DataTable ExcuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand sqlCommand = new SqlCommand(query, connection); // Sửa đổi đối số thứ hai thành query

                if (parameter != null)
                {
                    string[] listQuery = query.Split(' '); // Split chuỗi query để lấy tên tham số
                    int index = 0;

                    foreach (string item in listQuery)
                    {
                        if (item.Contains('@'))
                        {
                            sqlCommand.Parameters.AddWithValue(item, parameter[index]);
                            index++;
                        }
                    }
                }

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(data);

                connection.Close();
            }

            return data;
        }

        public int ExcuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(connectionString)) // Using có tác dụng khi kết thúc chương trình thì connection tự giải phóng

            {
                connection.Open();

                SqlCommand sqlCommand = new SqlCommand(connectionString, connection);

                if (parameter != null)
                {
                    string[] listQuery = query.Split(' ');
                    int index = 0;

                    foreach (string item in listQuery)
                    {
                        if (item.Contains('@'))
                        {
                            sqlCommand.Parameters.AddWithValue(item, parameter[index++]);
                        }
                    }
                }


                data = sqlCommand.ExecuteNonQuery();


                connection.Close();

            }

            return data;
        }

        public object ExcuteScalarQuery(string query, object[] parameter = null)
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(connectionString)) // Using có tác dụng khi kết thúc chương trình thì connection tự giải phóng

            {
                connection.Open();

                SqlCommand sqlCommand = new SqlCommand(connectionString, connection);

                if (parameter != null)
                {
                    string[] listQuery = query.Split(' ');
                    int index = 0;

                    foreach (string item in listQuery)
                    {
                        if (item.Contains('@'))
                        {
                            sqlCommand.Parameters.AddWithValue(item, parameter[index++]);
                        }
                    }
                }


                data = sqlCommand.ExecuteScalar();


                connection.Close();

            }

            return data;
        }

        public void ExcuteQueryCommand(string query, object[] parameter = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString)) // Using có tác dụng khi kết thúc chương trình thì connection tự giải phóng

            {
                connection.Open();

                SqlCommand sqlCommand = new SqlCommand(connectionString, connection);

                if (parameter != null)
                {
                    string[] listQuery = query.Split(' ');
                    int index = 0;

                    foreach (string item in listQuery)
                    {
                        if (item.Contains('@'))
                        {
                            sqlCommand.Parameters.AddWithValue(item, parameter[index++]);
                        }
                    }
                }
            }
        }

        public DataSet ExcuteQueryDataSet(string query, object[] parameter = null)
        {
            DataSet data = new DataSet();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand sqlCommand = new SqlCommand(query, connection); // Sửa đổi đối số thứ hai thành query

                if (parameter != null)
                {
                    string[] listQuery = query.Split(' '); // Split chuỗi query để lấy tên tham số
                    int index = 0;

                    foreach (string item in listQuery)
                    {
                        if (item.Contains('@'))
                        {
                            sqlCommand.Parameters.AddWithValue(item, parameter[index]);
                            index++;
                        }
                    }
                }

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(data);

                connection.Close();
            }

            return data;
        }

        
    }
}
