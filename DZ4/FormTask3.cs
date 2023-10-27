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
    public partial class FormTask3 : Form
    {
        public FormTask3()
        {
            InitializeComponent();
        }
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            generate((int)numericUpDown1.Value);
        }

        private async Task generate(int upper_bound)
        {
            for (int i = 0; i < upper_bound; i++)
            {
                if (isFibonacci(i))
                {
                    listBox1.Items.Add(i.ToString());
                    await Task.Delay(100);
                }
            }
        }

        private bool isFibonacci(int i)
        {
            int a = 0, b = 1, tmp;
            while (a < i)
            {
                tmp = a + b;
                a = b;
                b = tmp;
            }
            return a == i;
        }
    }
}
