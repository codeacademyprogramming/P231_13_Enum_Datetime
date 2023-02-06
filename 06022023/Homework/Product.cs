using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    internal class Product
    {
        static int _totalCount = 0;
        public Product()
        {
            _totalCount++;
            No = _totalCount;
        }
        public string Name;
        public int No;
        public double Price;
    }
}
