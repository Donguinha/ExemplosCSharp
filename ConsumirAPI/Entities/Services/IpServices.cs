using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConsumirAPI.Entities.Services
{
    internal class IpServices
    {

        public async Task<IpData> Integracao()
        {

            HttpClient httpCliente = new HttpClient();

            var response = await httpCliente.GetAsync("https://api.myip.com");

            var jsonString = await response.Content.ReadAsStringAsync();

            IpData jsonObject = JsonConvert.DeserializeObject<IpData>(jsonString);

            return jsonObject;
        }
    }
}
