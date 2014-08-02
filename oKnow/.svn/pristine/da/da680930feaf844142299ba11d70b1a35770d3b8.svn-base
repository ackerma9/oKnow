using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OKnow.StaticContent;
using OKnow.Questions;
using OKnow.Pieces;
using Microsoft.Xna.Framework.Media;

namespace OKnow
{
    /// <summary>
    /// Describes the most common stae, the player move state
    /// </summary>
    public class PlayerMoveState : NoOpGameState
    {
        protected AbstractTile questionTile = null;

        /// <summary>
        /// When a tile is clicked, check to make sure it is a valid tile and handle the question that the user is given
        /// </summary>
        /// <param name="tile">Tile that was clicked</param>
        public override void TileClick(AbstractTile tile)
        {
            AbstractTile playerTile = Game1.GameSingleton.GameBoard.CurrentPlayer.GetTile();
            Question question;

            if (playerTile.IsAdjacent(tile) &&
                Game.CurrentScreen == Screen.BOARD)
            {
                if (tile.GetType() != typeof(EndTile) &&
                    tile.GetType() != typeof(StartTile))
                {
                    questionTile = tile;
                    if (questionTile.GetType() == typeof(MusicTile))
                    {
                        question = BoardGenerator.pool.GetRandomMusicQuestion(Game.GameBoard.Category);
                    }
                    else if (questionTile.GetType() == typeof(ImageTile))
                    {
                        question = BoardGenerator.pool.GetRandomImageQuestion(Game.GameBoard.Category);
                    }
                    else
                    {
                        question = BoardGenerator.pool.GetRandQuestion(Game.GameBoard.Category);
                    }

                    if (question.GetQuestionType() == QuestionType.MUSIC)
                    {
                        question.PlaySound();
                    }

                    Game.ShowQuestion(question, questionTile);

                }
                else if (tile.GetType() == typeof(EndTile))
                {
                    Game1.GameSingleton.EndGame();
                }
            }
        }

        /// <summary>
        /// Handle how to react to the question being answered
        /// </summary>
        /// <param name="isCorrect">Whether or not the question was answered correctly or not</param>
        /// <param name="question">The question that was answered</param>
        public override void QuestionAnswered(bool isCorrect, Question question)
        {
            if (questionTile == null)
            {
                throw new Exception("No question yet");
            }

            MediaPlayer.Stop();
            Player currentPlayer = Game.GameBoard.CurrentPlayer;

            if (isCorrect)
            {
                //question is correct
                currentPlayer.totalScore += question.GetPoints(currentPlayer.attempt);
                currentPlayer.attempt = 1;

                currentPlayer.SetTile(questionTile);

            }
            else
            {
                //question is incorrect
                currentPlayer.attempt += 1;

                if (questionTile.GetType() == typeof(DeathTile))
                {
                    currentPlayer.SetTile(BoardGenerator.StartTile);
                }
            }

            questionTile = null;
            Game.ShowBoard();
            Game.GameBoard.NextTurn();
        }

        /// <summary>
        /// Show the game board when this state is activated
        /// </summary>
        public override void Activate()
        {
            Game.ShowBoard();
        }

        /// <summary>
        /// Return the name of this state
        /// </summary>
        public override String Name
        {
            get { return "Normal"; }
        }

        /// <summary>
        /// Usng a powerup in this state simply consumes the powerup and sets the game state to whatever state is associated with the powerup
        /// </summary>
        public override void UsePowerUp()
        {
            IGameState powerUpTemp = Game.GameBoard.CurrentPlayer.ConsumePowerUp();
            if (powerUpTemp != null)
            {
                Game.GameState = powerUpTemp;
            }
        }
    }
}
