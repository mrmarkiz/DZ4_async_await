using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ4
{
    public partial class FormTask4 : Form
    {
        public FormTask4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Enter word first!");
                return;
            }

            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                count(ofd.FileName, textBox1.Text);
            }
        }
        private async Task count(string pathToFile, string word)
        {
            using (FileStream fs = new FileStream(pathToFile, FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    string text = sr.ReadToEnd();
                    int count = text.Split(word).Count() - 1;
                    listBox1.Items.Add($"File: {pathToFile} | word: {word} | found: {count}");
                    await Task.Delay(100);
                }
            }
        }
    }
}
