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
        public List<List<Button>> allScoresButtonsList;
        public List<Button> score1ButtonsList;
        public List<Button> score2ButtonsList;
        public List<Button> score3ButtonsList;
        public List<Button> score4ButtonsList;
        public List<Button> score5ButtonsList;
        public List<Button> score6ButtonsList;
        public List<Button> goalColorsList;
        private Game ourGame;
        private Match ourMatch;
        private ExceptionHandling ourException;
        
        public MainWindow()
        {
            InitializeComponent();

            ourGame = new Game(0);
            ourMatch = new Match(0);
            ourException = new ExceptionHandling();
            
            listInitialization();
            prepareLists();
            buttonsInitialConditions();

            colorGoal(ourMatch.randomGoal(ourMatch.colorNumber));

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
            score1ButtonsList = new List<Button>();
            score2ButtonsList = new List<Button>();
            score3ButtonsList = new List<Button>();
            score4ButtonsList = new List<Button>();
            score5ButtonsList = new List<Button>();
            score6ButtonsList = new List<Button>();
            allScoresButtonsList = new List<List<Button>>();
            goalColorsList = new List<Button>();
        }

        private void buttonsInitialConditions()
        {
            disableButtons(allButtonsList, ourMatch);
            disableButtons(goalColorsList, ourMatch);
            enableButtons(allButtonsList, ourMatch);
            enableHitTestButtons(allButtonsList, ourMatch);
            defaultColors();
        }

        private void defaultColors()
        {
            try
            {
                for (int actualPart = 0; actualPart < ourMatch.matchNumber; actualPart++)
                {
                    for (int actualField = 0; actualField < ourMatch.fieldNumber; actualField++)
                    {
                        allButtonsList[actualPart][actualField].Background = Brushes.LightGray;
                        allScoresButtonsList[actualPart][actualField].Background = Brushes.Gray;
                    }
                }
            }
            catch(ArgumentOutOfRangeException catchedException)
            {
                MessageBox.Show("Error - Exception occure - method: defaultColors()");
                ExceptionHandling ourException = new ExceptionHandling();
                ourException.WhichException(catchedException);
            }
            catch(Exception catchedException)
            {
                MessageBox.Show("Error - Exception occure - method: defaultColors()");
                ExceptionHandling ourException = new ExceptionHandling();
                ourException.WhichException(catchedException);
            }
        }

        private void prepareLists()
        {
            prepareGoalColorsList();
            prepareAllScoresList();
            prepareScoreButtonsList();
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
            allScoresButtonsList.Add(score1ButtonsList);
            allScoresButtonsList.Add(score2ButtonsList);
            allScoresButtonsList.Add(score3ButtonsList);
            allScoresButtonsList.Add(score4ButtonsList);
            allScoresButtonsList.Add(score5ButtonsList);
            allScoresButtonsList.Add(score6ButtonsList);
        }

        private void prepareScoreButtonsList()
        {
            score1ButtonsList.Add(this.ScoreParty1Field1);
            score1ButtonsList.Add(this.ScoreParty1Field2);
            score1ButtonsList.Add(this.ScoreParty1Field3);
            score1ButtonsList.Add(this.ScoreParty1Field4);
            
            score2ButtonsList.Add(this.ScoreParty2Field1);
            score2ButtonsList.Add(this.ScoreParty2Field2);
            score2ButtonsList.Add(this.ScoreParty2Field3);
            score2ButtonsList.Add(this.ScoreParty2Field4);
            
            score3ButtonsList.Add(this.ScoreParty3Field1);
            score3ButtonsList.Add(this.ScoreParty3Field2);
            score3ButtonsList.Add(this.ScoreParty3Field3);
            score3ButtonsList.Add(this.ScoreParty3Field4);
            
            score4ButtonsList.Add(this.ScoreParty4Field1);
            score4ButtonsList.Add(this.ScoreParty4Field2);
            score4ButtonsList.Add(this.ScoreParty4Field3);
            score4ButtonsList.Add(this.ScoreParty4Field4);

            score5ButtonsList.Add(this.ScoreParty5Field1);
            score5ButtonsList.Add(this.ScoreParty5Field2);
            score5ButtonsList.Add(this.ScoreParty5Field3);
            score5ButtonsList.Add(this.ScoreParty5Field4);

            score6ButtonsList.Add(this.ScoreParty6Field1);
            score6ButtonsList.Add(this.ScoreParty6Field2);
            score6ButtonsList.Add(this.ScoreParty6Field3);
            score6ButtonsList.Add(this.ScoreParty6Field4);
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

        private void enableButtons(List <List<Button>> usedButton, Match actualMatch)
        {
            int fieldsCounter;
            try
            {
                for (fieldsCounter = 0; fieldsCounter < ourGame.fieldNumber; fieldsCounter++)
                {
                    usedButton[actualMatch.PlayCounter][fieldsCounter].IsEnabled = true;
                }
            }
            catch (ArgumentOutOfRangeException catchedException)
            {
                MessageBox.Show("Error - Exception occure - method: enableButtons()");
                ExceptionHandling ourException = new ExceptionHandling();
                ourException.WhichException(catchedException);
            }
            catch (Exception catchedException)
            {
                MessageBox.Show("Error - Exception occure  - method: enableButtons()");
                ExceptionHandling ourException = new ExceptionHandling();
                ourException.WhichException(catchedException);
            }
            buttonSet.IsEnabled = true;
        }
        private void enableButtons(List<Button> usedButton, Match actualMatch)
        {
            int fieldsCounter;
            try
            {
                for (fieldsCounter = 0; fieldsCounter < ourGame.fieldNumber; fieldsCounter++)
                {
                    usedButton[fieldsCounter].IsEnabled = true;
                }
            }
            catch (ArgumentOutOfRangeException catchedException)
            {
                MessageBox.Show("Error - Exception occure - method: enableButtons()");
                ExceptionHandling ourException = new ExceptionHandling();
                ourException.WhichException(catchedException);
            }
            catch (Exception catchedException)
            {
                MessageBox.Show("Error - Exception occure  - method: enableButtons()");
                ExceptionHandling ourException = new ExceptionHandling();
                ourException.WhichException(catchedException);
            }
            buttonSet.IsEnabled = true;
        }

        private void enableHitTestButtons(List<List<Button>> usedButton, Match actualMatch)
        {
            int fieldsCounter;
            try
            {
                for (fieldsCounter = 0; fieldsCounter < ourGame.fieldNumber; fieldsCounter++)
                {
                    usedButton[actualMatch.PlayCounter][fieldsCounter].IsHitTestVisible = true;
                }
            }
            catch (ArgumentOutOfRangeException catchedException)
            {
                MessageBox.Show("Error - Exception occure - method: enableHitTestButtons()");
                ExceptionHandling ourException = new ExceptionHandling();
                ourException.WhichException(catchedException);
            }
            catch (Exception catchedException)
            {
                MessageBox.Show("Error - Exception occure  - method: enableHitTestButtons()");
                ExceptionHandling ourException = new ExceptionHandling();
                ourException.WhichException(catchedException);
            }
        }

        private void disableButtons(List<List<Button>> usedButton, Match actualMatch)
        {
            int fieldsCounter, matchCounter;
            try
            {
                for (matchCounter = 0; matchCounter < ourGame.matchNumber; matchCounter++)
                {
                    for (fieldsCounter = 0; fieldsCounter < ourGame.fieldNumber; fieldsCounter++)
                    {
                        usedButton[matchCounter][fieldsCounter].IsEnabled = false;
                    }
                }
            }
            catch (ArgumentOutOfRangeException catchedException)
            {
                MessageBox.Show("Error - Exception occure - method: disableButtons()");
                ExceptionHandling ourException = new ExceptionHandling();
                ourException.WhichException(catchedException);
            }
            catch (Exception catchedException)
            {
                MessageBox.Show("Error - Exception occure  - method: disableButtons()");
                ExceptionHandling ourException = new ExceptionHandling();
                ourException.WhichException(catchedException);
            }
        }
        private void disableButtons(List<Button> usedButton, Match actualMatch)
        {
            int fieldsCounter;
            try
            {
                for (fieldsCounter = 0; fieldsCounter < ourGame.fieldNumber; fieldsCounter++)
                {
                    usedButton[fieldsCounter].IsEnabled = false;
                }
            }
            catch (ArgumentOutOfRangeException catchedException)
            {
                MessageBox.Show("Error - Exception occure - method: disableButtons()");
                ExceptionHandling ourException = new ExceptionHandling();
                ourException.WhichException(catchedException);
            }
            catch (Exception catchedException)
            {
                MessageBox.Show("Error - Exception occure  - method: disableButtons()");
                ExceptionHandling ourException = new ExceptionHandling();
                ourException.WhichException(catchedException);
            }
        }

        private void disableHitTestButtons(List<List<Button>> usedButton, Match actualMatch)
        {
            int fieldsCounter, matchCounter;
            try
            {
                for (matchCounter = 0; matchCounter < ourGame.matchNumber; matchCounter++)
                    for (fieldsCounter = 0; fieldsCounter < ourGame.fieldNumber; fieldsCounter++)
                    {
                        usedButton[matchCounter][fieldsCounter].IsHitTestVisible = false;
                    }
            }
            catch (ArgumentOutOfRangeException catchedException)
            {
                MessageBox.Show("Error - Exception occure - method: disableHitTestButtons()");
                ExceptionHandling ourException = new ExceptionHandling();
                ourException.WhichException(catchedException);
            }
            catch (Exception catchedException)
            {
                MessageBox.Show("Error - Exception occure  - method: disableHitTestButtons()");
                ExceptionHandling ourException = new ExceptionHandling();
                ourException.WhichException(catchedException);
            }
        }

        private void buttonClickHandle(int thisMatch, int thisField)
        {
            int fieldCounter;
            bool changeMade;
            this.allButtonsList[thisMatch][thisField].Background = colorChange(this.allButtonsList[thisMatch][thisField].Background);
            try
            {
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
                    if (changeMade == true)
                    {
                        fieldCounter = -1;
                    }
                }
            }
            catch (ArgumentOutOfRangeException catchedException)
            {
                MessageBox.Show("Error - Exception occure - method: buttonClickHandle()");
                ExceptionHandling ourException = new ExceptionHandling();
                ourException.WhichException(catchedException);
            }
            catch (Exception catchedException)
            {
                MessageBox.Show("Error - Exception occure  - method: buttonClickHandle()");
                ExceptionHandling ourException = new ExceptionHandling();
                ourException.WhichException(catchedException);
            }
        }

        public void colorGoal(int[] choosenColors)
        {
            SolidColorBrush newColor;
            try
            {
                for (int actualField = 0; actualField < ourMatch.fieldNumber; actualField++)
                {
                    switch (choosenColors[actualField])
                    {
                        case 0:
                            newColor = Brushes.Red;
                            break;
                        case 1:
                            newColor = Brushes.Orange;
                            break;
                        case 2:
                            newColor = Brushes.Yellow;
                            break;
                        case 3:
                            newColor = Brushes.Violet;
                            break;
                        case 4:
                            newColor = Brushes.Blue;
                            break;
                        case 5:
                            newColor = Brushes.Green;
                            break;
                        default:
                            newColor = Brushes.Red;
                            break;
                    }
                    goalColorsList[actualField].Background = newColor;
                }
            }
            catch (ArgumentOutOfRangeException catchedException)
            {
                MessageBox.Show("Error - Exception occure - method: colorGoal()");
                ExceptionHandling ourException = new ExceptionHandling();
                ourException.WhichException(catchedException);
            }
            catch (Exception catchedException)
            {
                MessageBox.Show("Error - Exception occure  - method: colorGoal()");
                ExceptionHandling ourException = new ExceptionHandling();
                ourException.WhichException(catchedException);
            }
        }

        public SolidColorBrush colorChange(Brush actualBackground)
        {
            string actualBackgroundString;
            SolidColorBrush newColor;
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
                    newColor = Brushes.Red;
                    break;
            }
            return newColor;
        }
        private void buttonSet_click(object sender, RoutedEventArgs e)
        {
            ourMatch.calculateScore(allButtonsList, goalColorsList, allScoresButtonsList);
            ourMatch.decideScore(allScoresButtonsList);
            ourMatch.decideFinalScore(finalScoreTextBlock, ourMatch.PlayCounter);
            disableHitTestButtons(allButtonsList, ourMatch);
            if (this.ourMatch.PlayCounter < ourGame.matchNumber - 1)
            {
                this.ourMatch.PlayCounter++;
                enableButtons(allButtonsList, ourMatch);
                enableHitTestButtons(allButtonsList, ourMatch);
            }
            else
            {
                enableButtons(goalColorsList, ourMatch);
                buttonSet.IsEnabled = false;
            }
            gameEnd();
        }

        private void gameEnd()
        {
            if(ourMatch.FinalScore == scoreMarker.Victory)
            {
                disableHitTestButtons(allButtonsList, ourMatch);
                enableButtons(goalColorsList, ourMatch);
                buttonSet.IsEnabled = false;
            }
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
            buttonClickHandle(4, 1);
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

        private void buttonNewGame_click(object sender, RoutedEventArgs e)
        {
            this.ourGame.PlayCounter++;
            this.ourMatch.PlayCounter = 0;
            buttonsInitialConditions();
            colorGoal(ourMatch.randomGoal(ourMatch.colorNumber));
            finalScoreTextBlock.Text = "";
        }
    }
}
