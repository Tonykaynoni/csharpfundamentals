using Bank.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Uba : IBank
    {
        public int Balance { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        public int BankName { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException();
        }

        public void Credit()
        {
            throw new NotImplementedException();
        }

        public void Debit()
        {
            throw new NotImplementedException();
        }
    }
}
