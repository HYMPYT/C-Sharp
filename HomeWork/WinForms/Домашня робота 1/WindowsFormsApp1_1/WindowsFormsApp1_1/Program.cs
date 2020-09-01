using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_1
{
    static class Program
    {
        static DialogResult ShowMessageBoxes()
        {
            DialogResult result;
            MessageBox.Show("Петренко Іван Іванович\n\nКонтактна інформація:\nтел. (032) 123 - 45 - 67\ne - mail: ivan_petrenko@ua.fm\n\nПосада:\nПрограміст\n\nЗагальний досвід:\nСтворення програмного забезпечення на мові програмування С++.Відладка готових програм і навчання співробітників.", "Резюме", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("Досвід роботи:\nТравень 2003 – теперішній час\nТзОВ \"БудСервіс\"(будівельна фірма)\nПрограміст\nСтворення програм на мові С++;\nНавчання співробітників.\n\nВересень 2000 – Квітень 2003\nПП \"Світ комп’ютерної техніки\"(торгівля комп’ютерною технікою)\nПрограміст\nСтворення програм для Інтернету;\nНалаштування готових програм;\nНавчання співробітників.", "Резюме", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("Освіта:\n1995 - 2000р.Національний університет «Львівська політехніка»\nІнститут прикладної математики та фундаментальних наук\nСпеціальність: Соціальна інформатика, магістр.\n\nДодаткова освіта:\n1999 – 2000р.Курси англійської мови.", "Резюме", MessageBoxButtons.OK, MessageBoxIcon.Information);
            int avgWord = 135 / 4;
            result = MessageBox.Show("Знання ПК:\nзнання мов програмування: C++, Java, Accembler, PHP.\n\nІноземні мови:\nАнглійська, польська мови – розмовний рівень.\n\nДодаткова інформація:\nВік - 26 років\nСімейний стан – не одружений, дітей немає\nНаявність закордонного паспорту, водійські права категорії \"В\", досвід водіння 2 роки", $"Среднее число символов на странице {avgWord}", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
            return result;
        }
        [STAThread]
        static void Main()
        {
            DialogResult result;
            do
            {
                result = ShowMessageBoxes();
            } while (result == DialogResult.Retry);
        }
    }
}
