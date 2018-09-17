using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheObserverPattern
{
    public class Stock
    {
        public Stock()
        {

        }
        public Stock(string _name, double _stockValue)
        {
            Name = _name;
            StockValue = _stockValue;

        }

        public void Attach(IPortfolio portfolio)
        {
            _portfolio.Add(portfolio);
        }

        public void Notify()
        {
            foreach (var portfolio in _portfolio)
            {
                portfolio.Update(this);
            }
        }

        public void SetStockValue(double _stockValue)
        {
            StockValue = _stockValue;
            Notify();
        }

        public string Name { get; set; }
        public double StockValue { get; set; }

        public List<IPortfolio> _portfolio = new List<IPortfolio>();


    }

    
}
