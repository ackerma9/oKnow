using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OKnow.Questions;
using OKnow.Pieces;

namespace OKnow
{
    public class NoOpGameState : IGameState
    {
        public virtual void TileClick(AbstractTile tile)
        {
        }

        public virtual void QuestionAnswered(bool isCorrect, Question question)
        {
        }

        public virtual void Activate()
        {
        }

        public virtual void UsePowerUp()
        {
        }

        protected Game1 Game
        {
            get { return Game1.GameSingleton; }
        }

        public virtual String Name
        {
             get { return "No Operation";} 
        }
    }
}
