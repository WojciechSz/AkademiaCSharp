using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAcademiProject
{
    enum scoreMarker { Victory, Defeat, Outstanding }
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
        public List <int> Score
        {
            get;
            set;
        }   
        public Game()
        {
            this.PlayCounter = 1;
            Score = new List<int>();
        }
        public void decideScore()
        {
            //Tutaj na podstawie tablicy - score, sprawdzimy czy wszystkie elementy sa rowne 2. wielowatkowo

        }
        public void decideFinalScore()
        {
            /*if(obiektPartii.decideScore==Victory)
             {
                this.FinalScore = scoreMarker.Victory;
             }
             if(obiektMatch.decideScore==Defeat)
             {
                if(obiektMatchPlayCounter==lastMatch)
                {
                    this.FinalScore = scoreMarker.Defeat;     
                }   
                 else
                {
                    this.FinalScore = scoreMarker.Outstanding;
                }
             }
             */
        }
    }
}
