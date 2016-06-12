using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Controls;

namespace CSharpAcademiProject
{
    enum scoreMarker { Victory, Defeat, Undecided }
    class Game
    {
        public int matchNumber = 6;
        public int fieldNumber = 4;
        public int colorNumber = 6;
        public int MaxMatchNumber
        {
            get;
            set;
        }
        public int GameTime
        {
            get;
            set;
        }   
        public scoreMarker FinalScore
        {
            get;
            set;
        }
        public int PlayCounter
        {
            get;
            set;
        }
        public scoreMarker[][] Score
        {
            get;
            set;
        }  
        public Game(int playValue)
        {
            this.PlayCounter = playValue;
            Score = new scoreMarker[this.matchNumber][];
        }
        public void decideFinalScore(TextBlock showScoreText, int matchCounter)
        {
            bool somethingWrong = false;
            somethingWrong = false;
                for (int fieldsCounter = 0; fieldsCounter < this.fieldNumber; fieldsCounter++)
                {
                    if (Score[matchCounter][fieldsCounter] != scoreMarker.Victory)
                    {
                        somethingWrong = true;
                    }
                }
            if (somethingWrong == false)
            {
                showScoreText.Text = "You win!";
                this.FinalScore = scoreMarker.Victory;
            }
            else if (matchCounter == this.matchNumber - 1)
            {
                showScoreText.Text = "You lose";
                this.FinalScore = scoreMarker.Defeat;
            }
            else
            {
                this.FinalScore = scoreMarker.Undecided;
            }
        }
    }
}
