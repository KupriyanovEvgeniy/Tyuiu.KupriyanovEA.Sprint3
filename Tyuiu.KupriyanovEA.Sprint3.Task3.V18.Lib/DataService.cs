using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KupriyanovEA.Sprint3.Task3.V18.Lib
{
    public class DataService : ISprint3Task3V18
    {
        public string ReplaceNumOnChar(string value, char item)
        {
            string str = value;
            foreach (char c in value)
            {
                if (Char.IsDigit(c))
                {
                    str = str.Replace(c, 'n');
                }
            }
            return str;
        }
    }
}
