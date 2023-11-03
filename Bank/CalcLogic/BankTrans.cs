using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.CalcLogic
{
    public class BankTrans<T>
    {

        public string AddNumber(T a, T b)
        {
            dynamic sum = $"{a} {b}";
            return sum;
        }
    }
}
