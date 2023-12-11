using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace lab3_2
{
    public class CurrentDirectory
    {
        static Regex regexExtForImage = new Regex("^((.bmp)|(.gif)|(.tiff?)|(.jpe?g)|(.png))$", RegexOptions.IgnoreCase);

        public static void CurrentFiles(string path, string[] data)
        {
            foreach (string fileName in data)
            {
                try
                {
                    string ext = Path.GetExtension(fileName);
                    string newName = Path.ChangeExtension(fileName, null);
                    newName += "-mirrored.gif";
                    if (regexExtForImage.IsMatch(ext))
                    {
                        MirrorImage(newName, fileName);
                        Console.WriteLine($" Вiдзеркалення картики {fileName} пройшло успiшно");
                    }
                    else { Console.WriteLine(fileName + " не є картинкою"); }
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Помилка при завантаженні зображення\n{fileName}\n" + e.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public static void MirrorImage(string name, string fileName)
        {
            Bitmap image = new Bitmap(fileName);
            image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            image.Save(name, ImageFormat.Gif);
        }
    }
}
