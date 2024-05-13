using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProTechPractice
{
    internal class lab1
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string line = Console.ReadLine();
                char[] words = line.ToCharArray();
                bool even = (line.Count() % 2) == 0;
                int countLine = line.Count();
                if (even)
                {
                    for (int i = (countLine / 2) - 1; i >= 0; i--)
                    {
                        Console.Write(words[i]);
                    }
                    for (int i = countLine - 1; i >= countLine / 2; i--)
                    {
                        Console.Write(words[i]);
                    }
                    Console.WriteLine();
                }
                else
                {
                    for (int i = countLine - 1; i >= 0; i--)
                    {
                        Console.Write(words[i]);
                    }
                    for (int i = 0; i < countLine; i++)
                    {
                        Console.Write(words[i]);
                    }
                    Console.WriteLine();
                }
            } 
        }
    }
}
