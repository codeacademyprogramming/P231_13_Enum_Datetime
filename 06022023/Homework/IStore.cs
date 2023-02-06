using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    internal interface IStore
    {
        Product[] Products { get; }
        void Add(Product product);
        bool HasProductByNo(int no);
        Product GetproductByNo(int no);
    }
}
