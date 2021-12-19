using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfBankApp
{
    /// <summary>
    /// Interaction logic for BankBackOffice.xaml
    /// </summary>
    public partial class BankBackOffice : Window
    {
        
        public BankBackOffice()
        {
            InitializeComponent();
            DataContext = BankContext.Instance;
        }
        private void btnCreateMoneyBackCard_Click(object sender, RoutedEventArgs e)
        {
            BankContext.Instance.CreateCard("moneyback", 1000, 1);
        }
        private void btnCreatePlatinumCard_Click(object sender, RoutedEventArgs e)
        {
            BankContext.Instance.CreateCard("platinum", 2000, 5);

        }
        private void btnCreateTitaniumCard_Click(object sender, RoutedEventArgs e)
        {
            BankContext.Instance.CreateCard("titanium", 5000, 10);
        }
    }
}
