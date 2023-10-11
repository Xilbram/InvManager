using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvenManager.DB
{
    internal class DbQueryManager
    {
        public static DataTable ReadData(string pQuery)
        {
            using (NpgsqlConnection con = DbConn.GetConnection())
            {
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand(pQuery, con);
                var dataReader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dataReader);
                con.Close();
                return dt;
            }
        }


        public static void InsertQuery(string pQuery)
        {
            using (NpgsqlConnection con = DbConn.GetConnection())
            {
                NpgsqlCommand cmd = new NpgsqlCommand(pQuery, con);
                con.Open();
                int n = cmd.ExecuteNonQuery();
                if(n >0)
                {
                    Console.WriteLine("error on insertion of data");
                    con.Close();
                }
            }
        }

        public static void InsertRecord()
        {
            using (NpgsqlConnection con = DbConn.GetConnection())
            {
                string query = @"insert into public.cliente(nome, telefone) values ('zézinho', '48998542301')";
                NpgsqlCommand cmd = new NpgsqlCommand(query, con);
                con.Open();
                int n = cmd.ExecuteNonQuery();
                if (n == 1)
                {
                    Console.WriteLine("oK");
                }
                else
                {
                    Console.WriteLine("fail");
                }
            }

        }

    }
}
