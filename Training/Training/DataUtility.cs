using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    public class DataUtility
    {
        private SqlConnection _sqlConnection;
        public  DataUtility(string connectionString)
        {
            _sqlConnection = new SqlConnection(connectionString);
        }
        public void ExecuteSql(string query, Dictionary<string, object> values)
        {
           
           // SqlConnection sqlConnection = new SqlConnection(connectionString);
             using SqlCommand cmd = CreateCommand(query, values);
             cmd.ExecuteNonQuery();
           
        }
        public IList<Dictionary<string, object>> ReadData(string query , Dictionary<string, object> values) 
        { 
            List<Dictionary<string,object>> data =new List<Dictionary<string,object>>();
            using SqlCommand cmd = CreateCommand(query,values);
            using SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) 
            { 
                Dictionary<string,object> row = new Dictionary<string,object>();
                for (int i = 0; i < reader.FieldCount; i++) 
                { 
                    row.Add(reader.GetName(i), reader.GetValue(i));
                }
                data.Add(row);
            }
            return data; 
        }
        private SqlCommand CreateCommand(string sql, Dictionary<string, object> values) 
        {
            SqlCommand cmd = new SqlCommand(sql, _sqlConnection);
            if (values != null)
            {
                foreach (var item in values)
                {
                    cmd.Parameters.Add(new SqlParameter(item.Key, item.Value));
                }
            }
            if (_sqlConnection.State != System.Data.ConnectionState.Open)
                _sqlConnection.Open();
            return cmd;

        }
    }
}
