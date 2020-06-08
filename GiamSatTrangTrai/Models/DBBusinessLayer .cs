using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class DBBusinessLayer
    {
        string ConectionString = "server=localhost;user id=root;password=100100;persistsecurityinfo=True;database=datatrangtrai";

        public DBBusinessLayer()
        {

        }

        /// <summary>
        /// Get current lucky num.
        /// </summary>
        /// <param name="tableName">table query.</param>
        /// <returns>Reaturn current lucky Num.</returns>
        public DataTable SelectCmd(string table,string column, string where)
        {
            DataTable dataTable = new DataTable();
            string query;
            MySqlConnection conn;
            conn = new MySqlConnection(ConectionString);
            conn.Open();

            query = $"select {column} from {table} where {where}";
            try
            {
                MySqlDataAdapter Adapter = new MySqlDataAdapter(query, conn);
                Adapter.Fill(dataTable);
                conn.Close();
                conn.Dispose();
            }
            catch (System.Exception)
            {
                dataTable = null;
                conn.Close();
                conn.Dispose();
            }
            return dataTable;
        }

        public int SetCurrentLuckyNum(string luckyNum, int id)
        {
            int res =0;
            string query;
            MySqlConnection conn;
            conn = new MySqlConnection(ConectionString);
            conn.Open();

            query = $"update LuckyNum set LuckyNum='{luckyNum}' where Id='{id}'";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                res= cmd.ExecuteNonQuery();
                conn.Close();
                conn.Dispose();
            }
            catch (System.Exception)
            {
                conn.Close();
                conn.Dispose();
            }
            return res;
        }
    }
}
