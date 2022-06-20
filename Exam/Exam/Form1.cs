using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Printing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security;
using System.Diagnostics;

namespace Exam
{
    public partial class Form1 : Form    
    {      
        // не стал специально удалять нерабочий код, чтобы вы видели ход работы

        // пытался написать кодировку, подключая различные источники.. не получилось(

        // так же доконца не разобрался с listbox. никак не могу прийти к тому, чтобы я мог взаимодействовать с файлами через данное окно.
        // все, что вышло - это отображение файлов в выбранной директории и отображения пути к файлу через label
        public Form1()
        {
            InitializeComponent();            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }        

        public void radioButton1_CheckedChanged(object sender, EventArgs e)
        {            
            textBox1.Text = Text;
        }

        public void radioButton2_CheckedChanged(object sender, EventArgs e)
        {                     

        }

        public void radioButton3_CheckedChanged(object sender, EventArgs e)
        {            
            //string unicodeString = "This string contains the unicode character Pi (\u03a0)";            

            //Encoding ascii = Encoding.ASCII;
            //Encoding unicode = Encoding.Unicode;

            //byte[] unicodeBytes = unicode.GetBytes(unicodeString);
            //byte[] asciiBytes = Encoding.Convert(unicode, ascii, unicodeBytes);

            //char[] asciiChars = new char[ascii.GetCharCount(asciiBytes, 0, asciiBytes.Length)];
            //ascii.GetChars(asciiBytes, 0, asciiBytes.Length, asciiChars, 0);
            //string asciiString = new string(asciiChars);

            //textBox1.Text = unicodeString;
            //textBox1.Text = asciiString;


            //попытка написать кодировку. не стал удалять законстпектированный текст
        }
        private void SetText(string text)
        {
            textBox1.Text = text;
        }        

        public void button1_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fdb = new FolderBrowserDialog() { Description = "Путь к папке" })
            {
                if (fdb.ShowDialog() == DialogResult.OK)
                {
                    listBox1.DataSource = Directory.GetFiles(fdb.SelectedPath);
                }
            }

            //-----------------------------------------

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    путь.Text = openFileDialog1.FileName;
                    var sr = new StreamReader(openFileDialog1.FileName);
                    SetText(sr.ReadToEnd());
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error. \n\nError message: {ex.Message}\n\n +" +
                        $"$Details: {ex.StackTrace}");
                }
            }                     

        }

        private void путь_Click(object sender, EventArgs e)
        {
               // это label
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string filename = listBox1.GetItemText(listBox1.SelectedItem);

            //string path = "D:\\Тексты";            

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //textBox1.Text = Path.Combine(textBox1.Text,listBox1.SelectedItem.ToString());
            //listBox1.Items.Clear();
            //DirectoryInfo dir = new DirectoryInfo(textBox1.Text);

            //DirectoryInfo[] dirs = dir.GetDirectories();

            //foreach (DirectoryInfo crrdir in dirs)
            //{
            //    listBox1.Items.Add(crrdir);
            //}

            //FileInfo[] files = dir.GetFiles();
            //foreach(FileInfo crrFile in files)
            //{
            //    listBox1.Items.Add(crrFile);
            //}

            //---------------------------------------------------------------

            //Process proc = new Process();
            //textBox1.Text = proc.StartInfo.Arguments(path + filename);
            //proc.Start();            
        }
    }
}
