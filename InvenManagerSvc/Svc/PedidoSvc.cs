using InvenManager.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvenManager.Svc
{
    public class PedidoSvc
    {
        public static void Insert(int idcli, int idfunc, int idprod)
        {
            string query = $"insert into public.cliente(id_cli,id_func,id_prod,datapedido) values ({idcli},{idfunc},{idprod},{DateTime.Now})";
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
