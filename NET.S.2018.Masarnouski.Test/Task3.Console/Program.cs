using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock stock = new Stock();
            Bank bank1 = new Bank("Москва-Минск", stock);
            Bank bank2 = new Bank("ВТБ", stock);
            stock.Market();
            bank1.Update();
            bank2.Update();
            stock.Market();
            bank1.Update();
            bank2.Update();

            System.Console.ReadLine();
        }
    }
}
