using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public class AllCardFactory : CardFactory
    {
        private string _cardType;
        private int _creditLimit;
        private int _annualCharge;

        public AllCardFactory(string cardType, int creditLimit, int annualCharge)
        {
            _cardType = cardType;
            _creditLimit = creditLimit;
            _annualCharge = annualCharge;
        }


        //Return concrete product/class
        public override CreditCard GetCreditCard()
        {
            switch (_cardType.ToLower())
            {
                case "moneyback":
                    return new MoneyBackCreditCard(_creditLimit, _annualCharge);
                case "platinum":
                    return new PlatinumCreditCard(_creditLimit, _annualCharge);
                case "titanium":
                    return new TitaniumCreditCard(_creditLimit, _annualCharge);
            }
            return null;
        }
    }
}
