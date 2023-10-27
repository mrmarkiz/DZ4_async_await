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
    public partial class FormTask2 : Form
    {
        private int _currentPlace;
        public FormTask2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _currentPlace = 0;
            button1.Enabled = false;
            _clearBars();
            listBox1.Items.Clear();

            _startRace(new Random());
        }

        private void _clearBars()
        {
            var items = this.Controls;
            foreach (var item in items)
            {
                if (item is ProgressBar)
                {
                    ((ProgressBar)item).Value = 0;
                }
            }
        }

        private async Task _startRace(Random rnd)
        {
            var items = this.Controls;
            foreach (var item in items)
            {
                if (item is ProgressBar)
                {
                    _run((ProgressBar)item, rnd.Next(5, 10));
                }
            }
        }

        private async Task _run(ProgressBar horse, int speed)
        {
            while (horse.Value < 100 - speed)
            {
                horse.Value += speed;
                await Task.Delay(200);
            }
            horse.Value = 100;
            listBox1.Items.Add($"{++_currentPlace}th place - Horse number {horse.Name.Last()}");
            if (_currentPlace == 5)
            {
                button1.Enabled = true;
            }
        }
    }
}
