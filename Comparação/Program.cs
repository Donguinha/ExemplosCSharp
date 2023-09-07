using System;
using System.Diagnostics;

namespace Comparar
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //COMPARAÇÃO DO TIPO REFERENCIA OCORRE PELO ENDEREÇO DA VARIAVEL NA MEMORIA, DO TIPO VALOR NÃO
            //POR ISSO O PRIMEIRO TESTE DÁ FALSO E O SEGUNDO DANDO OVERRIDE NAS COMPARAÇÕES DE ENDEREÇO DÁ CERTO

            var teste1 = new Teste(100);
            var teste2 = new Teste(100);

            Console.WriteLine(teste1 == teste2);

            Console.WriteLine(teste1.Equals(teste2));
        }
    }

    class Teste
    {
        public int Valor { get; set; }

        public Teste(int valor)
        {
            Valor = valor;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;

            var teste = obj as Teste;

            return Valor.Equals(teste.Valor);
        }

        public override int GetHashCode()
        {

            return Valor.GetHashCode();
        }
    }
}