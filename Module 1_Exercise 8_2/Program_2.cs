using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_1_Exercise_8_2
{
    class Program_2
    {
        static void Main(string[] args)
        {
            // Создаем папку, если ее не было
            string pathToDir = "Example";
            if (!Directory.Exists(pathToDir))
            {
                Directory.CreateDirectory(pathToDir);
            }
            string fileName = "MyFile.txt";

            string pathToFile = pathToDir + "/" + fileName;
            if (!File.Exists(pathToFile))
            {
                File.Create(pathToFile);
            }

            // Запись в файл 10 рандомных чисел
            int num = 10;
            Random random = new Random();
            using (StreamWriter sw = new StreamWriter(pathToFile, false))
            {
                for (int i = 0; i < num; i++)
                {
                    int intFromRandom = random.Next(0, 100);
                    sw.WriteLine(intFromRandom);
                }
            }

            int sum = 0;
            // Подсчет суммы чисел в файле
            using (StreamReader sr = new StreamReader(pathToFile))
            {
                for (int i = 0; i < num; i++)
                {
                    int number = Convert.ToInt32(sr.ReadLine());
                    sum += number;
                    Console.WriteLine(number);
                }
            }
            
            Console.WriteLine();
            Console.WriteLine("Общая сумма: {0}", sum);
            Console.ReadKey();
        }
    }
}
