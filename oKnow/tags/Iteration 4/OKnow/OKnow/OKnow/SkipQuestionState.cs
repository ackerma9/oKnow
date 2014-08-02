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
    public class SkipQuestionState : PlayerMoveState
    {
        public override void TileClick(AbstractTile tile)
        {
            AbstractTile playerTile = Game1.GameSingleton.GameBoard.CurrentPlayer.getTile();
            Question question;

            if (tile.GetType() != typeof(EndTile) &&
                tile.GetType() != typeof(StartTile) &&
                playerTile.IsAdjacent(tile) &&
                Game.CurrentScreen == Screen.BOARD)
            {
                questionTile = tile;
                if (questionTile.GetType() == typeof(MusicTile))
                {
                    question = BoardGenerator.pool.getRandomMusicQuestion(Game.GameBoard.Category);
                }
                else if (questionTile.GetType() == typeof(ImageTile))
                {
                    question = BoardGenerator.pool.getRandomImageQuestion(Game.GameBoard.Category);
                }
                else
                {
                    question = BoardGenerator.pool.getRandQuestion(Game.GameBoard.Category);
                }

                this.QuestionAnswered(true, question);
                Game.GameState = new PlayerMoveState();
            }
            else if (tile.GetType() == typeof(EndTile))
            {
                Game1.GameSingleton.EndGame();
            }
        }

        public override String Name
        {
            get { return "Skip A Question"; }
        }
    }
}
