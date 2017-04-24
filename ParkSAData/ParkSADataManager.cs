using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Reflection;

namespace ParkSAData
{
    public class ParkSADataManager
    {
        private const string connectionSting = "Data Source=localhost;Initial Catalog=ParkSA;Integrated Security=True;";
        public List<T> Get<T>(string storedProcedureName) where T : new()
        {
            List<T> list = new List<T>();
            using (var conn = new SqlConnection(connectionSting))
            {
                var com = new SqlCommand();
                com.Connection = conn;
                com.CommandType = CommandType.StoredProcedure;

                com.CommandText = storedProcedureName;
                var adapt = new SqlDataAdapter();
                adapt.SelectCommand = com;

                var dataset = new DataSet();
                adapt.Fill(dataset);

                Populate<T>(list, dataset);
            }
            return list;
        }

        private static void Populate<T>(List<T> list, DataSet dataset) where T : new()
        {
            for (int i = 0; i < dataset.Tables[0].Rows.Count; i++)
            {
                DataRow row = dataset.Tables[0].Rows[i];
                T t = new T();
                PropertyInfo[] properties = t.GetType().GetProperties();
                for (int j = 0; j < properties.Length; j++)
                {
                    properties[j].SetValue(t, row[properties[j].Name], null);
                }
                list.Add(t);
            }
        }
    }
}
