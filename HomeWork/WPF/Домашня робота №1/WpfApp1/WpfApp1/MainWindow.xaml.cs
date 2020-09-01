using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double CurrNumber { get; set; }
        public double Result { get; set; }
        public string ResultText { get; set; }
        public string Buf { get; set; }

        private static int count;
        private static int dotCount;
        private mode currMode;
        enum mode
        {
            mult, div, sub, add, not, equally, dot
        }

        public MainWindow()
        {
            InitializeComponent();
            CurrNumber = 0;
            CurrNumberField.Content = (int)CurrNumber;
            count = 0;
            dotCount = 0;
            currMode = mode.not;
            ResultText = "";
        }

        private void NumberClick(object sender, RoutedEventArgs e)
        {
            if (currMode == mode.equally)
            {
                Result = CurrNumber = 0;
                ResultText = "";
                ExpressionField.Content = "";
                currMode = mode.not;
            }
            if (currMode == mode.dot)
            {
                count++;
                Buf += sender.GetType().GetProperty("Content").GetValue(sender).ToString();
                CurrNumber = double.Parse(Buf);
                CurrNumberField.Content = CurrNumber;
            }
            else
            {
                count++;
                Buf = CurrNumber.ToString();
                Buf += sender.GetType().GetProperty("Content").GetValue(sender).ToString();
                CurrNumber = double.Parse(Buf);
                CurrNumberField.Content = CurrNumber;
            }
        }

        private void CurCleanBtn_Click(object sender, RoutedEventArgs e)
        {
            currMode = mode.not;
            CurrNumber = 0;
            count = 0;
            dotCount = 0;
            CurrNumberField.Content = CurrNumber;
        }

        private void DotBtn_Click(object sender, RoutedEventArgs e)
        {
            if (dotCount == 1)
                return;
            dotCount++;
            Buf = CurrNumber.ToString();
            Buf += ",";
            CurrNumberField.Content = Buf;
            currMode = mode.dot;
        }

        private void CleanAllBtn_Click(object sender, RoutedEventArgs e)
        {
            CurrNumber = 0;
            count = 0;
            dotCount = 0;
            CurrNumberField.Content = CurrNumber;
            Result = 0;
            ExpressionField.Content = "";
            currMode = mode.not;
            ResultText = "";
        }

        private void CleanLastSymbolBtn_Click(object sender, RoutedEventArgs e)
        {
            if (count == 0)
                return;

            if (count == 1)
            {
                CurrNumber = 0;
                CurrNumberField.Content = CurrNumber;
            }
            else
            {
                Buf = CurrNumber.ToString();
                Buf = Buf.Remove(Buf.Length - 1);
                CurrNumber = int.Parse(Buf);
                CurrNumberField.Content = CurrNumber;
            }
            count--;
        }

        private void DivBtn_Click(object sender, RoutedEventArgs e)
        {
            count = 0;
            dotCount = 0;
            if (currMode != mode.not)
            {
                switch (currMode)
                {
                    case mode.add:
                        Result = Result + CurrNumber;
                        CurrNumberField.Content = Result;
                        ResultText = ResultText + CurrNumber + " / ";
                        CurrNumber = 0;
                        break;

                    case mode.div:
                        if (CurrNumber == 0)
                        {
                            currMode = mode.not;
                            CurrNumberField.Content = "Error!";
                            CurrNumber = 0;
                            Result = 0;
                            ResultText = "";
                            ExpressionField.Content = "";
                        }
                        else
                        {
                            Result = Result / CurrNumber;
                            CurrNumberField.Content = Result;
                            ResultText = ResultText + CurrNumber + " / ";
                            CurrNumber = 0;
                        }
                        break;

                    case mode.mult:
                        Result = Result * CurrNumber;
                        CurrNumberField.Content = Result;
                        ResultText = ResultText + CurrNumber + " / ";
                        CurrNumber = 0;
                        break;

                    case mode.sub:
                        Result = Result - CurrNumber;
                        CurrNumberField.Content = Result;
                        ResultText = ResultText + CurrNumber + " / ";
                        CurrNumber = 0;
                        break;

                    case mode.dot:
                        if (ResultText == "")
                        {
                            ResultText = CurrNumber + " / ";
                        }
                        else
                        {
                            ResultText = ResultText + CurrNumber + " / ";
                        }
                        Result = CurrNumber;
                        CurrNumber = 0;
                        break;

                    case mode.equally:
                        ResultText = Result + " / ";
                        ExpressionField.Content = ResultText;
                        break;
                }
            }
            else
            {
                if (ResultText == "")
                {
                    ResultText = CurrNumber + " / ";
                }
                else
                {
                    ResultText = ResultText + CurrNumber + " / ";
                }
                Result = CurrNumber;
                CurrNumber = 0;
            }
            currMode = mode.div;
            ExpressionField.Content = ResultText;
        }

        private void MulBtn_Click(object sender, RoutedEventArgs e)
        {
            count = 0;
            dotCount = 0;
            if (currMode != mode.not)
            {
                switch (currMode)
                {
                    case mode.add:
                        Result = Result + CurrNumber;
                        CurrNumberField.Content = Result;
                        ResultText = ResultText + CurrNumber + " * ";
                        CurrNumber = 0;
                        break;

                    case mode.div:
                        if (CurrNumber == 0)
                        {
                            currMode = mode.not;
                            CurrNumberField.Content = "Error!";
                            CurrNumber = 0;
                            Result = 0;
                            ResultText = "";
                            ExpressionField.Content = "";
                        }
                        else
                        {
                            Result = Result / CurrNumber;
                            CurrNumberField.Content = Result;
                            ResultText = ResultText + CurrNumber + " * ";
                            CurrNumber = 0;
                        }
                        break;

                    case mode.mult:
                        Result = Result * CurrNumber;
                        CurrNumberField.Content = Result;
                        ResultText = ResultText + CurrNumber + " * ";
                        CurrNumber = 0;
                        break;

                    case mode.sub:
                        Result = Result - CurrNumber;
                        CurrNumberField.Content = Result;
                        ResultText = ResultText + CurrNumber + " * ";
                        CurrNumber = 0;
                        break;

                    case mode.dot:
                        if (ResultText == "")
                        {
                            ResultText = CurrNumber + " * ";
                        }
                        else
                        {
                            ResultText = ResultText + CurrNumber + " * ";
                        }
                        Result = CurrNumber;
                        CurrNumber = 0;
                        break;

                    case mode.equally:
                        ResultText = Result + " * ";
                        ExpressionField.Content = ResultText;
                        break;
                }
            }
            else
            {
                if (ResultText == "")
                {
                    ResultText = CurrNumber + " * ";
                }
                else
                {
                    ResultText = ResultText + CurrNumber + " * ";
                }
                Result = CurrNumber;
                CurrNumber = 0;
            }
            currMode = mode.mult;
            ExpressionField.Content = ResultText;
        }

        private void SubBtn_Click(object sender, RoutedEventArgs e)
        {
            count = 0;
            dotCount = 0;
            if (currMode != mode.not)
            {
                switch (currMode)
                {
                    case mode.add:
                        Result = Result + CurrNumber;
                        CurrNumberField.Content = Result;
                        ResultText = ResultText + CurrNumber + " - ";
                        CurrNumber = 0;
                        break;

                    case mode.div:
                        if (CurrNumber == 0)
                        {
                            currMode = mode.not;
                            CurrNumberField.Content = "Error!";
                            CurrNumber = 0;
                            Result = 0;
                            ResultText = "";
                            ExpressionField.Content = "";
                        }
                        else
                        {
                            Result = Result / CurrNumber;
                            CurrNumberField.Content = Result;
                            ResultText = ResultText + CurrNumber + " - ";
                            CurrNumber = 0;
                        }
                        break;

                    case mode.mult:
                        Result = Result * CurrNumber;
                        CurrNumberField.Content = Result;
                        ResultText = ResultText + CurrNumber + " - ";
                        CurrNumber = 0;
                        break;

                    case mode.sub:
                        Result = Result - CurrNumber;
                        CurrNumberField.Content = Result;
                        ResultText = ResultText + CurrNumber + " - ";
                        CurrNumber = 0;
                        break;

                    case mode.dot:
                        if (ResultText == "")
                        {
                            ResultText = CurrNumber + " - ";
                        }
                        else
                        {
                            ResultText = ResultText + CurrNumber + " - ";
                        }
                        Result = CurrNumber;
                        CurrNumber = 0;
                        break;

                    case mode.equally:
                        ResultText = Result + " - ";
                        ExpressionField.Content = ResultText;
                        break;
                }
            }
            else
            {
                if (ResultText == "")
                {
                    ResultText = CurrNumber + " - ";
                }
                else
                {
                    ResultText = ResultText + CurrNumber + " - ";
                }
                Result = CurrNumber;
                CurrNumber = 0;
            }
            currMode = mode.sub;
            ExpressionField.Content = ResultText;
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            count = 0;
            dotCount = 0;
            if (currMode != mode.not)
            {
                switch (currMode)
                {
                    case mode.add:
                        Result = Result + CurrNumber;
                        CurrNumberField.Content = Result;
                        ResultText = ResultText + CurrNumber + " + ";
                        CurrNumber = 0;
                        break;

                    case mode.div:
                        if (CurrNumber == 0)
                        {
                            currMode = mode.not;
                            CurrNumberField.Content = "Error!";
                            CurrNumber = 0;
                            Result = 0;
                            ResultText = "";
                            ExpressionField.Content = "";
                        }
                        else
                        {
                            Result = Result / CurrNumber;
                            CurrNumberField.Content = Result;
                            ResultText = ResultText + CurrNumber + " + ";
                            CurrNumber = 0;
                        }
                        break;

                    case mode.mult:
                        Result = Result * CurrNumber;
                        CurrNumberField.Content = Result;
                        ResultText = ResultText + CurrNumber + " + ";
                        CurrNumber = 0;
                        break;

                    case mode.sub:
                        Result = Result - CurrNumber;
                        CurrNumberField.Content = Result;
                        ResultText = ResultText + CurrNumber + " + ";
                        CurrNumber = 0;
                        break;

                    case mode.dot:
                        if (ResultText == "")
                        {
                            ResultText = CurrNumber + " + ";
                        }
                        else
                        {
                            ResultText = ResultText + CurrNumber + " + ";
                        }
                        Result = CurrNumber;
                        CurrNumber = 0;
                        break;

                    case mode.equally:
                        ResultText = Result + " + ";
                        ExpressionField.Content = ResultText;
                        break;
                }
            }
            else
            {
                if (ResultText == "")
                {
                    ResultText = CurrNumber + " + ";
                }
                else
                {
                    ResultText = ResultText + CurrNumber + " + ";
                }
                Result = CurrNumber;
                CurrNumber = 0;
            }
            currMode = mode.add;
            ExpressionField.Content = ResultText;
        }

        private void EquallyBtn_Click(object sender, RoutedEventArgs e)
        {
            count = 0;
            dotCount = 0;
            if (currMode != mode.not)
            {
                switch (currMode)
                {
                    case mode.add:
                        Result = Result + CurrNumber;
                        CurrNumberField.Content = Result;
                        ResultText = ResultText + CurrNumber + " =";
                        CurrNumber = 0;
                        break;

                    case mode.div:
                        if (CurrNumber == 0)
                        {
                            currMode = mode.not;
                            CurrNumberField.Content = "Error!";
                            CurrNumber = 0;
                            Result = 0;
                            ResultText = "";
                            ExpressionField.Content = "";
                        }
                        else
                        {
                            Result = Result / CurrNumber;
                            CurrNumberField.Content = Result;
                            ResultText = ResultText + CurrNumber + " =";
                            CurrNumber = 0;
                        }
                        break;

                    case mode.mult:
                        Result = Result * CurrNumber;
                        CurrNumberField.Content = Result;
                        ResultText = ResultText + CurrNumber + " =";
                        CurrNumber = 0;
                        break;

                    case mode.sub:
                        Result = Result - CurrNumber;
                        CurrNumberField.Content = Result;
                        ResultText = ResultText + CurrNumber + " =";
                        CurrNumber = 0;
                        break;

                    case mode.dot:
                        if (ResultText == "")
                        {
                            ResultText = CurrNumber + " = ";
                        }
                        else
                        {
                            ResultText = ResultText + CurrNumber + " = ";
                        }
                        Result = CurrNumber;
                        CurrNumberField.Content = Result;
                        CurrNumber = 0;
                        break;
                }
            }
            currMode = mode.equally;
            ExpressionField.Content = ResultText;
        }
    }
}
