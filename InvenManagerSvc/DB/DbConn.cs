using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace InvenManager.DB
{
    internal class DbConn
    {
        public static string TesteConnection()
        {
            using (NpgsqlConnection con = GetConnection())
            {
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    return "OK";
                }
                return "fail";
            }
        }



        public static void InsertRecord()
        {
            using (NpgsqlConnection con = GetConnection())
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

        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(@"Server= localhost;Port=5432;User Id=postgres;Password=1234;Database=InvManager;");
        }
    }
}
