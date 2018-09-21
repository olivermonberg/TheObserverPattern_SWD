using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheObserverPattern
{
    public class LocalStock
    {
        public string Name;
        public double StockValue;
        public int AmountOfStocks;
    }

    public interface IPortfolio
    {
        
        void Update(Stock stock);
        void AddStock(Stock _stock, int amount);

        List<LocalStock> _LocalStocksList { get; set; }
    }

    public class Portfolio : IPortfolio
    {
        

        public void AddStock(Stock _stock, int amount)
        {
            _stock.Attach(this);

            LocalStock l = new LocalStock();
            l.Name = _stock.Name;
            l.StockValue = _stock.StockValue;
            l.AmountOfStocks = amount;
            _LocalStocksList.Add(l);
        }

        public void Update(Stock _stock)
        {
            int i = _LocalStocksList.FindIndex(x => x.Name == _stock.Name);

            _LocalStocksList[i].StockValue = _stock.StockValue;
        }

        public List<LocalStock> _LocalStocksList { get; set; } = new List<LocalStock>();
}

    public class DisplayPortfolio
    {
        public DisplayPortfolio()
        {
        }

        public void Output(IPortfolio p)
        {
            Console.Clear();
            foreach (var stock in p._LocalStocksList)
            {
                Console.WriteLine($"StockName: {stock.Name}, StockValue: {Math.Round(stock.StockValue, 2)}" +
                    $", AmountOfStocks: {stock.AmountOfStocks}");
            }
        }
    }
}
