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
    /// Interaction logic for AddCustomer.xaml
    /// </summary>
    public partial class AddCustomer : Window
    {
        public DataStorage data;
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PersonClass customer = new PersonClass(txtFname.Text, txtLname.Text, txtMname.Text);
            data.customers.Add(customer);
            AddTransaction trans = new AddTransaction();
            trans.Show();
            this.Close();
        }
    }
}
