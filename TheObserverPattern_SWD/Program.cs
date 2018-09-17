using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Portfolio p1 = new Portfolio();

            Stock MaerskA = new Stock("MaerskA", 850);
            Stock MaerskB = new Stock("MaerskB", 750);

            p1.AddStock(MaerskA,2);
            p1.AddStock(MaerskB, 3);

            //MaerskA.Notify();
            //MaerskB.Notify();

            MaerskB.StockValue = 600;

            MaerskB.Notify();

            

            DisplayPortfolio dp1 = new DisplayPortfolio();

            dp1.Output(p1);
        }
    }
}
