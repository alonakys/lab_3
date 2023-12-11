using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_2
{
    class Program
    {
        static void Main(string[] args)
        {

            string way = @"C:\Users\User\source\repos\lab_3\lab3_2\photos\";
            try
            {
                string[] data = Directory.GetFiles(way);
                CurrentDirectory.CurrentFiles(way, data);
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine($"Папку {way} не знайдено");
            }
        }
    }
}
