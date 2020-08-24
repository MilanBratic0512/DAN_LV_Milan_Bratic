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
using Zadatak_1.Model;
using Zadatak_1.ViewModel;

namespace Zadatak_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainWindowViewModel mwvm = new MainWindowViewModel();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = mwvm;
            btnCalc.IsEnabled = false;
            
        }

        private void AddIngredients(object sender, RoutedEventArgs e)
        {
            btnCalc.IsEnabled = true;
            PizzaIngredient ingredient = (sender as Button).DataContext as PizzaIngredient;
            mwvm.AddIngredient(ingredient);
            try
            {
                datagrid.Items.Refresh();
                datagrid2.Items.Refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }

        }

        private void Calculate(object sender, RoutedEventArgs e)
        {
            
            mwvm.CalculatePrice();
            MessageBox.Show("Total price: " + mwvm.Pizza.TotalPrice);
            mwvm.AddedIngredients.Clear();
            try
            {
                datagrid2.Items.Refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
           
        }
    }
}
