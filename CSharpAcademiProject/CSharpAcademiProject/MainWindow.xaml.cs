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

namespace CSharpAcademiProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public enum compareResult { equal, notEqual }
    public partial class MainWindow : Window
    {
        public List<List<Button>> allButtonsList;
        public List<Button> part1ButtonsList;
        public List<Button> part2ButtonsList;
        public List<Button> part3ButtonsList;
        public List<Button> part4ButtonsList;
        public List<Button> part5ButtonsList;
        public List<Button> part6ButtonsList;
        public List<List<Label>> allScoresLabelsList;
        public List<Label> score1LablesList;
        public List<Label> score2LablesList;
        public List<Label> score3LablesList;
        public List<Label> score4LablesList;
        public List<Label> score5LablesList;
        public List<Label> score6LablesList;
        public List<Button> goalColorsList;
        private Game ourGame;
        private Match ourMatch;
        
        public MainWindow()
        {
            InitializeComponent();

            ourGame = new Game();
            ourMatch = new Match(0);
            
            listInitialization();
            prepareLists();
            buttonsInitialConditions();

            ourMatch.randomGoal(goalColorsList);
        }
        private void listInitialization()
        {
            part1ButtonsList = new List<Button>();
            part2ButtonsList = new List<Button>();
            part3ButtonsList = new List<Button>();
            part4ButtonsList = new List<Button>();
            part5ButtonsList = new List<Button>();
            part6ButtonsList = new List<Button>();
            allButtonsList = new List<List<Button>>();
            score1LablesList = new List<Label>();
            score2LablesList = new List<Label>();
            score3LablesList = new List<Label>();
            score4LablesList = new List<Label>();
            score5LablesList = new List<Label>();
            score6LablesList = new List<Label>();
            allScoresLabelsList = new List<List<Label>>();
            goalColorsList = new List<Button>();
        }
        private void buttonsInitialConditions()
        {
            disableButtons(allButtonsList, ourMatch);
            enableButtons(allButtonsList, ourMatch);
            enableHitTestButtons(allButtonsList, ourMatch);
        }
        private void prepareLists()
        {
            prepareGoalColorsList();
            prepareAllScoresList();
            prepareScoreLablesList();
            prepareButtonsLists();
            prepareAllButtonsList();
        }
        private void prepareGoalColorsList()
        {
            goalColorsList.Add(this.SetField1);
            goalColorsList.Add(this.SetField2);
            goalColorsList.Add(this.SetField3);
            goalColorsList.Add(this.SetField4);

        }
        private void prepareAllScoresList()
        {
            allScoresLabelsList.Add(score1LablesList);
            allScoresLabelsList.Add(score2LablesList);
            allScoresLabelsList.Add(score3LablesList);
            allScoresLabelsList.Add(score4LablesList);
            allScoresLabelsList.Add(score5LablesList);
            allScoresLabelsList.Add(score6LablesList);
        }
        private void prepareScoreLablesList()
        {
            score1LablesList.Add(this.ScoreParty1Field1);
            score1LablesList.Add(this.ScoreParty1Field2);
            score1LablesList.Add(this.ScoreParty1Field3);
            score1LablesList.Add(this.ScoreParty1Field4);
            
            score2LablesList.Add(this.ScoreParty2Field1);
            score2LablesList.Add(this.ScoreParty2Field2);
            score2LablesList.Add(this.ScoreParty2Field3);
            score2LablesList.Add(this.ScoreParty2Field4);
            
            score3LablesList.Add(this.ScoreParty3Field1);
            score3LablesList.Add(this.ScoreParty3Field2);
            score3LablesList.Add(this.ScoreParty3Field3);
            score3LablesList.Add(this.ScoreParty3Field4);
            
            score4LablesList.Add(this.ScoreParty4Field1);
            score4LablesList.Add(this.ScoreParty4Field2);
            score4LablesList.Add(this.ScoreParty4Field3);
            score4LablesList.Add(this.ScoreParty4Field4);

            score5LablesList.Add(this.ScoreParty5Field1);
            score5LablesList.Add(this.ScoreParty5Field2);
            score5LablesList.Add(this.ScoreParty5Field3);
            score5LablesList.Add(this.ScoreParty5Field4);

            score6LablesList.Add(this.ScoreParty6Field1);
            score6LablesList.Add(this.ScoreParty6Field2);
            score6LablesList.Add(this.ScoreParty6Field3);
            score6LablesList.Add(this.ScoreParty6Field4);
        }
        private void prepareButtonsLists ()
        {
            part1ButtonsList.Add(this.buttonPart1Field1);
            part1ButtonsList.Add(this.buttonPart1Field2);
            part1ButtonsList.Add(this.buttonPart1Field3);
            part1ButtonsList.Add(this.buttonPart1Field4);

            part2ButtonsList.Add(this.buttonPart2Field1);
            part2ButtonsList.Add(this.buttonPart2Field2);
            part2ButtonsList.Add(this.buttonPart2Field3);
            part2ButtonsList.Add(this.buttonPart2Field4);

            part3ButtonsList.Add(this.buttonPart3Field1);
            part3ButtonsList.Add(this.buttonPart3Field2);
            part3ButtonsList.Add(this.buttonPart3Field3);
            part3ButtonsList.Add(this.buttonPart3Field4);

            part4ButtonsList.Add(this.buttonPart4Field1);
            part4ButtonsList.Add(this.buttonPart4Field2);
            part4ButtonsList.Add(this.buttonPart4Field3);
            part4ButtonsList.Add(this.buttonPart4Field4);

            part5ButtonsList.Add(this.buttonPart5Field1);
            part5ButtonsList.Add(this.buttonPart5Field2);
            part5ButtonsList.Add(this.buttonPart5Field3);
            part5ButtonsList.Add(this.buttonPart5Field4);

            part6ButtonsList.Add(this.buttonPart6Field1);
            part6ButtonsList.Add(this.buttonPart6Field2);
            part6ButtonsList.Add(this.buttonPart6Field3);
            part6ButtonsList.Add(this.buttonPart6Field4);
        }
        private void prepareAllButtonsList ()
        {
            allButtonsList.Add(this.part1ButtonsList);
            allButtonsList.Add(this.part2ButtonsList);
            allButtonsList.Add(this.part3ButtonsList);
            allButtonsList.Add(this.part4ButtonsList);
            allButtonsList.Add(this.part5ButtonsList);
            allButtonsList.Add(this.part6ButtonsList);
        }
        private void enableButtons (List <List<Button>> usedButton, Match actualMatch)
        {
            int fieldsCounter;
            for (fieldsCounter = 0; fieldsCounter < ourGame.fieldNumber; fieldsCounter++)
            {
                usedButton[actualMatch.MatchCounter][fieldsCounter].IsEnabled = true;
            }
        }
        private void enableHitTestButtons(List<List<Button>> usedButton, Match actualMatch)
        {
            int fieldsCounter;
            for (fieldsCounter = 0; fieldsCounter < ourGame.fieldNumber; fieldsCounter++)
            {
                usedButton[actualMatch.MatchCounter][fieldsCounter].IsHitTestVisible = true;
            }
        }
        private void disableButtons(List<List<Button>> usedButton, Match actualMatch)
        {
            int fieldsCounter, matchCounter;
            for (matchCounter = 0; matchCounter < ourGame.matchNumber; matchCounter++)
                for (fieldsCounter = 0; fieldsCounter < ourGame.fieldNumber; fieldsCounter++)
                {
                    usedButton[matchCounter][fieldsCounter].IsEnabled = false;
                }
        }
        private void disableHitTestButtons(List<List<Button>> usedButton, Match actualMatch)
        {
            int fieldsCounter, matchCounter;
            for (matchCounter = 0; matchCounter < ourGame.matchNumber; matchCounter++)
                for (fieldsCounter = 0; fieldsCounter < ourGame.fieldNumber; fieldsCounter++)
                {
                    usedButton[matchCounter][fieldsCounter].IsHitTestVisible = false;
                }
        }
        private void buttonClickHandle(int thisMatch, int thisField)
        {
            int fieldCounter;
            bool changeMade;
            this.allButtonsList[thisMatch][thisField].Background = colorChange(this.allButtonsList[thisMatch][thisField].Background);
            for (fieldCounter = 0; fieldCounter < ourGame.fieldNumber; fieldCounter++)
            {
                changeMade = false;
                if (thisField != fieldCounter)
                {
                    if (this.allButtonsList[thisMatch][thisField].Background == this.allButtonsList[thisMatch][fieldCounter].Background)
                    {
                        this.allButtonsList[thisMatch][thisField].Background = colorChange(this.allButtonsList[thisMatch][thisField].Background);
                        changeMade = true;
                    }
                }
                if(changeMade == true)
                {
                    fieldCounter = -1;
                }
            }
        }
        public SolidColorBrush colorChange(Brush actualBackground)
        {
            string actualBackgroundString;
            SolidColorBrush newColor = Brushes.Red;
            actualBackgroundString = actualBackground.ToString();
            switch (actualBackgroundString)
            {
                case "#FF008000":
                    newColor = Brushes.Red;
                    break;
                case "#FFFF0000":
                    newColor = Brushes.Orange;
                    break;
                case "#FFFFA500":
                    newColor = Brushes.Yellow;
                    break;
                case "#FFFFFF00":
                    newColor = Brushes.Violet;
                    break;
                case "#FFEE82EE":
                    newColor = Brushes.Blue;
                    break;
                case "#FF0000FF":
                    newColor = Brushes.Green;
                    break;
                default:
                    break;
            }
            return newColor;
        }
        private void buttonSet_click(object sender, RoutedEventArgs e)
        {
            ourMatch.calculateScore(allButtonsList, allScoresLabelsList, goalColorsList);
            disableHitTestButtons(allButtonsList, ourMatch);
            if (this.ourMatch.MatchCounter < ourGame.matchNumber - 1)
            {
                this.ourMatch.MatchCounter++;
                enableButtons(allButtonsList, ourMatch);
                enableHitTestButtons(allButtonsList, ourMatch);
            }
            //ODBLOKOWANIE NASTEPNYCH BUTTONOW
        }

        private void buttonPart6Field1_Click(object sender, RoutedEventArgs e)
        {
            buttonClickHandle(5, 0);
        }

        private void buttonPart5Field1_Click(object sender, RoutedEventArgs e)
        {
            buttonClickHandle(4, 0);
        }

        private void buttonPart4Field1_Click(object sender, RoutedEventArgs e)
        {
            buttonClickHandle(3, 0);
        }

        private void buttonPart3Field1_Click(object sender, RoutedEventArgs e)
        {
            buttonClickHandle(2, 0);
        }

        private void buttonPart2Field1_Click(object sender, RoutedEventArgs e)
        {
            buttonClickHandle(1, 0);
        }

        private void buttonPart1Field1_Click(object sender, RoutedEventArgs e)
        {
            buttonClickHandle(0, 0);
        }

        private void buttonPart6Field2_Click(object sender, RoutedEventArgs e)
        {
            buttonClickHandle(5, 1);
        }

        private void buttonPart5Field2_Click(object sender, RoutedEventArgs e)
        {
            buttonClickHandle(5, 1);
        }

        private void buttonPart4Field2_Click(object sender, RoutedEventArgs e)
        {
            buttonClickHandle(3, 1);
        }

        private void buttonPart3Field2_Click(object sender, RoutedEventArgs e)
        {
            buttonClickHandle(2, 1);
        }

        private void buttonPart2Field2_Click(object sender, RoutedEventArgs e)
        {
            buttonClickHandle(1, 1);
        }

        private void buttonPart1Field2_Click(object sender, RoutedEventArgs e)
        {
            buttonClickHandle(0, 1);
        }

        private void buttonPart6Field3_Click(object sender, RoutedEventArgs e)
        {
            buttonClickHandle(5, 2);
        }

        private void buttonPart5Field3_Click(object sender, RoutedEventArgs e)
        {
            buttonClickHandle(4, 2);
        }

        private void buttonPart4Field3_Click(object sender, RoutedEventArgs e)
        {
            buttonClickHandle(3, 2);
        }

        private void buttonPart3Field3_Click(object sender, RoutedEventArgs e)
        {
            buttonClickHandle(2, 2);
        }

        private void buttonPart2Field3_Click(object sender, RoutedEventArgs e)
        {
            buttonClickHandle(1, 2);
        }

        private void buttonPart1Field3_Click(object sender, RoutedEventArgs e)
        {
            buttonClickHandle(0, 2);
        }

        private void buttonPart6Field4_Click(object sender, RoutedEventArgs e)
        {
            buttonClickHandle(5, 3);
        }

        private void buttonPart5Field4_Click(object sender, RoutedEventArgs e)
        {
            buttonClickHandle(4, 3);
        }

        private void buttonPart4Field4_Click(object sender, RoutedEventArgs e)
        {
            buttonClickHandle(3, 3);
        }

        private void buttonPart3Field4_Click(object sender, RoutedEventArgs e)
        {
            buttonClickHandle(2, 3);
        }

        private void buttonPart2Field4_Click(object sender, RoutedEventArgs e)
        {
            buttonClickHandle(1, 3);
        }

        private void buttonPart1Field4_Click(object sender, RoutedEventArgs e)
        {
            buttonClickHandle(0, 3);
        }
    }
}
