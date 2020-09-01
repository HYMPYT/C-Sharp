using System;

namespace WindowsFormsApp3
{
    class MyEventArgs : EventArgs
    {
        private string _text;

        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }

        public MyEventArgs(string input_str) { _text = input_str; }
    }
}