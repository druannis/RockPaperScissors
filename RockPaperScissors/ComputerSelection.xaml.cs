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

namespace RockPaperScissors
{
    /// <summary>
    /// Interaction logic for ComputerSelection.xaml
    /// </summary>
    public partial class ComputerSelection : Page
    {


        
         
        public ComputerSelection()
        {
            InitializeComponent();
        }

        private void TakeToFinals(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new FinalResults());

        }
    }
}
