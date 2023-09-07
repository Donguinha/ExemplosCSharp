using System;
using UsandoInterface.Entities;
using UsandoInterface.Services;

namespace UsandoInterface
{
    class Program
    {
        //test
        static void Main(string[] args)
        {
            var repeat = 0;

            do
            {
                Console.WriteLine("Dividir 1" +
                    "\nMultiplicar 2" +
                    "\nVerificar se é par ou impar 3");
                var escolha = int.Parse(Console.ReadLine());


                Console.Write("\nNumero 1: ");
                var num1 = double.Parse(Console.ReadLine());

                Console.Write("\nNumero 2: ");
                var num2 = double.Parse(Console.ReadLine());

                if (escolha == 1)
                {
                    var conta = new Conta(new Dividir());
                    Console.WriteLine("resultado: " + conta.ChamarOperacao(num1, num2));
                    Console.WriteLine();

                }else if (escolha == 2)
                {
                    var conta = new Conta(new Multiplicar());
                    Console.WriteLine("resultado: " + conta.ChamarOperacao(num1, num2));
                    Console.WriteLine();

                }else if (escolha == 3)
                {
                    var conta = new Conta(new Resto());
                    Console.WriteLine(conta.ChamarOperacao(num1, num2)); 
                    Console.WriteLine();

                }

                Console.WriteLine("sair - 4");
                repeat = int.Parse(Console.ReadLine());
                Console.Clear(); 

            }while(repeat != 4);


        }
    }
}