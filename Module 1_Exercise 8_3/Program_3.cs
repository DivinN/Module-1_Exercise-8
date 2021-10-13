using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_1_Exercise_8_3
{
    class Program_3
    {
        static void Main(string[] args)
        {
            string path = "Example/FileForAnalize.txt";

            if (!File.Exists(path))
            {
                Console.WriteLine("Файл не найден!");
            }

            int numChar = 0;
            int numWords = 0;
            int numLines = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                while (sr.Peek() != -1)
                {
                    numLines += 1;
                    string line = sr.ReadLine();
                    
                    string[] arrayFromLine = new string[0];
                    numWords += line.Split().Length;
                    numChar += line.Length;
                    Console.WriteLine(line);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Строк в тексте: {0}", numLines);
            Console.WriteLine("Слов в тексте: {0}", numWords);
            Console.WriteLine("Символов в тексте: {0}", numChar);
            Console.ReadKey();
        }
    }
}
