using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Window_Title
{
    public partial class Window : Form
    {

        Text txt = new Text();
        Filter flt = new Filter();
        public Window()
        {
            InitializeComponent();
            openFileDialog.Filter = "Text files(*.txt)|* txt|All files(*.*)|*.*";
        }

        private void BtnFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txt.readFile(openFileDialog.FileName);
                writeBox(txt.textFile);
            }
        }

        private void writeBox(string[] writeFile)
        {
            mainTextBox.Lines = writeFile;
        }

        private void Window_DragDrop(object sender, DragEventArgs e)
        {
            string filename = "";
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] s = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string str in s)
                    filename += str;
                txt.readFile(filename);
                writeBox(txt.textFile);
            }
        }

        private void Window_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            if (txt.textFile == null)
            {
                MessageBox.Show("Вы не загрузили текстовый файл. Исправьте это пожалуйста!");
                return;
            }
            TextBox[] txtBox = new TextBox[4] { textBoxA, textBoxB, textBoxC, textBoxD };
            ComboBox[] cmbBox = new ComboBox[4] { comboBoxA, comboBoxB, comboBoxC, comboBoxD };
            string [] fltText = flt.apllyFlt(txtBox, cmbBox, txt.textFile);
            writeBox(fltText);
        }
    }
}
