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
        public int MatchCounter
        {
            get;
            set;
        }
        public Match(int matchValue)
        {
            this.MatchCounter = matchValue;
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
                result[fieldsCounter] = colorCompare(actualField[this.MatchCounter][fieldsCounter].Background, goalBackground[fieldsCounter].Background);
                if (result[fieldsCounter] == compareResult.equal)
                {
                    allScoresLabelsList[this.MatchCounter][fieldsCounter].Background = Brushes.Black;
                }
                if (result[fieldsCounter] == compareResult.notEqual) 
                {
                    for (internalFieldsCounter = 0; internalFieldsCounter < fieldNumber; internalFieldsCounter++)
                    {
                        resultWhite[internalFieldsCounter] = colorCompare(actualField[this.MatchCounter][fieldsCounter].Background, goalBackground[internalFieldsCounter].Background);
                        if (resultWhite[internalFieldsCounter] == compareResult.equal)
                        {
                            allScoresLabelsList[this.MatchCounter][fieldsCounter].Background = Brushes.White;
                            break;
                        }
                    }
                }
            }
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
        public void randomGoal(List<Button> goalColorList)
        {
            //int[] fieldColorNumber = new int[] { 0, 1, 2, 3 };
            // 6 -color number
            int field1ColorNumber, field2ColorNumber, field3ColorNumber, field4ColorNumber;
            field1ColorNumber = randomNumber(0, 6);
            do
            {
                field2ColorNumber = randomNumber(0, 6);
            } while (field2ColorNumber == field1ColorNumber);
            do
            {
                field3ColorNumber = randomNumber(0, 6);
            } while (field3ColorNumber == field2ColorNumber || field3ColorNumber == field1ColorNumber);
            do
            {
                field4ColorNumber = randomNumber(0, 6);
            } while (field4ColorNumber == field3ColorNumber || field4ColorNumber == field2ColorNumber || field4ColorNumber == field1ColorNumber);
            
            goalColorList[0].Content = field1ColorNumber;
            goalColorList[1].Content = field2ColorNumber;
            goalColorList[2].Content = field3ColorNumber;
            goalColorList[3].Content = field4ColorNumber;
        }
        public int randomNumber(int lowerRange, int upperRange)
        {
            Random number = new Random();
            return number.Next(lowerRange, upperRange);
        }
    } 
}
