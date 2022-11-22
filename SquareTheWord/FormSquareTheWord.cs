using System;
using System.IO;
using System.Windows.Forms;

namespace SquareTheWord
{
    public partial class FormSquareTheWord : Form
    {
        public FormSquareTheWord()
        {
            InitializeComponent();
        }

        private void BtnSquareTheWord_Click(object sender, EventArgs e)
        {
            string line = "";

            string path = Application.StartupPath + @"\square.txt";
            StreamReader streamReader = new StreamReader(path);

            bool finished = false;

            while (!finished)
            {
                line = streamReader.ReadLine();

                if (line == null)
                {
                    finished = true;
                }
                else
                {
                    SquareWord(line);
                    TxtResult.Text += Environment.NewLine;
                }
            }
        }

        private void SquareWord(string word)
        {
            TxtResult.Text += word + Environment.NewLine;
            string emptySpaces = "                         ";

            for (int i = 1; i < word.Length - 1; i++)
            {
                TxtResult.Text += word.Substring(i, 1) + emptySpaces.Substring(0, word.Length - 2) + word.Substring((word.Length - 1) - i, 1) + Environment.NewLine;
            }
 
            ReverseWord(word);
            TxtResult.Text += Environment.NewLine;
        }

        private void ReverseWord(string word)
        {
            for (int i = word.Length - 1; i >= 0; i--)
            {
                TxtResult.Text += word.Substring(i, 1);
            }
        }
    }
}
