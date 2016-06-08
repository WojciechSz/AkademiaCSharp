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
        public Match(int playValue):base(playValue)
        {
            this.PlayCounter = playValue;
            MatchScore = new List<scoreMarker>();
        }
        public List<scoreMarker> MatchScore
        {
            get;
            set;
        }  
        public void calculateScore(List<List<Button>> actualField, List<List<Label>> allScoresLabelsList, List<Button> goalBackground)
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

            int fieldsCounter, internalFieldsCounter;
            for (fieldsCounter = 0; fieldsCounter < fieldNumber; fieldsCounter++)
            {
                result[fieldsCounter] = colorCompare(actualField[this.PlayCounter][fieldsCounter].Background, goalBackground[fieldsCounter].Background);
                if (result[fieldsCounter] == compareResult.equal)
                {
                    allScoresLabelsList[this.PlayCounter][fieldsCounter].Background = Brushes.Black;
                    this.MatchScore.Add(scoreMarker.Victory);
                }
                if (result[fieldsCounter] == compareResult.notEqual) 
                {
                    for (internalFieldsCounter = 0; internalFieldsCounter < fieldNumber; internalFieldsCounter++)
                    {
                        resultWhite[internalFieldsCounter] = colorCompare(actualField[this.PlayCounter][fieldsCounter].Background, goalBackground[internalFieldsCounter].Background);
                        if (resultWhite[internalFieldsCounter] == compareResult.equal)
                        {
                            allScoresLabelsList[this.PlayCounter][fieldsCounter].Background = Brushes.White;
                            this.MatchScore.Add(scoreMarker.Victory);
                            break;
                        }
                        else 
                        {
                            allScoresLabelsList[this.PlayCounter][fieldsCounter].Background = Brushes.DimGray;
                            this.MatchScore.Add(scoreMarker.Defeat);
                        }
                    }
                }
            }
            Score.Add(MatchScore);
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
        public int[] randomGoal(List<Button> goalColorList)
        {
            int[] fieldColorNumber = new int[] { this.colorNumber, this.colorNumber, this.colorNumber, this.colorNumber };
            compareResult sameColor = compareResult.notEqual;
            for(int actualField = 0; actualField < fieldNumber; actualField++)
            {
                do
                {
                    sameColor = compareResult.notEqual;
                    fieldColorNumber[actualField] = randomNumber(0, this.colorNumber);
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
