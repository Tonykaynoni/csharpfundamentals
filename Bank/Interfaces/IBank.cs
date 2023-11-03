using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Interfaces
{
    public interface IBank
    {
        public int Balance { get; set; }
        public int BankName { get; set; }
        public void Debit();
        public void Credit();
    }
}
