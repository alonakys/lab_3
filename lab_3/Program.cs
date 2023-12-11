using System;
using System.IO;
using System.Collections.Generic;

namespace lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string way = @"C:\Users\User\source\repos\lab_3\lab_3\files\";
            string[] fileNames = { "10.txt", "11.txt", "12.txt", "13.txt", "14.txt",
                        "15.txt", "16.txt", "17.txt", "18.txt", "19.txt", "20.txt" };
            int count = 0;

            try
            {
                File.Delete(way + "no_file.txt");
                File.Delete(way + "bad_data.txt");
                File.Delete(way + "overflow.txt");
                Directory.GetFiles(way);
                long res = CurrentDirectory.CurrentFiles(way, fileNames, ref count);
                Console.WriteLine(res / count);
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine($"Папку {way} не знайдено");
            }

        }
    }
}
