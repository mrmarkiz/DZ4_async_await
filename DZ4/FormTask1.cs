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
    public partial class FormTask1 : Form
    {
        private int _barsLeft;
        public FormTask1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _clearProgressBars();
            button1.Enabled = false;
            _barsLeft = (int)numericUpDown1.Value;
            _createBars((int)numericUpDown1.Value);
        }

        private void _clearProgressBars()
        {
            var items = this.Controls;
            for (int i = items.Count - 1; i > -1; i--)
            {
                if (items[i] is ProgressBar)
                {
                    this.Controls.Remove(items[i]);
                }
            }
        }

        private async Task _createBars(int num)
        {
            Random rnd = new Random();
            for (int i = 0; i < num; i++)
            {
                _addBar(rnd, 12, 120 + i * 25);
            }
        }

        private async Task _addBar(Random rnd, int x, int y)
        {
            ProgressBar newBar = new ProgressBar();
            newBar.Width = 150; newBar.Height = 25;
            newBar.Location = new Point(x, y);
            newBar.BackColor = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
            newBar.Value = 0;
            this.Controls.Add(newBar);
            newBar.Show();
            int step = rnd.Next(5, 10);
            while (newBar.Value <= 100 - step)
            {
                newBar.Value += step;
                await Task.Delay(200);
            }
            if (newBar.Value != 100)
            {
                newBar.Value = 100;
            }
            _barsLeft--;
            if (_barsLeft == 0)
            {
                await Task.Delay(200);
                button1.Enabled = true;
            }
        }
    }
}
