using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.Accounting
{
    public class Account
    {
        private string? accountNumber;

        public string AccountNumber
        {
            get { 
                if (accountNumber == null)
                {
                    throw new ArgumentNullException(nameof(accountNumber));
                }
                return accountNumber; }
            set { accountNumber = value; }
        }
    }
}