using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public class TitaniumFactory : CardFactory
    {
        private int _creditLimit;
        private int _annualCharge;

        public TitaniumFactory(int creditLimit, int annualCharge)
        {
            _creditLimit = creditLimit;
            _annualCharge = annualCharge;
        }
        

        //Return concrete product/class
        public override CreditCard GetCreditCard()
        {

            return new TitaniumCreditCard(_creditLimit, _annualCharge);
        }
    }
}
