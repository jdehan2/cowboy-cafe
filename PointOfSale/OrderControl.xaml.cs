using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CowboyCafe.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public OrderControl()
        {
            InitializeComponent();

            ItemSelectionButton.Click += ItemSelectionClicked;
            CancelButton.Click += CancelClicked;
            CompleteButton.Click += CompleteClicked;
            this.DataContext = new Order();
        }


        public void SwapScreen(UIElement element)
        {
            Container.Child = element;
        }


        void ItemSelectionClicked(object sender, RoutedEventArgs e)
        {
            

        }
        void CancelClicked(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();

        }
        void CompleteClicked(object sender, RoutedEventArgs e)
        {

            this.DataContext = new Order();
        }
    }
}
