using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OKnow.Questions;
using OKnow.Pieces;

namespace OKnow
{
    /// <summary>
    /// Describes the No-Op Game State
    /// </summary>
    public class NoOpGameState : IGameState
    {
        /// <summary>
        /// Do nothing if a tile is clicked
        /// </summary>
        /// <param name="tile">the tile that was clicked</param>
        public virtual void TileClick(AbstractTile tile)
        {
        }

        /// <summary>
        /// Do nothing if question is answered
        /// </summary>
        /// <param name="isCorrect">Whether the question was answered correctly or not</param>
        /// <param name="question">What question was answered</param>
        public virtual void QuestionAnswered(bool isCorrect, Question question)
        {
        }

        /// <summary>
        /// Do nothing if this state is activated
        /// </summary>
        public virtual void Activate()
        {
        }

        /// <summary>
        /// Do nothing if user tries to use a power up in this state
        /// </summary>
        public virtual void UsePowerUp()
        {
        }

        /// <summary>
        /// Return a reference to the game singleton
        /// </summary>
        protected Game1 Game
        {
            get { return Game1.GameSingleton; }
        }

        /// <summary>
        /// Get the name of this state
        /// </summary>
        public virtual String Name
        {
             get { return "No Operation";} 
        }
    }
}
