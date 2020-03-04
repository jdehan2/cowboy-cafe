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
    /// Interaction logic for MenuItemSelectionMenu.xaml
    /// </summary>
    public partial class MenuItemSelectionMenu : UserControl
    {
        public MenuItemSelectionMenu()
        {
            InitializeComponent();
            //Entrees
            AddCowpokeChiliButton.Click += OnAddCowpokeChiliButtonClicked;
            AddRustlersRibs.Click += OnAddCowpokeChiliButtonClicked;
            AddPecosPulledPork.Click += OnAddCowpokeChiliButtonClicked;
            AddTrailBurgerButton.Click += OnAddCowpokeChiliButtonClicked;
            AddDakotaDoubleBurgerButton.Click += OnAddCowpokeChiliButtonClicked;
            AddTexasTripleBurgerButton.Click += OnAddCowpokeChiliButtonClicked;
            AddAngryChickenButton.Click += OnAddCowpokeChiliButtonClicked;
            //Sides
            AddChiliCheeseFriesButton.Click += OnAddCowpokeChiliButtonClicked;
            AddCornDodgersButton.Click += OnAddCowpokeChiliButtonClicked;
            AddPanDeCampoButton.Click += OnAddCowpokeChiliButtonClicked;
            AddBakedBeansButton.Click += OnAddCowpokeChiliButtonClicked;
            //Drinks
            AddJerkedSodaButton.Click += OnAddCowpokeChiliButtonClicked;
            AddTexasTeaButton.Click += OnAddCowpokeChiliButtonClicked;
            AddCowboyCoffeeButton.Click += OnAddCowpokeChiliButtonClicked;
            AddWaterButton.Click += OnAddCowpokeChiliButtonClicked;
            //AddButton.Click += OnAddButtonClicked;
        }


        void OnAddCowpokeChiliButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new CowpokeChili());

            }

        }
        /*
        void OnAddRustlersRibsClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new RustlersRibs());
        }
        void OnAddPecosPulledPorkClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new PecosPulledPork());
        }

        void OnAddTrailBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new TrailBurger());
        }
        void OnAddDakotaDoubleBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new DakotaDoubleBurger());
        }
        void OnAddTexasTripleBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new TexasTripleBurger());
        }

        void OnAddAngryChickenButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new AngryChicken());
        }

        //Sides

        void OnAddChiliCheeseFriesButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new ChiliCheeseFries());
        }

        void OnAddCornDodgersButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new CornDodgers());
        }

        void OnAddPanDeCampoButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new PanDeCampo());
        }

        void OnAddBakedBeansButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new BakedBeans());
        }

        //Drinks

        void OnAddJerkedSodaButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new JerkedSoda());
        }
        void OnAddTexasTeaButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new TexasTea());
        }
        void OnAddCowboyCoffeeButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new CowboyCoffee());
        }

        void OnAddWaterButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new Water());
        }
        */


    
}
}
