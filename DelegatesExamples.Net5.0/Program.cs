using System;
using System.Collections.Generic;

namespace DelegatesExamples.Net5._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //list of names
            List<string> names = new List<string>() { "Aiden", "Sif", "Walter", "Anatoli" };
            names.RemoveAll
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
