using System;

namespace ExtensionMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2022, 12, 06, 02,04,10);

            Console.WriteLine(date.ElapsedTime());

            Console.Write("\nPhrase: ");
            string phrase = Console.ReadLine();
            Console.Write("Cut: ");
            int cut = int.Parse(Console.ReadLine());

            Console.WriteLine(phrase.StringCut(cut)); 
        }
    }
}