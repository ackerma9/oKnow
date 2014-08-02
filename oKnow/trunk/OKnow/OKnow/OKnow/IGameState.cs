using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using OKnow.Questions;
using OKnow.Pieces;

namespace OKnow
{
    /// <summary>
    /// Describes the interface for the different game states
    /// </summary>
    public interface IGameState
    {
        /// <summary>
        /// Function that will be called any time the state is activated
        /// </summary>
        void Activate();

        /// <summary>
        /// How to handle a tile click while in a specific state
        /// </summary>
        /// <param name="tile">Tile that was clicked</param>
        void TileClick(AbstractTile tile);

        /// <summary>
        /// How to handle a question being answered while in this state
        /// </summary>
        /// <param name="isCorrect">Whether the question was answered correctly or not</param>
        /// <param name="question">The question that was answered</param>
        void QuestionAnswered(Boolean isCorrect, Question question);

        /// <summary>
        /// Current player uses the powerup
        /// </summary>
        void UsePowerUp();

        /// <summary>
        /// Name of state
        /// </summary>
        String Name
        {
            get;
        }


    }
}
