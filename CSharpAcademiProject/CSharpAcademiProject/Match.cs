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
    } 
}
