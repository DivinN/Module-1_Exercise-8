using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_1_Exercise_8_1
{
    class Program_1
    {
        static void Main(string[] args)
        {
            // Добрый день! Надеюсь я правильно понял, что такое рекурсия, а то написал это слово в комментах несколько раз :D
            
            string path = "D:/OneDrive - Bonava/BIM/ТЗ";
            string[] diresInParent;

            if (Directory.Exists(path))
            {
                Console.WriteLine("Анализируем папку по пути {0}", path);
                diresInParent = GetDirsFromDir(path);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Такой директории не существует!");
            }
            Console.ReadKey();
        }

        // Данный метод ищет и выводит папки и файлы в директирории
        // А также рекурсивно погружается во внутренние папки
        static string[] GetDirsFromDir(string path)
        {
            string[] dires = new string[0];
            string[] files = new string[0];
            if (Directory.Exists(path))
            {
                Console.WriteLine("В директории {0} найдено:", path);
                // Ищем папки в поданной директории
                dires = Directory.GetDirectories(path);
                if (dires.Length > 0)
                {
                    foreach (string dir in dires)
                    {
                        Console.WriteLine("     - найдена папка     {0}", dir);
                    }
                }
                // Ищем файлы в поданной директории
                files = Directory.GetFiles(path);
                if (files.Length > 0)
                {
                    foreach (string file in files)
                    {
                        Console.WriteLine("     - найден файл     {0}", file);
                    }
                }
                
                if (dires.Length > 0)
                { 
                    foreach (string dir in dires)
                    {
                        // Рекурсивно погружаемся в найденную папку
                        GetDirsFromDir(dir);
                    }
                }
            }
            return dires;
        }
    }
}
