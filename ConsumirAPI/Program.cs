using ConsumirAPI.Entities;
using ConsumirAPI.Entities.Services;
using System;

namespace ConsumirAPI
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine("Programa simples para consumir uma API qualquer\n");

            var ipServices = new IpServices();

            IpData ipData = await ipServices.Integracao();

            Console.WriteLine("Your IP: " + ipData.Ip);
            Console.WriteLine($"Your Country: {ipData.Country} - {ipData.CountryCode}" );
        }
    }
}