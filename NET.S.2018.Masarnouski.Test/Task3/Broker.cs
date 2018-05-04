using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Broker : IObserver
    {
        private IObservable stock;

        public string Name { get; set; }

        public Broker(string name, IObservable observable)
        {
            this.Name = name;
            stock = observable;
            stock.Register(this);
        }

        public void Update()
        {
            if (stock.USD > 30)
            {
                stock.RaisedValue += (object sender, StockInfoEventArgs args) => Console.WriteLine($"Broker {this.Name} " +
                    $"покупает доллар. Курс доллара {stock.USD}");
                stock.OnChangeValue(this, new StockInfoEventArgs(stock.USD, stock.Euro));
            }
            else
            {
                stock.RaisedValue += (object sender, StockInfoEventArgs args) => Console.WriteLine($"Broker " +
                    $"{this.Name} продаёт доллар.Курс доллара {stock.USD}");
                stock.OnChangeValue(this, new StockInfoEventArgs(stock.USD, stock.Euro));
            }
        }

        public void StopTrade()
        {
            stock.Unregister(this);
            stock = null;
        }
    }
}
