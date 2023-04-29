using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace example
{
    public partial class FormMain : Form
    {
        Dictionary<char, Queue<int>> dict = new Dictionary<char, Queue<int>>();
        public FormMain()
        {
            InitializeComponent();
        }

        string Encrypt(string text, Dictionary<char, Queue<int>> dict)
        {
            var sb = new StringBuilder();
            foreach (var s in text)
            {
                if (dict.ContainsKey(s))
                {
                    var number = dict[s].Dequeue();
                    dict[s].Enqueue(number);
                    sb.Append(string.Format("{0:D2}", number));
                }
                else sb.Append(s);
            }
            return sb.ToString();
        }

        string Decrypt(string text, Dictionary<char, Queue<int>> dict)
        {
            var sb = new StringBuilder();
            int buffer;
            for (int i = 0; i < text.Length; i += 2)
            {
                if (text.Substring(i, 2).Contains(" "))
                {
                    i++;
                    sb.Append(' ');
                }
                buffer = Convert.ToInt32(text.Substring(i, 2));
                for (int j = 0; j < dict.Count(); j++)
                {
                    if (dict.Values.ToList()[j].Contains(buffer))
                    {
                        sb.Append(dict.Keys.ToList()[j]);
                        break;
                    }
                }
            }
            return sb.ToString();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            textBoxOutput.Clear();
            dict.Clear();
            char[] symbols;
            var textToEncrypt = textBoxInput.Text.ToLower();

            if (radioButtonRu.Checked) symbols = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя".ToCharArray();
                else symbols = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            for (int i = 0; i <= 99; i++)
            {
                var symb = symbols[i % symbols.Length];
                if (!dict.ContainsKey(symb)) dict.Add(symb, new Queue<int>());
                dict[symb].Enqueue(i);
            }

            if (radioButtonShifr.Checked) textBoxOutput.Text = Encrypt(textToEncrypt, dict);
            else textBoxOutput.Text = Decrypt(textToEncrypt, dict);

            if (textBoxOutput.Text.Length == 0) buttonExport.Enabled = false;
            else buttonExport.Enabled = true;
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxInput.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog.FileName;
                File.WriteAllText("Result", textBoxOutput.Text);
            }
        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {
            if (textBoxInput.Text.Length == 0) buttonAccept.Enabled = false;
            else buttonAccept.Enabled = true;
        }
    }
}
