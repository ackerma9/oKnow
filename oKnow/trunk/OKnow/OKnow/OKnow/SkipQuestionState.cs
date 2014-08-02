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
    /// Describes the skip question powerup state
    /// </summary>
    public class SkipQuestionState : PlayerMoveState
    {
        /// <summary>
        /// When a tile is clicked in this state, don't pick a question, just pretend that they answered it correctly
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

                    this.QuestionAnswered(true, question);
                    Game.GameState = new PlayerMoveState();
                }
                else if (tile.GetType() == typeof(EndTile))
                {
                    Game1.GameSingleton.EndGame();
                }
            }
        }

        /// <summary>
        /// Return the name of this powerup state
        /// </summary>
        public override String Name
        {
            get { return "Skip A Question"; }
        }

        /// <summary>
        /// If a powerup is used in this state, do nothing
        /// </summary>
        public override void UsePowerUp()
        {
        }
    }
}
