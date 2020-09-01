using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace AsyncDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OperationAsync(int operationId, int volume, int delay, TextBox reportField, ProgressBar progress, Button start)
        {
            // 1
            start.Enabled = false;
            reportField.Text = $"Операция № {operationId} - запущена на выполнение\r\n";
            Thread.Sleep(delay);
            progress.Maximum = volume;

            // 2
            int counter = 0;
            for (int i = 0; i < volume; i++)
            {
                counter = i + 1;
                reportField.Text += $"Поток № {Thread.CurrentThread.ManagedThreadId}: " +
                    $"действие № {counter} / {volume} - выполнено\r\n";
                progress.Value++;
                Thread.Sleep(delay);
            }

            // 3
            reportField.Text = $"Операция № {operationId} - успешно завершена\r\n";
            reportField.Text += $"Количество действий - {counter} / {volume}\r\n";
            reportField.Text += $"Расход времени - {(counter * delay / 1000.0):f}";
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                OperationAsync(1, 25, 500, textBox1, progressBar1, button1);
            });
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                OperationAsync(2, 15, 500, textBox2, progressBar2, button3);
            });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            progressBar1.Value = 0;
            progressBar2.Value = 0;
            button1.Enabled = true;
            button3.Enabled = true;
        }
    }
}
