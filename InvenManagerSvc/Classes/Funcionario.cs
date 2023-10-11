using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvenManager.Classes
{
    public class Funcionario
    {
        /// <summary>
        /// Identificador de funcionario advindo do banco de dados
        /// </summary>
        public int id_func { get; set; }

        public string nome { get; set; }

        public Funcionario(int pIdFunc, string pNome)
        {
            id_func = pIdFunc;
            nome = pNome;
        }
    }
}
