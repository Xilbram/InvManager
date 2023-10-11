using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvenManager.Classes
{
    public class Pedido
    {
        /// <summary>
        /// Identificador de cliente advindo do banco de dados
        /// </summary>
        public int id_cli { get; set; }

        /// <summary>
        /// Identificador de funcionario advindo do banco de dados
        /// </summary>
        public int id_func { get; set; }

        /// <summary>
        /// Identificador de produto advindo do banco de dados
        /// </summary>
        public int id_prod { get; set; }

        /// <summary>
        /// Data em que o pedido foi realizado
        /// </summary>
        public DateTime DataPedido { get; set; }

        public Pedido(int pIdCli, int pIdFunc, int pIdProd)
        {
            id_cli = pIdCli;
            id_func = pIdFunc;
            id_prod = pIdProd;
            DataPedido = DateTime.Now;
        }
    }
}
