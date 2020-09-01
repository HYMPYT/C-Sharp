using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Структуры
{
    public struct StructTest
    {
        public int _data;
        
        public int Data
        {
            get => _data;
            set => _data = value;
        }
        public StructTest(int data)
        {
            _data = data;
        }

    }
}
