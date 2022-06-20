using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Security;

namespace Exam
{
    class OpenFileDialogForm : Form1
    {
        [STAThread]
        public static void Open()
        {

            Application.Run(new OpenFileDialogForm());
        }
        public Button button1;
        public OpenFileDialog openFileDialog1;
        //private readonly TextBox textBox1;

        public OpenFileDialogForm()
        {
            openFileDialog1 = new OpenFileDialog();

            button1 = new Button
            {
                Size = new Size(100, 20),
                Location = new Point(15, 15),
                Text = "Select file"
            };
            button1.Click += new EventHandler(button1_Click);
            textBox1 = new TextBox
            {
                Size = new Size(330, 360),
                Location = new Point(15, 40),
                Multiline = true,
                ScrollBars = ScrollBars.Vertical
            };
            ClientSize = new Size(330, 360);
            Controls.Add(button1);
            Controls.Add(textBox1);
        }
               
    }
}
