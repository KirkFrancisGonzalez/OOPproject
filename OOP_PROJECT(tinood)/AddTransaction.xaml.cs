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

namespace OOP_PROJECT_tinood_
{
    /// <summary>
    /// Interaction logic for AddTransaction.xaml
    /// </summary>
    public partial class AddTransaction : Window
    {
        public AddTransaction()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddCustomer addcus = new AddCustomer();
            addcus.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void cmbProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbProduct.Text == "Necklace")
            {
                txtblkPrice.Text = Convert.ToString(5000);
            }
            else if (cmbProduct.Text == "Bracelet")
            {
                txtblkPrice.Text = Convert.ToString(100);
            }
            else if (cmbProduct.Text == "Earrings")
            {
                txtblkPrice.Text = Convert.ToString(300);
            }
            
        }
    }
}
