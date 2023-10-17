using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KupriyanovEA.Sprint3.Task2.V9.Lib
{
    public class DataService : ISprint3Task2V9
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double multSeries = 0;
            do
            {
                multSeries = multSeries + Math.Pow((1 / Math.Pow(value, startValue)), 2);
                startValue++;
            } while (startValue <= stopValue);
            double res = Math.Round(multSeries, 3);
            return res;
        }
    }
}
