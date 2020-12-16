using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuanLyRapPhim.NewFolder1
{
    public class DataProvider
    {
        private string connectionSTR = "Data Source=DESKTOP-0599NKT\\SQLEXPRESS;Initial Catalog=QuanLyRapPhim;Integrated Security=True";

        public static object Instance { get; internal set; }

        public DataTable ExecuteQuery(string query)
        {
                DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
            
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }


    }
}
