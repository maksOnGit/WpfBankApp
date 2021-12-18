using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public class PlatinumFactory : CardFactory
    {
        private int _creditLimit;
        private int _annualCharge;

        public PlatinumFactory(int creditLimit, int annualCharge)
        {
            _creditLimit = creditLimit;
            _annualCharge = annualCharge;
        }

        //Return concrete product/class
        public override CreditCard GetCreditCard()
        {

            return new PlatinumCreditCard(_creditLimit, _annualCharge);
        }
    }
}
