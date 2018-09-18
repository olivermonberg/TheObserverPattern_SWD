using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheObserverPattern
{
    public interface IPortfolio
    {
        void Update(Stock stock);
        void AddStock(Stock _stock, int amount);

        
    }

    public class Portfolio : IPortfolio
    {
        public struct LocalStock
        {
            public string Name;
            public double StockValue;
            public int AmountOfStocks;
        }


        public void AddStock(Stock _stock, int amount)
        {
            _stock.Attach(this);
            
            LocalStock l = new LocalStock
            {
                Name = _stock.Name,
                StockValue = _stock.StockValue,
                AmountOfStocks = amount
            };
            _LocalStocksList.Add(l);
        }


        /*
         * Der er NOGET GALT MED UPDATE AF PORTEFØLJE
         */
        public void Update(Stock _stock) 
        {
            LocalStock index = _LocalStocksList.Find(x => x.Name == _stock.Name);

            index.StockValue = _stock.StockValue;
            
        }

        //int AmountOfStocks;

        

        public List<LocalStock> _LocalStocksList { get; } = new List<LocalStock>();


    //List<string> _NameOfStocks = new List<string>();
    //List<string> _ValueOfStocks = new List<string>();
}

    public class DisplayPortfolio
    {
        
        public DisplayPortfolio()
        {
            
        }

        public void Output(Portfolio p)
        {
            
            foreach (var stock in p._LocalStocksList)
            {
                Console.WriteLine($"StockName: {stock.Name} StockValue: {stock.StockValue}" +
                    $", AmountOfStocks: {stock.AmountOfStocks}");
            }
        }
        
    }
}
