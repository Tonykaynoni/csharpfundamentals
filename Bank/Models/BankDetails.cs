using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Models
{
    public class BankDetails
    {
        public int AccountNumber { get; set; }
        public string BankName { get; set; }

        public BankDetails(int AccountNumber, string BankName)
        {
            this.AccountNumber = AccountNumber;
            this.BankName = BankName;
        }
    }
}
