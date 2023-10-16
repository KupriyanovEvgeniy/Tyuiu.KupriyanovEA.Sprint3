using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KupriyanovEA.Sprint3.Task0.V7.Lib
{
    public class DataService : ISprint3Task0V7
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sumSeries = 0;
            int i = 0;
            for ( i = startValue; i <= stopValue; i++)
            {
                sumSeries = sumSeries + ((Math.Pow(value, i) + 1) * Math.Cos(i));
            }
            double res = Math.Round(sumSeries, 3);
            return res;
        }
    }
}
