using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1._1
{
    public class DataProvider
    {
        private static DataProvider instance;


        public static  DataProvider Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataProvider();
                return DataProvider.instance;
            }

            private set
            {
                DataProvider.instance = value;
            }
        }
        public DataProvider()
        {
            
        }
        //kết nối database
        private static string CnnSQL = "Data Source=desktop-2kep5f0;Initial Catalog=QLThuVien;Integrated Security=True";
        public DataTable LoadDB(string query)
        {
            SqlConnection cnn = new SqlConnection(CnnSQL);
            cnn.Open();
            SqlCommand cmd = new SqlCommand(query, cnn);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(data);
            cnn.Close();
            return data;
        }
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection cnn = new SqlConnection(CnnSQL))
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand(query, cnn);
                if(parameter !=null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if(item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }   
                }
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                cnn.Close();
            }
            return data;
        }
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection cnn = new SqlConnection(CnnSQL))
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand(query, cnn);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = cmd.ExecuteNonQuery();
                cnn.Close();
            }
            return data;
        }
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection cnn = new SqlConnection(CnnSQL))
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand(query, cnn);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = cmd.ExecuteScalar();
                cnn.Close();
            }
            return data;
        }
    }
}
