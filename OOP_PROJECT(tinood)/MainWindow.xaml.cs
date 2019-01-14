using System.Windows.Controls;
using System.Windows;
using System.Collections.Generic;
using System;

namespace OOP_PROJECT_tinood_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataStorage data = new DataStorage();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddTransaction trans = new AddTransaction();
            trans.Show();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AddJewelry jew = new AddJewelry();
            jew.Show();
            this.Hide();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AddTransaction(object sender, RoutedEventArgs e)
        {
            AddTransaction add_Transaction = new AddTransaction();
            add_Transaction.data = data;
            add_Transaction.Show();
        }
       
    }
        public class DataStorage
        {
            public List<PersonClass> customers = new List<PersonClass>();
            public List<ProductClass> jewelries = new List<ProductClass>();
        }
}
