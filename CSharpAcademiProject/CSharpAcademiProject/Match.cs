using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Controls;

namespace CSharpAcademiProject
{
    class Match : Game
    {
        public scoreMarker[] MatchScore
        {
            get;
            set;
        }
        public Match(int playValue):base(playValue)
        {
            this.PlayCounter = playValue;
            MatchScore = new scoreMarker[this.fieldNumber];
        }
        public void calculateScore(List<List<Button>> actualField, List<Button> goalBackground, List<List<Button>> allScoresLabelsList)
        {
            List<compareResult> result;
            result = new List<compareResult>();
            result.Add(compareResult.equal);
            result.Add(compareResult.equal);
            result.Add(compareResult.equal);
            result.Add(compareResult.equal);
            List<compareResult> resultWhite;
            resultWhite = new List<compareResult>();
            resultWhite.Add(compareResult.equal);
            resultWhite.Add(compareResult.equal);
            resultWhite.Add(compareResult.equal);
            resultWhite.Add(compareResult.equal);
            int[] randomScoreField;

            randomScoreField = this.randomGoal(this.fieldNumber);
            for (int fieldsCounter = 0; fieldsCounter < this.fieldNumber; fieldsCounter++)
            {
                result[fieldsCounter] = colorCompare(actualField[this.PlayCounter][fieldsCounter].Background, goalBackground[fieldsCounter].Background);
                if (result[fieldsCounter] == compareResult.equal)
                {
                    allScoresLabelsList[this.PlayCounter][randomScoreField[fieldsCounter]].Background = Brushes.Black;
                }
                if (result[fieldsCounter] == compareResult.notEqual)
                {
                    for (int internalFieldsCounter = 0; internalFieldsCounter < fieldNumber; internalFieldsCounter++)
                    {
                        resultWhite[internalFieldsCounter] = colorCompare(actualField[this.PlayCounter][fieldsCounter].Background, goalBackground[internalFieldsCounter].Background);
                        if (resultWhite[internalFieldsCounter] == compareResult.equal)
                        {
                            allScoresLabelsList[this.PlayCounter][randomScoreField[fieldsCounter]].Background = Brushes.White;
                            break;
                        }
                    }
                }
            }
        }
        public void decideScore(List<List<Button>> allScoresLabelsList)
        {
            for (int fieldsCounter = 0; fieldsCounter < this.fieldNumber; fieldsCounter++)
            {
                if (allScoresLabelsList[this.PlayCounter][fieldsCounter].Background == Brushes.Black)
                {
                    this.MatchScore[fieldsCounter] = scoreMarker.Victory;
                }
                if (allScoresLabelsList[this.PlayCounter][fieldsCounter].Background == Brushes.White)
                {
                    this.MatchScore[fieldsCounter] = scoreMarker.Undecided;
                }
                if (allScoresLabelsList[this.PlayCounter][fieldsCounter].Background == Brushes.Gray)
                {
                    this.MatchScore[fieldsCounter] = scoreMarker.Defeat;
                }
            }
            this.Score[this.PlayCounter] = new scoreMarker[this.fieldNumber];
            this.Score[this.PlayCounter] = this.MatchScore;
        }   
        public compareResult colorCompare(Brush actualBackground, Brush goalBackground)
        {
            if (actualBackground == goalBackground)
            {
                return compareResult.equal;
            }
            else
            {
                return compareResult.notEqual;
            }
        }
        public int[] randomGoal(int maxNumber)
        {
            int[] fieldColorNumber = new int[] { maxNumber, maxNumber, maxNumber, maxNumber };
            compareResult sameColor = compareResult.notEqual;
            for(int actualField = 0; actualField < fieldNumber; actualField++)
            {
                do
                {
                    sameColor = compareResult.notEqual;
                    fieldColorNumber[actualField] = randomNumber(0, maxNumber);
                    for (int anotherField = 0; anotherField < fieldNumber; anotherField++)
                    {
                        if (actualField != anotherField)
                        {
                            if(fieldColorNumber[actualField] == fieldColorNumber[anotherField])
                            {
                                sameColor = compareResult.equal;
                            }
                        }
                    }
                } while (sameColor == compareResult.equal);
            }
            return fieldColorNumber;
        }
        public int randomNumber(int lowerRange, int upperRange)
        {
            Random number = new Random();
            return number.Next(lowerRange, upperRange);
        }
    } 
}
