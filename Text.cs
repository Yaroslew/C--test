using System.IO;
using System.Windows.Forms;
using System.Linq;

namespace Window_Title
{
    internal class Text
    {
        internal string[] textFile;
        const int size_max = 1000000;
        internal int sizeFile;

        internal void readFile(string fileName)
        {
            sizeFile = File.ReadAllLines(fileName).Length;
            if (sizeFile > size_max)
            {
                MessageBox.Show("Файл слишком большой. Будут открыты первые 1000 000 строк.");
                textFile = new string[size_max];
            }
            else
                textFile = new string[sizeFile];
            readTextFile(sizeFile, fileName);
        }

        internal void readTextFile(int sizeFile, string fileName)
        {
            for (int q = 0; q < sizeFile; q++)
                textFile[q] = File.ReadLines(fileName).Skip(q).First();
        }
    }
}