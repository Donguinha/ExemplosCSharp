using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsandoInterface.Services
{
    internal class Resto : IOperacao
    {
        public double Operacao(double numero1, double numero2)
        {             
            if (numero1 % 2 == 0)
            {
                Console.WriteLine("número 1 par");
            }
            else
            {
                Console.WriteLine("número 1 impar");
            }
            
            if (numero2 % 2 == 0)
            {
                Console.WriteLine("número 2 par");
            }
            else
            {
                Console.WriteLine("número 2 impar");
            }
            return 0;
        }
    }
}
