using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace lab_3
{
    public static class CurrentDirectory
    {
        public static long CurrentFiles(string path, string[] fileNames, ref int count)
        {
            long res = 0;
            foreach (var fileName in fileNames)
            {
                try
                {
                    string[] data = File.ReadAllLines(path + fileName);
                    int firstNum = Convert.ToInt32(data[0]);
                    int secondNum = Convert.ToInt32(data[1]);
                    int testres;
                    checked
                    {
                        testres = firstNum * secondNum;
                    }
                    res += testres;
                    count++;
                }
                catch (FileNotFoundException)
                {
                    File.AppendAllText(path + "no_file.txt", fileName + "\n");
                }
                catch (OverflowException)
                {
                    File.AppendAllText(path + "overflow.txt", fileName + "\n");
                }
                catch (FormatException)
                {
                    File.AppendAllText(path + "bad_data.txt", fileName + "\n");
                }
                catch (IndexOutOfRangeException)
                {
                    File.AppendAllText(path + "bad_data.txt", fileName + "\n");
                }
            }
            return (res);
        }
    }
}
