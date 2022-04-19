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
    /// Interaction logic for FinalResults.xaml
    /// </summary>
    public partial class FinalResults : Page
    {
        Random rnd = new Random();

        public int NumGen;

        public string ComputersChoiceString;
        public string ComputersChoice()
        {
            NumGen = rnd.Next(1,4);
            if(NumGen == 1)
            {
                ComputersChoiceString = "Rock";
            }
            else if (NumGen == 2)
            {
                ComputersChoiceString = "Paper";
            }
            else if (NumGen == 3)
            {
                ComputersChoiceString = "Scissors";
            }
            return ComputersChoiceString;
        }
        public string ResultsVar;
        public string ResultsVarGen()
        {
            if (ComputersChoiceString == "Rock" && Selection.PlayerSelection == "Paper")
            {
                ResultsVar = "Computer Chose Rock, You Chose Paper. Paper Beats Rock. You Win";
            }
            else if (ComputersChoiceString == "Paper" && Selection.PlayerSelection == "Paper")
            {
                ResultsVar = "Computer Chose Paper, You Chose Paper. Tie Game";
            }
            else if (ComputersChoiceString == "Scissors" && Selection.PlayerSelection == "Paper")
            {
                ResultsVar = "Computer Chose Scissors, You Chose Paper. Scissors Beats Paper. Computer Wins";
            }
            else if (ComputersChoiceString == "Rock" && Selection.PlayerSelection == "Rock")
            {
                ResultsVar = "Computer Chose Rock, You Chose Rock. Tie Game";
            }
            else if (ComputersChoiceString == "Paper" && Selection.PlayerSelection == "Rock")
            {
                ResultsVar = "Computer Chose Paper, You Chose Rock. Paper Beats Rock, Computer Wins";
            }
            else if (ComputersChoiceString == "Scissors" && Selection.PlayerSelection == "Rock")
            {
                ResultsVar = "Computer Chose Scissors, You Chose Rock. Rock Beats Scissors, You Win!";
            }
            else if (ComputersChoiceString == "Paper" && Selection.PlayerSelection == "Scissors")
            {
                ResultsVar = "Computer Chose Paper, You Chose Scissors. Scissors Beats Paper, You Win!";
            }
            else if (ComputersChoiceString == "Rock" && Selection.PlayerSelection == "Scissors")
            {
                ResultsVar = "Computer Chose Rock, You Chose Scissors. Rock Beats Scissors, Computer Wins";
            }
            else if (ComputersChoiceString == "Scissors" && Selection.PlayerSelection == "Scissors")
            {
                ResultsVar = "Computer Chose Scissors, You Chose Scissors. Tie Game";
            }
            return ResultsVar;

        }
        public FinalResults()
        {
            InitializeComponent();
            ComputersChoice();
            ResultsVarGen();
            Results.Text = ResultsVar;
        }


        private void Restart(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new LaunchPage());
        }
    }
}
