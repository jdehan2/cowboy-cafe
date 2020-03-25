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
using CowboyCafe.Extentions;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuItemSelectionMenu.xaml
    /// </summary>
    public partial class MenuItemSelectionMenu : UserControl
    {

        private OrderControl orderControl;
        public MenuItemSelectionMenu()
        {



            InitializeComponent();

            

            //Entrees
            AddCowpokeChili.Click += OnAddRustlersRibsClicked;
            AddRustlersRib.Click += OnAddRustlersRibsClicked;
            AddPecosPulledPork.Click += OnAddRustlersRibsClicked;
            AddTrailBurgerButton.Click += OnAddRustlersRibsClicked;
            AddDakotaDoubleBurgerButton.Click += OnAddRustlersRibsClicked;
            AddTexasTripleBurgerButton.Click += OnAddRustlersRibsClicked;
            AddAngryChickenButton.Click += OnAddRustlersRibsClicked;
            //Sides
            AddChiliCheeseFriesButton.Click += OnAddChiliCheeseFriesButtonClicked;
            AddCornDodgersButton.Click += OnAddCornDodgersButtonClicked;
            AddPanDeCampoButton.Click += OnAddPanDeCampoButtonClicked;
            AddBakedBeansButton.Click += OnAddBakedBeansButtonClicked;
            //Drinks
            AddJerkedSodaButton.Click += OnAddJerkedSodaButtonClicked;
            AddTexasTeaButton.Click += OnAddTexasTeaButtonClicked;
            AddCowboyCoffeeButton.Click += OnAddCowboyCoffeeButtonClicked;
            AddWaterButton.Click += OnAddWaterButtonClicked;
            //AddButton.Click += OnAddButtonClicked;
        }

        /*
        void OnAddCowpokeChiliButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new CowpokeChili());

            }

        }
        void OnAddRustlersRibsClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new RustlersRibs());

            }

        }
        void OnAddAddPecosPulledPorkClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new PecosPulledPork());

            }

        }
        void OnAddTrailBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new TrailBurger());

            }

        }
        void OnAddDakotaDoubleBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new DakotaDoubleBurger());

            }

        }
        void OnAddTexasTripleBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new TexasTripleBurger());

            }

        }
        void OnAddAngryChickenButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new AngryChicken());

            }

        }
        */
        void OnAddChiliCheeseFriesButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new ChiliCheeseFries());

            }

        }

        void OnAddCornDodgersButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new CornDodgers());

            }

        }

        void OnAddPanDeCampoButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new PanDeCampo());

            }

        }

        void OnAddBakedBeansButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new BakedBeans());

            }

        }

        void OnAddJerkedSodaButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new JerkedSoda());

            }

        }

        void OnAddTexasTeaButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new TexasTea());

            }

        }

        void OnAddCowboyCoffeeButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new CowboyCoffee());

            }

        }

        void OnAddWaterButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new Water());

            }

        }
        
        void OnAddRustlersRibsClicked(object sender, RoutedEventArgs e)
        {
             orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                if(sender is Button button)
                {
                    switch (button.Tag)
                    {
                        case "RustlersRibs":
                            order.Add(new RustlersRibs());
                            orderControl.SwapScreen(new CustomizeRustlersRibs());
                            break;
                        case "CowpokeChili":
                            order.Add(new CowpokeChili());
                            orderControl.SwapScreen(new CustomizeCowpokeChili());
                            break;
                        case "PecosPulledPork":
                            order.Add(new PecosPulledPork());
                            orderControl.SwapScreen(new CustomizePecosPulledPork());
                            break;
                        case "TrailBurger":
                            order.Add(new TrailBurger());
                            orderControl.SwapScreen(new CustomizeTrailBurger());
                            break;
                        case "DakotaDoubleBurger":
                            order.Add(new DakotaDoubleBurger());
                            orderControl.SwapScreen(new CustomizeDakotaDoubleBurger());
                            break;
                        case "TexasTripleBurger":
                            order.Add(new TexasTripleBurger());
                            orderControl.SwapScreen(new CustomizeTexasTripleBurger());
                            break;
                        case "AngryChicken":
                            order.Add(new AngryChicken());
                            orderControl.SwapScreen(new CustomizeAngryChicken());
                            break;
                    }
                }
            }
        }

        





    }
}
