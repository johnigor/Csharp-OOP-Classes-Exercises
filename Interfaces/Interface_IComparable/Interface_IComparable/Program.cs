using System;
using System.IO;
using System.Collections.Generic;
using Interface_IComparable.Entities;

namespace Interface_IComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\in.txt";
            
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    //Ordena a lista
                    list.Sort();
                    foreach (Employee emp in list)
                    {
                        Console.WriteLine(emp);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}
