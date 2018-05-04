using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public delegate void StockHandler(object sender, StockInfoEventArgs args);

    public class Stock : IObservable
    {
        public int USD { get; set; }
        public int Euro { get; set; }

        public event StockHandler RaisedValue;

        public void OnChangeValue(object sender, StockInfoEventArgs args)
        {
            RaisedValue?.Invoke(sender,args);
            RaisedValue = null;
        }

        private List<IObserver> observers;

        public Stock()
        {
            observers = new List<IObserver>();
        }

        public void Register(IObserver observer) => observers.Add(observer);

        public void Unregister(IObserver observer) => observers.Remove(observer);

        public void Notify()
        {
            //foreach (IObserver o in observers)
            //{
            //    o.Update(stocksInfo);
            //}
        }

        public void Market()
        {
            Random rnd = new Random();
            USD = rnd.Next(20, 40);
            Euro = rnd.Next(30, 50);
            //Notify();
        }
    }
}
