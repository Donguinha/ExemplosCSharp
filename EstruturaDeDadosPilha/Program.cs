using System.Collections;
using System.Net.Sockets;

namespace EstruturaDeDadosPilha
{
    class Program
    {
        static void Main()
        {
            var pilha1 = new List<string>();
            var pilha2 = new List<string>();

            AdicionarItens(pilha1);

            Console.Clear();
            Console.WriteLine("Itens da pilha 1:");

            foreach (var itemDaLista in pilha1)
            {
                Console.WriteLine(itemDaLista);
            }

            string decisao;

            do
            {
                Console.WriteLine("O que deseja fazer agora?\n" +
                                  "1 - Mover para pilha 2\n" +
                                  "2 - Mover para pilha 1\n" +
                                  "3 - Adicionar mais itens\n" +
                                  "4 - Sair");

                decisao = Console.ReadLine();

                switch (decisao)
                {
                    case "1":
                        MoverParaPilha2(pilha1, pilha2);
                        break;

                    case "2":
                        MoverParaPilha1(pilha1, pilha2);
                        break;

                    case "3":
                        AdicionarItens(pilha1);
                        break;
                }

                Console.Write("Pilha 1: ");
                foreach (var itemDaLista in pilha1)
                {
                    Console.Write(itemDaLista + " ");
                }

                Console.Write("Pilha 2: ");
                foreach (var itemDaLista in pilha2)
                {
                    Console.Write(itemDaLista + " ");
                }
            } while (decisao != "4");
        }

        private static List<string> AdicionarItens(List<string> pilha1)
        {
            string validation;

            do
            {
                Console.Write("Item: ");
                var item = Console.ReadLine();

                pilha1.Add(item);

                Console.WriteLine("Adicionar mais itens na pilha? 0 - para não || qualquer outra tecla para sim");
                validation = Console.ReadLine();
            } while (validation != "0");

            return pilha1;
        }

        private static void MoverParaPilha2(List<string> pilha1, List<string> pilha2)
        {
            pilha2.Add(pilha1.LastOrDefault());
            pilha1.Remove(pilha1.LastOrDefault());
        }

        private static void MoverParaPilha1(List<string> pilha1, List<string> pilha2)
        {
            pilha1.Add(pilha2.LastOrDefault());
            pilha2.Remove(pilha2.LastOrDefault());
        }
    }
}