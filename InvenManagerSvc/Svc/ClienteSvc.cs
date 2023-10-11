using InvenManager.Classes;
using InvenManager.DB;
using Npgsql.Replication.PgOutput.Messages;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvenManager.Svc
{
    public class ClienteSvc
    {
        public static List<Cliente> getBulkCliente()
        {
            string query = $"select * from public.cliente";

            var dt = DbQueryManager.ReadData(query);

            //var data = dt.Rows.Cast<Cliente>().ToList();

            var clientes =  new List<Cliente>();

            for (int i = 0; i < dt.Rows.Count; i++) {
                var dado1 = dt.Rows[i][0];
                var dado2 = dt.Rows[i][1];
                var dado3 = dt.Rows[i][2];
                clientes.Add(new Cliente(pIdCli: (int)dado1, pNome: (string)dado2, pTelefone: (string)dado3));
            }


            return clientes;
        }

        public static void Insert(string nome, string telefone)
        {
            string query = $"insert into public.cliente(nome, telefone) values ('{nome}', '{telefone}')";
            DbQueryManager.InsertQuery(query);
        }

        //todo
        public static void Replace(string nome, string telefone)
        {
        }

        //todo
        public static void Delete(string nome, string telefone) { }

    }
}
