﻿using System;
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

namespace UserInterface
{
    /// <summary>
    /// Interaction logic for PlanTripScreen.xaml
    /// </summary>
    public partial class PlanTripScreen : Page
    {
        private int tripID;
        private string country;
        private string region;
        private string cityName;

        public PlanTripScreen()
        {
            InitializeComponent();
        }

        public PlanTripScreen(int tripID, string country, string region, string cityName)
        {
            InitializeComponent();
            this.tripID = tripID;
            this.country = country;
            this.region = region;
            this.cityName = cityName;
        }

        /// <summary>
        /// Return to main menu when user clicks "Done" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void Done_Click(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new MainMenu());
        }

        public void NewHotelReservation_Click(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new HotelReservationScreen(tripID, country, region, cityName));
        }

        public void NewBoardingPass_Click(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new BoardingPassScreen());
        }

        public void NewAttractionTicket_Click(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new NewAttractionTicketScreen());
        }

        public void NewRestaurantReservation_Click(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new NewRestaurantReservationScreen());
        }

        public void NewCarRentalReservation_Click(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new NewCarRentalReservationScreen());
        }
    }
}
