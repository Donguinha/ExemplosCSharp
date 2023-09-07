using ContratoTrabalho.Entidades;
using ContratoTrabalho.Entidades.Enumeração;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Contracts;

namespace ContratoTrabalho
{
    class Program
    {
        static void Main(string[] args)
        {
            ReceberDepartamento();
            ReceberDados();
            
        }

        static void ReceberDepartamento()
        {
            Console.Write("Departamento: ");
            var depart = Console.ReadLine();
            Departamento depar1 = new Departamento(depart);
        }

        static void ReceberDados()
        {
            Console.Write("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\nDados do trabalhador\nNome: ");
            var nome = Console.ReadLine();

            Console.Write("Nível (Junior/Nível médio/ Senior): ");
            var nivel = Console.ReadLine();
            NivelTrabalhador nivelenum = Enum.Parse<NivelTrabalhador>(nivel);

            Console.Write("Salário base: ");
            var salario = double.Parse(Console.ReadLine());

            Trabalhador trab1 = new Trabalhador(nome, nivelenum, salario);


            Console.Write("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\nQuantidade dos contratos de trabalho: ");
            var qtde = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtde; i++)
            {
                Console.Write("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\nData: ");
                var data = DateTime.Parse(Console.ReadLine());

                Console.Write("Valor hora do trabalho: ");
                var valorporhora = double.Parse(Console.ReadLine());

                Console.Write("Duração: ");
                var horas = int.Parse(Console.ReadLine());

                Contrato contratonovo = new Contrato(data, valorporhora, horas);

                trab1.AddContrato(contratonovo);
            }

            Console.Write("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\nData para buscar valores dos contratos (MM/AAAA): ");
            var datas = Console.ReadLine().Split('/');
            var ano = int.Parse(datas[0]);
            var mes = int.Parse(datas[1]);

            Console.WriteLine(trab1);

            Console.Write($"Valor recebido na data {mes}{ano}: {trab1.ReceberMes(ano, mes)}");
        }
    }
}


