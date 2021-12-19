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

        #region Singleton pattern, lazy loading
        private static readonly Lazy<BankContext> _instance = new Lazy<BankContext>(() => new BankContext());
        public static BankContext Instance
        {
            get { return _instance.Value; }
        }
        
        #endregion

        private CardFactory factory = null;
        private BankContext()
        {

        }

        public void CreateCard(string cardType, int creditLimit, int annualCharge)
        {
            factory = new AllCardFactory(cardType, creditLimit, annualCharge);
            CreditCards.Add(factory.GetCreditCard());
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}
