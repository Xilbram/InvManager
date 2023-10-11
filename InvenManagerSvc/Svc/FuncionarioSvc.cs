using InvenManager.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvenManager.Svc
{
    public class FuncionarioSvc
    {
        public static void Insert(string nome)
        {
            string query = $"insert into public.funcionario(nome) values ('{nome}')";
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
