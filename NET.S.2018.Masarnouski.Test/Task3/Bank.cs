using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Bank : IObserver
    {
        private IObservable stock;

        public string Name { get; set; }

        public Bank(string name, IObservable observable)
        {
            this.Name = name;
            stock = observable;
            stock.Register(this);
        }

        public void Update()
        {
            if (stock.USD > 40)
            {
                stock.OnChangeValue(this, new StockInfoEventArgs(stock.USD, stock.Euro));
                stock.RaisedValue += (object sender, StockInfoEventArgs args) => Console.WriteLine($"Bank {this.Name} продаёт доллар. " +
                    $"Курс доллара {stock.USD}");
            }
            else
            {
                stock.RaisedValue += (object sender, StockInfoEventArgs args) => Console.WriteLine($"Bank {this.Name} покупает доллар. " +
                    $"Курс доллара {stock.USD}");
                stock.OnChangeValue(this, new StockInfoEventArgs(stock.USD, stock.Euro));
            }


        }
    }
}
