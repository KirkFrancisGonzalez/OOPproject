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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OOP_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Person Customer;
        TransactionWindow transwin = new TransactionWindow();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            

            Customer = new Person(this.txtFname.Text, this.txtLastName.Text, this.txtMiddleInitial.Text);
            Customer.Birthdate = this.txtBirthDate.Text;
            Customer.Address = this.txtAddress.Text;

            transwin.Show();
            this.Close();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Recommendations win2 = new Recommendations();
            win2.Show();
            this.Close();
        }
    }
}
