using System.IO;
using System.Windows.Forms;
using System.Linq;

namespace Windows_Text_Search
{
    internal class Text 
    {
        
        internal string[] readFile(string filename, int sizeMax)
        {
            string[] textFile;
            int size = File.ReadAllLines(filename).Length;
            if (size > sizeMax)
            {
                MessageBox.Show("Файл слишком большой. Будет открыты первые 1 000 000 строк.");
                size = sizeMax;
            }
            textFile = new string[size];
            for (int q = 0; q < size; q++)
                textFile[q] = File.ReadLines(filename).Skip(q).First();
            return (textFile);
        }
    }
}