using AulaGetHashCode.Entities;
using System;
using System.Collections.Generic;

namespace AulaGetHashCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //string a = "Maria";
            //string b = "Alex";
            //string c = "Maria";

            //Console.WriteLine(a.Equals(c));
            //Console.WriteLine(a.Equals(b));

            //Console.WriteLine(a.GetHashCode());
            //Console.WriteLine(b.GetHashCode());

            //Client client1 = new Client() { name = "Sal" , email = "sal@gmail.com" }; 
            //Client client2 = new Client() { name = "Las" , email = "sal@gmail.com" };

            //Console.WriteLine(client1.Equals(client2));
            //Console.WriteLine(client1.GetHashCode());
            //Console.WriteLine(client2.GetHashCode());

            //HashSet<string> set = new HashSet<string>();

            //set.Add("TV");
            //set.Add("Tablet");
            //set.Add("Notebook");

            //Console.WriteLine(set.Contains("laranja"));
            //Console.WriteLine(set.Contains("TV"));

            //foreach (string s in set)
            //{
            //    Console.WriteLine(s);
            //}

            //    SortedSet<int> sort1 = new SortedSet<int>() { 0, 1, 3, 2, 4, 6, 8, 10 };
            //    SortedSet<int> sort2 = new SortedSet<int>() {0, 1, 3, 5, 7, 9, 11 };

            //    PrintCollection(sort1);
            //    PrintCollection(sort2);

            //    SortedSet<int> sort3 = new SortedSet<int>(sort1);
            //    sort3.UnionWith(sort2);

            //    PrintCollection(sort3);

            //    SortedSet<int> sort4 = new SortedSet<int>(sort1);
            //    sort4.IntersectWith(sort2);

            //    PrintCollection(sort4);

            //    SortedSet<int> sort5 = new SortedSet<int>(sort1);
            //    sort5.ExceptWith(sort2);

            //    PrintCollection(sort5);

            HashSet<Product> prod1 = new HashSet<Product>();

            prod1.Add(new Product("TV", 900.23));
            prod1.Add(new Product("Salada", 23.3));
            prod1.Add(new Product("Salada", 23));

            HashSet<Point> point1 = new HashSet<Point>();

            point1.Add(new Point(2, 5));
            point1.Add(new Point(7, 49));

            Product prod2 = new Product("TV", 900.23);

            Console.WriteLine(prod1.Contains(prod2));

            foreach (Product item in prod1)
            {
                Console.WriteLine(item);
            }


        }

        //static void PrintCollection<T>(IEnumerable<T> collection)
        //{
        //    foreach (T item in collection)
        //    {
        //        Console.Write(item + " ");
        //    }
        //    Console.WriteLine();
        //}
    }
}