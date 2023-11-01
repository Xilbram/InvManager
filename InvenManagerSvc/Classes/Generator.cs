using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using Newtonsoft.Json;
using InvenManager.DB;

namespace InvenManager.Classes
{
    public class Data
    {
        public string localidade { get; set; }
        public string sexo { get; set; }
        public List<Result> res { get; set; }
    }

    public class Result
    {
        public string nome { get; set; }
        public int frequencia { get; set; }
        public int ranking { get; set; }
    }

    public class Generator
    {
        public static async void gerarCliente()
        {
            
            using (HttpClient client = new HttpClient())
            {
                string urlApiIbge = "https://servicodados.ibge.gov.br/api/v2/censos/nomes/ranking";

                HttpResponseMessage resp = await client.GetAsync(urlApiIbge);
                string jsonData = resp.Content.ReadAsStringAsync().Result;
                List<Data> dataList = JsonConvert.DeserializeObject<List<Data>>(jsonData);
                List<Result> nomes = new List<Result>();

                Random rng = new Random();
                
                foreach (var data in dataList)
                {
                    foreach (var result in data.res)
                    {
                        nomes.Add(result);
                        
                    }
                }

                

                foreach (var nome in nomes)
                {
                    string numeroAleatorio = string.Empty;
                    for (int i = 0; i < 10; i++)
                        numeroAleatorio = String.Concat(numeroAleatorio, rng.Next(10).ToString());
                    DbQueryManager.InsertQuery($@"insert into public.cliente(nome, telefone) values ('{nome.nome}','{numeroAleatorio}' )");
                }




            }

            


        }



    }
}
