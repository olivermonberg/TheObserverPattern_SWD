using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TheObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Portfolio p1 = new Portfolio();
            Portfolio p2 = new Portfolio();

            Stock Maersk = new MaerskStock(750);
            Stock Google = new GoogleStock(1550);
            
            p1.AddStock(Maersk, 3);
            p1.AddStock(Google, 6);

            Google.StockValue = 500;

            Thread t1 = new System.Threading.Thread(new System.Threading.ThreadStart(Google.UpdateStockValueAuto));
            t1.Start();

            Thread t2 = new System.Threading.Thread(new System.Threading.ThreadStart(Maersk.UpdateStockValueAuto));
            t2.Start();

            //Maersk.SetStockValue(600);
            //Google.SetStockValue(1600);

            while (true)
            {
                System.Threading.Thread.Sleep(4000);

                DisplayPortfolio dp1 = new DisplayPortfolio();

                dp1.Output(p1);  
            }

            
        }
    }
}
