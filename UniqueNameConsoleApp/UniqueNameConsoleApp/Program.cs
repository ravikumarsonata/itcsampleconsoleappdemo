using System;
using System.Linq;

namespace UniqueNameConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names1 = new string[] { "Ava", "Emma", "Olivia" };
            string[] names2 = new string[] { "Olivia", "Sophia", "Emma" };
            Console.WriteLine(string.Join(", ", MergeNames.UniqueNames(names1, names2))); // should print Ava, Emma, Olivia, Sophia
            Console.WriteLine("Hello World!");
        }
        public class MergeNames
        {
            public static string[] UniqueNames(string[] names1, string[] names2)
            {
                //am using linq union method - to add two arrays without duplicating and OrderBy for alphetic order of array
                return ((names1.Union(names2)).OrderBy(x => x).ToArray());


            }
        }
    }
}
