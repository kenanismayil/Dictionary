using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> cities = new MyDictionary<string, int>();
            cities.Add("Istanbul",34);
            cities.Add("Ankara", 06);
            cities.Add("Adana", 01);
            cities.Add("Trabzon", 61);
            cities.Add("Mersin", 33);


            Console.WriteLine("Cities:");
            Console.WriteLine("----------------");
            foreach (var city in cities.Keys)
            {
                Console.WriteLine(city);
            }

            Console.WriteLine("----------------");

            Console.WriteLine("Plaka Id:");
            Console.WriteLine("----------------");
            foreach (var plaka in cities.Values)
            {
                Console.WriteLine(plaka);
            }

            Console.WriteLine("----------------");

            Console.WriteLine(cities.Count);

            Console.ReadLine();
        }
    }
}
