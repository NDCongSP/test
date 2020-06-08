using Models.Framework;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class AccountModel
    {
        string ConectionString = "server=localhost;user id=root;password=100100;persistsecurityinfo=True;database=datatrangtrai";
        public AccountModel()
        {
        }
        public bool Login(string userName, string password)
        {
            DataTable userData = new DataTable();
            bool res = false;
            string query;
            MySqlConnection conn;
            conn = new MySqlConnection(ConectionString);
            conn.Open();

            query = $"select * from useraccount where userName='{userName}' and password='{password}'";
            try
            {
                MySqlDataAdapter Adapter = new MySqlDataAdapter(query, conn);
                Adapter.Fill(userData);
                conn.Close();
                conn.Dispose();

                if(userData!=null && userData.Rows.Count > 0)
                {
                    res = true;
                }
                else
                {
                    res = false;
                }
            }
            catch (System.Exception)
            {
                userData = null;
                conn.Close();
                conn.Dispose();
            }
            return res;
        }
        public int UpdatePassword(string oldPassword, string newPassword)
        {
            int res = 0;
            string query;
            MySqlConnection conn;
            conn = new MySqlConnection(ConectionString);
            conn.Open();
            if (Login("admin", oldPassword))
            {
                query = $"update useraccount set password='{newPassword}' where Id='1'";
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    res = cmd.ExecuteNonQuery();
                    conn.Close();
                    conn.Dispose();
                }
                catch (System.Exception)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
            
            return res;
        }
    }
}
