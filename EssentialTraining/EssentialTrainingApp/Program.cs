using System;
using System.Collections.Generic;
using System.IO;

namespace EssentialTrainingApp
{
    class Program
    {
        public static List<string> Words;
        static void Main(string[] args)
        {
            Words = new List<string>();

            Words.Add("Bread");
            Words.Add("Milk");
            Words.Add("Cheese");


        }

        private static void ReadTextFile()
        {
            try
            {
                using (var sr = new StreamReader(@"C:\temp\test.txt"))
                {
                    string contents = sr.ReadToEnd();
                    Console.WriteLine(contents);
                }
            }
            catch(System.IO.DirectoryNotFoundException ex)
            {
                Console.WriteLine("Could not find the directory.");
            }
            catch(System.IO.FileNotFoundException ex)
            {
                Console.WriteLine("Could not fint the file.");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Unknown error occurs: " + ex.Message);
            }
        }
    }
}
