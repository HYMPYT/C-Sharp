using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calc_Click(object sender, EventArgs e)
        {
            if(mod1.Checked)
            {
                try
                {
                    double F = double.Parse(fieldF.Text);
                    double C = (F - 32) * 5 / 9;
                    fieldC.Text = $"{C:F}";
                }
                catch(Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
            else
            {
                try
                {
                    double C = double.Parse(fieldC.Text);
                    double F = 32 + C * 1.8;
                    fieldF.Text = $"{F:F}";
                }
                catch(Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            ResetFields();
            if(mod1.Checked)
            {
                fieldF.Focus();
            }
            else
            {
                fieldC.Focus();
            }
        }

        private void ResetFields()
        {
            fieldF.Clear();
            fieldC.Clear();
        }

        private void mod1_CheckedChanged(object sender, EventArgs e)
        {
            if(mod1.Checked)
            {
                fieldF.ReadOnly = false;
                fieldC.ReadOnly = true;
                fieldF.Focus();
            }
            else
            {
                fieldF.ReadOnly = true;
                fieldC.ReadOnly = false;
                fieldC.Focus();
            }
            ResetFields();
        }
    }
}
