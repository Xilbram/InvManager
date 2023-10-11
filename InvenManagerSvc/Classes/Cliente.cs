using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvenManager.Classes
{
    public class Cliente
    {
        /// <summary>
        /// Identificador de cliente advindo do banco de dados
        /// </summary>
        public int id_cli { get; set; }

        public string nome { get; set; }

        public string telefone { get; set; }

        public Cliente(int pIdCli, string pNome, string pTelefone)
        {
            id_cli = pIdCli;
            nome = pNome;
            telefone = pTelefone;
        }
    }
}
