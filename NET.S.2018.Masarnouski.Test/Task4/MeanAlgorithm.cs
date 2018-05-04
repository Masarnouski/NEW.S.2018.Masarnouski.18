using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task4.Interfaces;

namespace Task4
{
    class MeanAlgorithm : IMeanAlgorithm
    {
        public double CalculateAverage(List<double> values)
        {
            return values.Sum() / values.Count;
        }
    }
}
