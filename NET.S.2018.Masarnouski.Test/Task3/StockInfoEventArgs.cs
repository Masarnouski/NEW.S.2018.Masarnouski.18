using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class StockInfoEventArgs:EventArgs
    {
        public StockInfoEventArgs(int CurrentUsd, int CurrentEuro)
        {
            USD = CurrentUsd;
            Euro = CurrentEuro;
        }

        public int USD { get; set; }
        public int Euro { get; set; }
    }
}
