using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace DelegatesExamples.Net5._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //list of names
            List<string> names = new List<string>() { "Aiden", "Sif", "Walter", "Anatoli" };
            Console.WriteLine("----before----");
            //print the names before the remove all method
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            //calling the RemoveAll and passing a method Filter we created
            names.RemoveAll(Filter);

            Console.WriteLine("----after----");
            //print the names after the remove all method
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

        //a method called Filter that takes a string
        static bool Filter(string s) 
        {
            //return whether the string s contains the letter 'i'
            //the Contains method will return a bool which will return as well
            return s.Contains("i");
        }
    }
}
