using System;
using System.IO;
using System.Xml.Linq;
using UsingDictionary.Entities;

namespace UsingDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            string path = @"c:\code\UsingDictionary\arquivo.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');

                        string personname = line[0];
                        int vote = int.Parse(line[1]);

                        if (dictionary.ContainsKey(personname))
                        {
                            dictionary[personname] += vote;
                        }
                        else
                        {
                            dictionary.Add(personname, vote);
                        }
                    }
                }

                Console.WriteLine("File path: " + path);

                foreach (var item in dictionary)
                {
                    Console.WriteLine(item.Key + ", " + item.Value);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error: " + ex.Message);
            }
        }
    }
}