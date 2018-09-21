using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheObserverPattern
{
    public class MaerskStock : Stock
    {
       public MaerskStock(double _stockValue)
       {
           Name = "Maersk";
           StockValue = _stockValue;
       }
    }
}
