using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheObserverPattern
{
    class GoogleStock : Stock
    {
        public GoogleStock(double _stockValue)
        {
            Name = "Google";
            StockValue = _stockValue;
        }
    }
}
