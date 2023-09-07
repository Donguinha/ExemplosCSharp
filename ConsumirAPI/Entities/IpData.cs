using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumirAPI.Entities
{
    internal class IpData
    {
        public string Ip { get; private set; }
        public string Country { get; private set; }
        public string CountryCode { get; private set; }

        public IpData(string ip, string country, string cc)
        {
            Ip = ip;
            Country = country;
            CountryCode = cc;
        }
    }
}
