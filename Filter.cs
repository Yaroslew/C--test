using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Window_Title
{
    internal class Filter
    {
        internal string[] apllyFlt(TextBox []txtBox, ComboBox []cmbBox, string[] textFile)
        {
            if (txtBox[0].TextLength == 0)
            {
                MessageBox.Show("Вы не заполнили первое поля для поиска. Исправьте пожалуйста!");
                return (textFile);
            }

            string[] resultBox = new string[textFile.Length];
            int r = 0;
            foreach (string str in textFile)
            {
                string pattern = txtBox[0].Text;
                string str_or = "";

                for (int q = 1; q < 4; q++)
                {
                    if (cmbBox[q].SelectedIndex == 0 && txtBox[q].Text.Length > 0)
                        pattern +=".*" + txtBox[q].Text;
                    else if (cmbBox[q].SelectedIndex == 1 && txtBox[q].Text.Length > 0)
                        str_or += "|" + txtBox[q].Text;
                }
                pattern += str_or;
                Regex reg = (new Regex(@"" + pattern));
                MatchCollection matches = reg.Matches(str);
                if (matches.Count > 0)
                {
                    resultBox[r] = str;
                    r++;
                }
            }
            return (resultBox);
            
        }
    }
}