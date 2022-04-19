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

namespace RockPaperScissors
{
    /// <summary>
    /// Interaction logic for Selection.xaml
    /// </summary>
    public partial class Selection : Page
    {
        public static string PlayerSelection;

        public Selection()
        {
            InitializeComponent();
        }

        private void RockSelect(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ComputerSelection());
            PlayerSelection = "Rock";
        }

        private void PaperSelect(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ComputerSelection());
            PlayerSelection = "Paper";
        }

        private void ScissorsSelect(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ComputerSelection());
            PlayerSelection = "Scissors";
        }
    }
}
