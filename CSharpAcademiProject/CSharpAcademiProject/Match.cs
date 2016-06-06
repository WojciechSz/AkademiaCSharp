using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAcademiProject
{
    class Match: Game
    {
        public int MatchCounter
        {
            get;
            set;
        }
        public Match (int matchValue)
        {
            this.MatchCounter = matchValue;
        }
    }
}
