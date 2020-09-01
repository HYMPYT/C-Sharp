using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Statistic1
{
    public partial class Form1 : Form
    {
        private List<string> legends;
        private List<double> results;
        public Form1()
        {
            InitializeComponent();
            legends = new List<string>();
            results = new List<double>();
        }

        private void add_Click(object sender, EventArgs e)
        {
            string _legend = legend.Text;
            string _result = result.Text;
            if(_legend == "" || _result == "")
            {
                MessageBox.Show("Вы не заполнили всех полей", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dataList.Items.Add($"{_legend} - {_result}");
                legend.Clear();
                result.Clear();
                double res = 0;
                try
                {
                    res = double.Parse(_result);
                    results.Add(res);
                    legends.Add(_legend);
                }
                catch(Exception err)
                {
                    MessageBox.Show(err.Message, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void del_Click(object sender, EventArgs e)
        {
            int k = dataList.SelectedIndex;
            if(k == -1)
            {
                MessageBox.Show("Вы не выделили данных для удаления", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dataList.Items.RemoveAt(k);
                results.RemoveAt(k);
                legends.RemoveAt(k);
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            legend.Clear();
            result.Clear();
        }

        private void clearAll_Click(object sender, EventArgs e)
        {
            legend.Clear();
            result.Clear();
            dataList.Items.Clear();
            results.Clear();
            legends.Clear();
            report.Clear();
        }

        private void calc_Click(object sender, EventArgs e)
        {
            double Ave = results.Average();
            double m = results.Min();
            double M = results.Max();
            int k1 = results.FindIndex(r => r == m);
            int k2 = results.FindIndex(r => r == M);
            string legendMin = legends[k1];
            string legendMax = legends[k2];
            string str_report = "Отчет по результатам вычислений:\r\n";
            str_report += $"Среднее арифметическое значение - {Ave:F}\r\n";
            str_report += $"Min => {m} / {legendMin}\r\n";
            str_report += $"Max => {M} / {legendMax}\r\n";
            report.Text = str_report;  
        }
    }
}
