using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvenManager.Classes
{
    public class Produto
    {
        /// <summary>
        /// Identificador de produto advindo do banco de dados
        /// </summary>
        public int id_prod { get; set; }
        public string nome { get; set; }
        public int? preco { get; set; }
        public string? fornecedor { get; set; }
        public Produto(int pIdProd, string pNome, int pPreco, string pFabricante)
        {
            id_prod = pIdProd;
            nome = pNome;
            preco = pPreco;
            fornecedor = pFabricante;
        }
    }
}
