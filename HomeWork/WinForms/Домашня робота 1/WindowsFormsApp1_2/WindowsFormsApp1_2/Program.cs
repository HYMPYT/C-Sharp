using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_2
{
    static class Program
    {
        static int count = 0;
        static DialogResult FindNumber()
        {
            DialogResult result;
            int L = 1, R = 2000, M;
            while (R >= 1)
            {
                count++;
                M = (L + R) / 2;
                result = MessageBox.Show($"Это ваше число {M}?", "Игра", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    result = MessageBox.Show($"Ваше число {M}.\nДля этого понадобилось {count} запросов.\nХотите сыграть снова?", "Игра", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    return result;
                }
                else
                {
                    count++;
                    result = MessageBox.Show($"Ваше число больше {M}?", "Игра", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        L = M + 1;
                    }
                    else
                    {
                        R = M - 1;
                    }
                }
            }
            return DialogResult.Abort;
        }
        [STAThread]
        static void Main()
        {
            DialogResult result;
            for (; ; )
            {
                MessageBox.Show("Игра \"Угадай Число\"");
                MessageBox.Show("Загадайте число от 1 до 2000", "Игра");
                result = FindNumber();
                if (result == DialogResult.Yes)
                {
                    continue;
                }
                else if (result == DialogResult.Abort)
                {
                    result = MessageBox.Show("Загаданое число не находилось в границах 1 - 2000.\nХотите попробовать снова?", "Игра", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                        continue;
                    else
                        break;
                }
                else
                    break;
            }
        }
    }
}
