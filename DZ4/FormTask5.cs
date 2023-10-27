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
    public partial class FormTask5 : Form
    {
        public FormTask5()
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

            listBox1.Items.Clear();

            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                count(fbd.SelectedPath, textBox1.Text);
            }
        }
        private async Task count(string pathToDir, string word)
        {
            var files = Directory.GetFiles(pathToDir);
            foreach (var file in files)
            {
                using (FileStream fs = new FileStream(file, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        string text = sr.ReadToEnd();
                        int count = text.Split(word).Count() - 1;
                        listBox1.Items.Add($"Path: {file} | word: {word} | found: {count}");
                    }
                }
                await Task.Delay(100);
            }
            var dirs = Directory.GetDirectories(pathToDir);
            foreach (var dir in dirs)
            {
                count(dir, word);
            }
        }
    }
}
