using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using OKnow.Questions;
using OKnow.Pieces;

namespace OKnow
{
    public interface IGameState
    {
        void Activate();

        void TileClick(AbstractTile tile);

        void QuestionAnswered(Boolean isCorrect, Question question);

        void UsePowerUp();

        String Name
        {
            get;
        }


    }
}
