using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public interface IObservable
    {
        int USD { get; set; }
        int Euro { get; set; }
        event StockHandler RaisedValue;
        void OnChangeValue(object sender, StockInfoEventArgs args);
        void Register(IObserver observer);
        void Unregister(IObserver observer);
        void Notify();
    }
}
