using System;
using System.Collections.Generic;
using System.Linq;
using Task4.Interfaces;

namespace Task4
{
    public class Calculator
    {
        IMeanAlgorithm meanAlgorithm;
        IMedianAlgorithm medianAlgorithm;

        public Calculator(IMeanAlgorithm meanAlgorithm, IMedianAlgorithm medianAlgorithm)
        {
            this.meanAlgorithm = meanAlgorithm;
            this.medianAlgorithm = medianAlgorithm;
        }

        public double CalculateAverage(List<double> values, AveragingMethod averagingMethod)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            switch (averagingMethod)
            {
                case AveragingMethod.Mean:
                    return meanAlgorithm.CalculateAverage(values);
                    
                case AveragingMethod.Median:
                    return medianAlgorithm.CalculateAverage(values);
                    
                default:
                    throw new ArgumentException("Invalid averagingMethod value");
            }
        }
    }
}
