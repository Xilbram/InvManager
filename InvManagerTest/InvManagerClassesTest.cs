using InvenManager.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace InvManagerTest
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
    [TestClass]
    public class InvManagerClassesTest
    {

        [TestMethod]
        public async Task TestarGetApiIbgeAsync()
        {
            HttpClient client = new HttpClient();
            string urlApiIbge = "https://servicodados.ibge.gov.br/api/v2/censos/nomes/ranking";

            HttpResponseMessage resp = await client.GetAsync(urlApiIbge);
            string jsonData = resp.Content.ReadAsStringAsync().Result;
            List<Data> dataList = JsonConvert.DeserializeObject<List<Data>>(jsonData);

            List<Result> nomes = new List<Result>();

            foreach (var data in dataList)
            {
                foreach (var result in data.res)
                {
                    nomes.Add(result);
                }
            }

            Assert.IsNotNull(resp);
            
        }

        [TestMethod]
        public void TestarGeracaoClientes()
        {
            InvenManager.Classes.Generator.gerarCliente();
        }
    }
}