﻿using InvenManager.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvenManager.Svc
{
    public class ProdutoSvc
    {
        public static void Insert(string nome, int preco, string fornecedor)
        {
            string query = $"insert into public.produto(nome, preco, fornecedor) values ('{nome}', {preco},'{fornecedor}')";
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
