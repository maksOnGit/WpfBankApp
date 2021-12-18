using BankLibrary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfBankApp
{
    public class BankContext : INotifyPropertyChanged
    {
        private ObservableCollection<CreditCard> creditCards = new ObservableCollection<CreditCard>();

        public ObservableCollection<CreditCard> CreditCards
        {
            get { return this.creditCards; }
            set
            {
                if (this.creditCards != value)
                {
                    this.creditCards = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private CardFactory factory = null;
        public BankContext()
        {

        }

        public void CreateCard(string cardType, int creditLimit, int annualCharge)
        {
            switch (cardType.ToLower())
            {
                case "moneyback":
                    factory = new MoneyBackFactory(creditLimit, annualCharge);
                    break;
                case "platinum":
                    factory = new PlatinumFactory(creditLimit, annualCharge);
                    break;
                case "titanium":
                    factory = new TitaniumFactory(creditLimit, annualCharge);
                    break;
            }

            CreditCards.Add(factory.GetCreditCard());
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}
