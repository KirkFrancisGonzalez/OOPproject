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

namespace OOP_Project
{
    /// <summary>
    /// Interaction logic for TransactionWindow.xaml
    /// </summary>
    public partial class TransactionWindow : Window
    {

        
        
        public TransactionWindow()
        {
            InitializeComponent();

           
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
         
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            lstDetails.Items.Add(main.Customer.GetFullName() + " ");
        }
    }
}
