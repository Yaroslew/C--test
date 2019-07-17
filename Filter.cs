using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Windows_Text_Search
{
    internal class Filter
    {
  /*      
        internal string[] check_flt(TextBox[] textBox, ComboBox[] comboBox, string[] mainBox)
        {
            string[] resultBox = new string[mainBox.Length];
            int r = 0;
            foreach (string str in mainBox)
            {
                string pattern = "";
                string str_or = "";
                
                for (int q = 0; q < 4; q++)
                {
                    if (comboBox[q].SelectedIndex == 1)
                        pattern += textBox[q].Text + ".*";
                    else if (comboBox[q].SelectedIndex == 2)
                        str_or += textBox[q].Text + "|";
                }
                if (pattern.Length > 0)
                    pattern = pattern.Substring(0, pattern.Length - 2);
                if (str_or.Length > 0)
                    str_or = str_or.Substring(0, str_or.Length - 1);
                if (pattern.Length > 0 && str_or.Length > 0)
                    pattern += "|" + str_or;
                else
                    pattern += str_or;
                if (pattern.Length == 0)
                    return (resultBox);
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
*/
        internal string[] check_flt(TextBox[] textBox, ComboBox[] comboBox, string[] mainBox)
        {
            string[] resultBox = new string[mainBox.Length];
            int r = 0;
            int q;
            int countFalse;
            foreach (string str in mainBox)
            {
                countFalse = 0;
                for (q = 0; q < 4; q++)
                {
                   if (comboBox[q].SelectedIndex == 1)
                        if (str.Contains(textBox[q].Text) == false)
                            break;
                   if (comboBox[q].SelectedIndex == 2)
                        if (str.Contains(textBox[q].Text) == false)
                            countFalse++;
                }
                if (q == 4 && countFalse != 4)
                {
                    resultBox[r] = str;
                    r++;
                }
            }
            return (resultBox);
        }
    }
}