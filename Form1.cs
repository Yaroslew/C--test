using System;
using System.Windows.Forms;

namespace Windows_Text_Search
{
    public partial class Window : Form
    {
        const int sizeMax = 1000000;
        Text txt = new Text();
        Filter flt = new Filter();

        public Window()
        {
            InitializeComponent();
        }

        private void Btn_file_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string[] textFile = txt.readFile(openFile.FileName, sizeMax);
                writeBox(textFile);
            }
        }
        public void writeBox(string[] textFile)
        {
            mainBox.Lines = textFile;
        }

        private void Btn_apply_Click(object sender, EventArgs e)
        {
            TextBox[] textBox = new TextBox[4] { textBoxA, textBoxB, textBoxC, textBoxD };
            ComboBox[] comboBox = new ComboBox[4] { comboBoxA, comboBoxB, comboBoxC, comboBoxD };
            string[] textFile = flt.check_flt(textBox, comboBox, mainBox.Lines);
            writeBox(textFile);

        }

        private void Window_DragDrop(object sender, DragEventArgs e)
        {
            string filename = "";
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] s = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string str in s)
                    filename += str;
                string[] textFile = txt.readFile(filename, sizeMax);
                writeBox(textFile);
            }
        }

        private void Window_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }
    }
}
